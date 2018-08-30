using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Snake
{
    public partial class enterName : Form
    {
        private int score;
        String name;
        bool dif1;
        bool dif2;
        bool dif3;
        bool dif4;
		String mode;

        public enterName(int Score,bool Dif1,bool Dif2,bool Dif3,bool Dif4)
        {
            InitializeComponent();
            score = Score;
            dif1 = Dif1;
            dif2 = Dif2;
            dif3 = Dif3;
            dif4 = Dif4;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            OleDbConnection conn = new OleDbConnection();
            //conn.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=scores.accdb";
            conn.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=H:\\Documents\\scores.accdb";
			
			if(string.IsNullOrWhiteSpace(tbName.Text))
			{
                errorProvider1.SetError(tbName, "Can't leave this empty.");
			}else{
			name = tbName.Text;
			}
            
			
			if(dif1 == true){
                mode = "Easy";
			}
		    else if(dif2 == true){
				mode = "Medium";
			}
			else if(dif3 == true){
                mode = "Hard";
			}else if(dif4 == true){
                mode = "Nightmare";
            }
			

            OleDbCommand cmd = new OleDbCommand("INSERT into scores (Naam, Highscore, Moeilijkheid) Values(@name, @score, @mode)");
            cmd.Connection = conn;

            conn.Open();

            if (conn.State == ConnectionState.Open)
            {
                cmd.Parameters.Add("@name", OleDbType.VarChar).Value = name;
                cmd.Parameters.Add("@score", OleDbType.VarChar).Value = score;
				cmd.Parameters.Add("@mode", OleDbType.VarChar).Value = mode;

                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Data Added");
                    conn.Close();
                }
                catch (OleDbException ex)
                {
                    MessageBox.Show(ex.Source);
                    conn.Close();
                }
            }
            else
            {
                MessageBox.Show("Connection Failed");
            }
            Highscores highscores = new Highscores();
            highscores.Show();
            this.Close();
        }
    }
}
