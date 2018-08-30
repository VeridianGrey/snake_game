namespace Snake
{
    public enum Direction
    {
        Up,
        Down,
        Left,
        Right
    };
    // speed is een if statement geworden wie afhankelijk is van welke difficulty is geselecteerd
    public class Settings
    {
        public static int Width { get; set; }
        public static int Height { get; set; }
        //public static int Speed { get; set; }
        public static int Score { get; set; }
        public static int Points { get; set; }
        public static bool GameOver { get; set; }
        public static Direction direction { get; set; }
        public bool Easy { get; set; }
        public bool Medium { get; set; }
        public bool Hard { get; set; }
        public bool Nightmare { get; set; }

        public Settings()
        {
            Width = 16;
            Height = 16;
            //Speed = 18;
            Score = 0;
            Points = 100;
            GameOver = false;
            direction = Direction.Down;
            Easy = false;
            Medium = false;
            Hard = false;
            Nightmare = false;
        }
    }


}
