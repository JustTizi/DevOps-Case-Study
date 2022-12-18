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
    public partial class MathQuizzer : Form
    {
        Random rnd = new Random();
        string[] operands = { "+", "-", "*", "/" };
        Double total;
        int correctAnswers;


        public MathQuizzer()
        {
            InitializeComponent();
            MathQuizzer_Load();
        }

        private void ButtonClick(object sender, EventArgs e)
        {
            
            if (System.Text.RegularExpressions.Regex.IsMatch(answer.Text, "^-?\\d*\\.?\\d+$"))
            {
                Double userAnswer = Convert.ToDouble(answer.Text, System.Globalization.CultureInfo.CreateSpecificCulture("en-US"));
                if (total == userAnswer)
                {
                    correctAnswers++;
                    correct.Text = "Correct!";
                    correct.ForeColor = Color.Green;
                    score.Text = "Score: " + correctAnswers.ToString();
                    answer.Text = answer.Text.Remove(0);
                    MathQuizzer_Load();
                }
                else
                {
                    correct.Text = "Incorrect!";
                    correct.ForeColor = Color.Red;
                }
            }
            else
            {
                
                if (answer.Text == "")
                {
                    MessageBox.Show("Please enter a number.");
                    ;
                }
                else
                {
                    MessageBox.Show("Please only use numbers, the period (.) or the minus (-) sign.");
                    answer.Text = answer.Text.Remove(0);
                }
            }
            
        }

        private void MathQuizzer_Load()
        {
            
            int firstNumber = rnd.Next(1, 1000);
            int secondNumber = rnd.Next(1, 1000);
            int operand = rnd.Next(0, 4);

            switch (operands[operand])
            {
                case "+":
                    total = Math.Round((Double)firstNumber + secondNumber, 2);
                    break;
                case "-":
                    total = Math.Round((Double)firstNumber - secondNumber, 2);
                    break;
                case "*":
                    total = Math.Round((Double)firstNumber * secondNumber, 2);
                    break;
                case "/":
                    total = Math.Round((Double)firstNumber / secondNumber, 2);
                    break;
                default:
                    //How did you even get here?
                    break;
            }

            this.firstNumber.Text = firstNumber.ToString();
            this.secondNumber.Text = secondNumber.ToString();
            this.operand.Text = operands[operand];
            
        }
        
    }
}
