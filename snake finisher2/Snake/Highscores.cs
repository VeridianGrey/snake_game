using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Snake
{
    public partial class Highscores : Form
    {
        public Highscores()
        {
            InitializeComponent();
        }

        private void scoresBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            Validate();
            scoresBindingSource.EndEdit();
            tableAdapterManager.UpdateAll(scoresDataSet);
        }

        private void Highscores_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'scoresDataSet.scores' table. You can move, or remove it, as needed.
            scoresTableAdapter.Fill(scoresDataSet.scores);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
