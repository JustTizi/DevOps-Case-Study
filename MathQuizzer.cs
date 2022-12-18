using Case_Study;
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
        Difficulty diff;

        
        public MathQuizzer(Difficulty difficulty)
        {
            switch (difficulty.Level)
            {
                case "Easy":
                    diff = new Easy();
                    break;
                case "Normal":
                    diff = new Normal();
                    break;
                case "Hard":
                    diff = new Hard();
                    break;
                default:
                    diff = new Easy();
                    break;
            }
            InitializeComponent();
            MathQuizzer_Load(diff);
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
                    MathQuizzer_Load(diff);
                }
                else
                {
                    MessageBox.Show("Oh no! You got it wrong...");
                    GameOver gameOver = new GameOver(correctAnswers, diff);
                    gameOver.Show();
                    this.Hide();
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

        private void MathQuizzer_Load(Difficulty difficulty)
        {
            
            Random rnd = new Random();
            string[] operands = difficulty.Operands;
            int operand = rnd.Next(0, operands.Length);
            int firstNumber = rnd.Next(difficulty.MinValue, difficulty.MaxValue);
            int secondNumber = rnd.Next(difficulty.MinValue, difficulty.MaxValue);
            
            

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

        private void exitGame(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
