namespace Case_Study
{
    partial class MathQuizzer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MathQuizzer));
            this.score = new System.Windows.Forms.Label();
            this.firstNumber = new System.Windows.Forms.Label();
            this.secondNumber = new System.Windows.Forms.Label();
            this.operand = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.correct = new System.Windows.Forms.Label();
            this.answer = new System.Windows.Forms.TextBox();
            this.btnCheckAnswer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // score
            // 
            this.score.AutoSize = true;
            this.score.BackColor = System.Drawing.SystemColors.Control;
            this.score.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.score.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.score.Location = new System.Drawing.Point(12, 9);
            this.score.Name = "score";
            this.score.Size = new System.Drawing.Size(72, 18);
            this.score.TabIndex = 0;
            this.score.Text = "Score: 0";
            // 
            // firstNumber
            // 
            this.firstNumber.AutoSize = true;
            this.firstNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstNumber.Location = new System.Drawing.Point(106, 66);
            this.firstNumber.Name = "firstNumber";
            this.firstNumber.Size = new System.Drawing.Size(55, 37);
            this.firstNumber.TabIndex = 1;
            this.firstNumber.Text = "00";
            // 
            // secondNumber
            // 
            this.secondNumber.AutoSize = true;
            this.secondNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.secondNumber.Location = new System.Drawing.Point(347, 66);
            this.secondNumber.Name = "secondNumber";
            this.secondNumber.Size = new System.Drawing.Size(55, 37);
            this.secondNumber.TabIndex = 2;
            this.secondNumber.Text = "00";
            // 
            // operand
            // 
            this.operand.AutoSize = true;
            this.operand.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.operand.Location = new System.Drawing.Point(235, 66);
            this.operand.Name = "operand";
            this.operand.Size = new System.Drawing.Size(37, 37);
            this.operand.TabIndex = 3;
            this.operand.Text = "+";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(481, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 37);
            this.label3.TabIndex = 4;
            this.label3.Text = "=";
            // 
            // correct
            // 
            this.correct.AutoSize = true;
            this.correct.BackColor = System.Drawing.SystemColors.Control;
            this.correct.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.correct.ForeColor = System.Drawing.Color.Green;
            this.correct.Location = new System.Drawing.Point(349, 205);
            this.correct.Name = "correct";
            this.correct.Size = new System.Drawing.Size(0, 25);
            this.correct.TabIndex = 5;
            // 
            // answer
            // 
            this.answer.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.answer.Location = new System.Drawing.Point(594, 66);
            this.answer.Name = "answer";
            this.answer.Size = new System.Drawing.Size(100, 44);
            this.answer.TabIndex = 6;
            // 
            // btnCheckAnswer
            // 
            this.btnCheckAnswer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnCheckAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckAnswer.ForeColor = System.Drawing.Color.Black;
            this.btnCheckAnswer.Location = new System.Drawing.Point(340, 130);
            this.btnCheckAnswer.Name = "btnCheckAnswer";
            this.btnCheckAnswer.Size = new System.Drawing.Size(105, 60);
            this.btnCheckAnswer.TabIndex = 7;
            this.btnCheckAnswer.Text = "Check Answer";
            this.btnCheckAnswer.UseVisualStyleBackColor = false;
            this.btnCheckAnswer.Click += new System.EventHandler(this.ButtonClick);
            // 
            // MathQuizzer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 250);
            this.Controls.Add(this.btnCheckAnswer);
            this.Controls.Add(this.answer);
            this.Controls.Add(this.correct);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.operand);
            this.Controls.Add(this.secondNumber);
            this.Controls.Add(this.firstNumber);
            this.Controls.Add(this.score);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MathQuizzer";
            this.Text = "Math Quizzer - Game";
            this.ResumeLayout(false);
            this.PerformLayout();

        }



        #endregion

        private System.Windows.Forms.Label score;
        private System.Windows.Forms.Label firstNumber;
        private System.Windows.Forms.Label secondNumber;
        private System.Windows.Forms.Label operand;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label correct;
        private System.Windows.Forms.TextBox answer;
        private System.Windows.Forms.Button btnCheckAnswer;
    }
}
