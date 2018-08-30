using System;
using System.Collections.Generic;
using System.Drawing;
using System.Media;
using System.Windows.Forms;
using System.Xml;

namespace Snake
{
    public partial class FRMsnake : Form
    {
        private List<Point> Snake = new List<Point>();
        private List<Point> Food = new List<Point>();
        private Point food = new Point();
        private Point head = new Point();
        SoundPlayer player = new SoundPlayer();
        private Point circle = new Point();
        Random random = new Random();
        private Settings mysettings = new Settings();
       
        public FRMsnake()
        {
            InitializeComponent();
            // generateLabel();
            //Set settings to default
            new Settings();

            player.SoundLocation = AppDomain.CurrentDomain.BaseDirectory + "music.wav";
            player.Play();
        }

        //game tekenen en start methodes
        private void StartGame()
        {
            PBGameOver.Visible = false;
            lblGameOver.Visible = false;

            //Set settings to default
            new Settings();

            //Create new player object
            Snake.Clear();
            head  = new Point {X = 10, Y = 5};
            Snake.Add(head);

            lblScore.Text = Settings.Score.ToString();


            GenerateFood();

        }
        private void UpdateScreen(object sender, EventArgs e)
        {
            //Check for Game Over
            if (Settings.GameOver)
            {
                //Check if Enter is pressed
                if (Input.KeyPressed(Keys.Enter))
                {
                    Controls.Remove(BTNmainmenu);
                    StartGame();
                }
            }
            else
            {
                if (Input.KeyPressed(Keys.Right) && Settings.direction != Direction.Left)
                    Settings.direction = Direction.Right;
                else if (Input.KeyPressed(Keys.Left) && Settings.direction != Direction.Right)
                    Settings.direction = Direction.Left;
                else if (Input.KeyPressed(Keys.Up) && Settings.direction != Direction.Down)
                    Settings.direction = Direction.Up;
                else if (Input.KeyPressed(Keys.Down) && Settings.direction != Direction.Up)
                    Settings.direction = Direction.Down;

                MovePlayer();
            }

            pbCanvas.Invalidate();

        }
        private void pbCanvas_Paint(object sender, PaintEventArgs e)
        {
            Graphics canvas = e.Graphics;
            if (!Settings.GameOver)
            {
                PBGameOver.Visible = false;
                //Set colour of snake
                //Draw snake
                for (int i = 0; i < Snake.Count; i++)
                {
                    Brush snakeColour;
                    
                    if (i == 0)
                        snakeColour = Brushes.Green;     //Draw head
                    else
                        snakeColour = Brushes.Black;    //Rest of body
                    //Draw snake
                    canvas.FillEllipse(snakeColour,
                        new Rectangle(Snake[i].X * Settings.Width,
                                      Snake[i].Y * Settings.Height,
                                      Settings.Width, Settings.Height));


                }
                //DRAW AND SET COLOR OF FOOD
                for (int i = 0; i < Food.Count; i++)
                {
                    Brush foodColour;
                    foodColour = Brushes.Red;

                    //Draw Food
                    canvas.FillEllipse(foodColour,
                    new Rectangle(Food[i].X * Settings.Width,
                    Food[i].Y * Settings.Height,
                    Settings.Width,
                    Settings.Height));

                } 
            }
            else
            {
                Controls.Add(BTNmainmenu);
                BTNmainmenu.Visible = true;
                PBGameOver.Visible = true;
                string gameOver = "" + Settings.Score;
                lblGameOver.Text = gameOver;
                lblGameOver.Visible = true;
                lblGameOver.BringToFront();
                BTNmainmenu.BringToFront();
            }
        }
        //voedel objecten

        private void GenerateFood()
        {
            Food.Remove(food);

            int maxXPos = pbCanvas.Size.Width / Settings.Width;
            int maxYPos = pbCanvas.Size.Height / Settings.Height;

            int X = random.Next(0, maxXPos);
            int Y = random.Next(0, maxYPos);
            food = new Point(X,Y);
            Food.Add(food);
        }

        private void Eat()
        {
            
            //Add circle to body
            GenerateFood();
            
            //Update Score
            Settings.Score += Settings.Points;
            lblScore.Text = Settings.Score.ToString();
        }

