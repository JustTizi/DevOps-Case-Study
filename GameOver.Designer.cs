namespace Case_Study
{
    partial class GameOver
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameOver));
            this.score = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nameField = new System.Windows.Forms.TextBox();
            this.submitName = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // score
            // 
            this.score.AutoSize = true;
            this.score.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.score.ForeColor = System.Drawing.Color.Fuchsia;
            this.score.Location = new System.Drawing.Point(289, 48);
            this.score.Name = "score";
            this.score.Size = new System.Drawing.Size(209, 32);
            this.score.TabIndex = 0;
            this.score.Text = "Your final Score: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(166, 155);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(236, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "Please enter your name:";
            // 
            // nameField
            // 
            this.nameField.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nameField.Location = new System.Drawing.Point(408, 156);
            this.nameField.Name = "nameField";
            this.nameField.Size = new System.Drawing.Size(205, 33);
            this.nameField.TabIndex = 2;
            // 
            // submitName
            // 
            this.submitName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.submitName.Location = new System.Drawing.Point(362, 214);
            this.submitName.Name = "submitName";
            this.submitName.Size = new System.Drawing.Size(75, 32);
            this.submitName.TabIndex = 3;
            this.submitName.Text = "Submit";
            this.submitName.UseVisualStyleBackColor = true;
            this.submitName.Click += new System.EventHandler(this.submitName_Click);
            // 
            // GameOver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 272);
            this.Controls.Add(this.submitName);
            this.Controls.Add(this.nameField);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.score);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GameOver";
            this.Text = "GameOver";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.exitGame);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label score;
        private Label label1;
        private TextBox nameField;
        private Button submitName;
    }
}