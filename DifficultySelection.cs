using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        }

        private void easy_Click(object sender, EventArgs e)
        {
            MathQuizzer mathQuizzer = new MathQuizzer();
            mathQuizzer.Show();
            this.Hide();
        }

        private void normal_Click(object sender, EventArgs e)
        {
            MathQuizzer mathQuizzer = new MathQuizzer();
            mathQuizzer.Show();
            this.Hide();
        }

        private void hard_Click(object sender, EventArgs e)
        {
            MathQuizzer mathQuizzer = new MathQuizzer();
            mathQuizzer.Show();
            this.Hide();
        }
    }
}
