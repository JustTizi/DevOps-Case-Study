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
    public partial class GameOver : Form
    {
        int finalScore;
        Difficulty diff;

        public GameOver(int totalScore, Difficulty difficulty)
        {
            InitializeComponent();
            finalScore = totalScore;
            diff = difficulty;
            score.Text = "Your final Score:\n" + totalScore.ToString();
        }

        private void submitName_Click(object sender, EventArgs e)
        {
            if (nameField.Text == "")
            {
                MessageBox.Show("Please enter a name");
            }
            else if (nameField.Text.Length > 20)
            {
                MessageBox.Show("Please enter a name less than 20 characters");
            }
            else
            {
                using (SQLiteConnection conn = Program.CreateConnection())
                {
                    Program.InsertData(conn, nameField.Text, finalScore, diff);

                    conn.Close();
                }
                MessageBox.Show("Thank you for playing!");
                Application.Exit();
            }
           
        }

        private void exitGame(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
