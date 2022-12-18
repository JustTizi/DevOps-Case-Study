using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Case_Study
{
    public partial class DifficultySelection : Form
    {
        public DifficultySelection()
        {
            InitializeComponent();
            
            Easy easy = new Easy();
            Normal normal = new Normal();
            Hard hard = new Hard();

            using (SQLiteConnection conn = Program.CreateConnection()) {
                Program.CreateTable(conn);

                string[] highscoreEasy = Program.SelectData(conn, easy);
                string[] highscoreNormal = Program.SelectData(conn, normal);
                string[] highscoreHard = Program.SelectData(conn, hard);

                highPlayerEasy.Text = "Highscore by " + highscoreEasy[0];
                highScoreEasy.Text = "Score: " + highscoreEasy[1];
                highPlayerNormal.Text = "Highscore by " + highscoreNormal[0];
                highScoreNormal.Text = "Score: " + highscoreNormal[1];
                highPlayerHard.Text = "Highscore by " + highscoreHard[0];
                highScoreHard.Text = "Score: " + highscoreHard[1];

                conn.Close();
            }
        }

        private void easy_Click(object sender, EventArgs e)
        {
            MathQuizzer mathQuizzer = new MathQuizzer(new Easy());
            mathQuizzer.Show();
            this.Hide();
        }

        private void normal_Click(object sender, EventArgs e)
        {
            MathQuizzer mathQuizzer = new MathQuizzer(new Normal());
            mathQuizzer.Show();
            this.Hide();
        }
        
        private void hard_Click(object sender, EventArgs e)
        {
            MathQuizzer mathQuizzer = new MathQuizzer(new Hard());
            mathQuizzer.Show();
            this.Hide();
        }

        private void exitGame(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