        //speler functies
        private void MovePlayer()
        {
            for (int i = Snake.Count - 1; i >= 0; i--)
            {
                //Move head
                if (i == 0)
                {
                    switch (Settings.direction)
                    {
                        case Direction.Right:
                            Snake[i] = new Point(Snake[i].X + 1, Snake[i].Y);
                            break;
                        case Direction.Left:
                            Snake[i] = new Point(Snake[i].X - 1, Snake[i].Y);
                            break;
                        case Direction.Up:
                            Snake[i] = new Point(Snake[i].X, Snake[i].Y - 1);
                            break;
                        case Direction.Down:
                            Snake[i] = new Point(Snake[i].X, Snake[i].Y + 1);
                            break;
                    }

                    //Get maximum X and Y Pos
                    int maxXPos = pbCanvas.Size.Width / Settings.Width;
                    int maxYPos = pbCanvas.Size.Height / Settings.Height;

                    //Detect collission with game borders.
                    if (Snake[i].X < 0 || Snake[i].Y < 0
                        || Snake[i].X >= maxXPos || Snake[i].Y >= maxYPos)
                    {
                        Die();
                    }
                    //Detect collission with body
                    for (int j = 1; j < Snake.Count; j++)
                    {
                        if (Snake[i].X == Snake[j].X &&
                           Snake[i].Y == Snake[j].Y)
                        {
                            Die();
                        }
                    }
                    //Detect collision with food piece
                    if (Snake[0].X == Food[i].X && Snake[0].Y == Food[i].Y)
                    {

                        circle.X = Snake[Snake.Count - 1].X;
                        circle.Y = Snake[Snake.Count - 1].Y;
                        Snake.Add(circle);
                        Eat();
                    }



                }
                else
                {
                    //Move body
                    int Y = Snake[i - 1].Y;
                    int X = Snake[i - 1].X;
                    Snake[i] = new Point(X, Y);
                }
            }
        }

        private void FRMsnake_KeyDown(object sender, KeyEventArgs e)
        {
            Input.ChangeState(e.KeyCode, true);
        }
        private void FRMsnake_KeyUp(object sender, KeyEventArgs e)
        {
            Input.ChangeState(e.KeyCode, false);
        }
        private void Die()
        {
            Settings.GameOver = true;
            enterName EnterName = new enterName(Settings.Score,mysettings.Easy,mysettings.Medium,mysettings.Hard,mysettings.Nightmare);
            EnterName.Show();
        }



        //start en gameover
        private void BTNgamestart_Click(object sender, EventArgs e)
        {
            //verwijder vorige knoppen
            Controls.Remove(BTNgamestart);
            Controls.Remove(BTNinfo);

            //show difficulty settings
            label2.Visible = true;
            BTNeasymode.Visible = true;
            BTNmediummode.Visible = true;
            BTNhardmode.Visible = true;
            BTNnightmare.Visible = true;

        }

        //moeilijkheids knoppen en functies 
        private void BTNeasymode_Click(object sender, EventArgs e)
        {
           Remove_Difficulty_Buttons();

            mysettings.Easy = true;

            if (mysettings.Easy == true)
            {
                gameTimer.Interval = 1000 / 18;
                gameTimer.Tick += UpdateScreen;
                gameTimer.Start();
            }
            

            StartGame();
            player.Stop();
        }
        private void BTNmediummode_Click(object sender, EventArgs e)
        {
            Remove_Difficulty_Buttons();

            mysettings.Medium = true;

            if (mysettings.Medium == true)
            {
                gameTimer.Interval = 1000 / 36;
                gameTimer.Tick += UpdateScreen;
                gameTimer.Start();
            }
            

            StartGame();
            player.Stop();
        }
        private void BTNhardmode_Click(object sender, EventArgs e)
        {
            Remove_Difficulty_Buttons();

            mysettings.Hard = true;

            if (mysettings.Hard == true)
            {
                gameTimer.Interval = 1000 / 54;
                gameTimer.Tick += UpdateScreen;
                gameTimer.Start();
            }
            

            StartGame();
            player.Stop();
        }
        private void BTNnightmare_Click(object sender, EventArgs e)
        {
            Remove_Difficulty_Buttons();

            mysettings.Nightmare = true;

            if (mysettings.Nightmare == true)
            {
                gameTimer.Interval = 1000 / 100;
                gameTimer.Tick += UpdateScreen;
                gameTimer.Start();
            }

            StartGame();
            player.Stop();
        }
        private void Remove_Difficulty_Buttons()
        {
            Controls.Remove(PBOXstart);
            Controls.Remove(label2);
            Controls.Remove(BTNeasymode);
            Controls.Remove(BTNmediummode);
            Controls.Remove(BTNhardmode);
            Controls.Remove(BTNnightmare);
        }


        //instructie knop
        private void BTNinfo_Click(object sender, EventArgs e)
        {
            string Info = "Eat the food pieces to enlarge your snake.\n\nWhen your snake hits itself or the walls you're gameover.\n\nAfter you're gameover enter your name to view the highscore list.";
            MessageBox.Show(Info);
        }
        //game opnieuwe beginnen door te klikken 
        private void PBGameOver_Click(object sender, EventArgs e)
        {
            Controls.Remove(BTNmainmenu);
            StartGame();

        }
        //terug naar main menu
        private void BTNmainmenu_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        
        
    }
}
