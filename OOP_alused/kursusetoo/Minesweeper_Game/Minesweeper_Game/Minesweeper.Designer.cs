namespace Minesweeper_Game
{
    partial class Minesweeper
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.GameArea = new System.Windows.Forms.Panel();
            this.GameOverLabel = new System.Windows.Forms.Label();
            this.RestartButton = new System.Windows.Forms.Button();
            this.FieldsLeftLabel = new System.Windows.Forms.Label();
            this.FieldsLeftCounterLabel = new System.Windows.Forms.Label();
            this.GameArea.SuspendLayout();
            this.SuspendLayout();
            // 
            // GameArea
            // 
            this.GameArea.Controls.Add(this.GameOverLabel);
            this.GameArea.Controls.Add(this.RestartButton);
            this.GameArea.Location = new System.Drawing.Point(209, 22);
            this.GameArea.Name = "GameArea";
            this.GameArea.Size = new System.Drawing.Size(500, 500);
            this.GameArea.TabIndex = 0;
            // 
            // GameOverLabel
            // 
            this.GameOverLabel.AutoSize = true;
            this.GameOverLabel.BackColor = System.Drawing.Color.Transparent;
            this.GameOverLabel.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.GameOverLabel.ForeColor = System.Drawing.Color.Black;
            this.GameOverLabel.Location = new System.Drawing.Point(162, 190);
            this.GameOverLabel.Name = "GameOverLabel";
            this.GameOverLabel.Size = new System.Drawing.Size(192, 45);
            this.GameOverLabel.TabIndex = 2;
            this.GameOverLabel.Text = "Game over!";
            this.GameOverLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.GameOverLabel.Visible = false;
            // 
            // RestartButton
            // 
            this.RestartButton.Location = new System.Drawing.Point(216, 262);
            this.RestartButton.Name = "RestartButton";
            this.RestartButton.Size = new System.Drawing.Size(75, 23);
            this.RestartButton.TabIndex = 1;
            this.RestartButton.Text = "Restart";
            this.RestartButton.UseVisualStyleBackColor = true;
            this.RestartButton.Visible = false;
            this.RestartButton.Click += new System.EventHandler(this.RestartButton_Click);
            // 
            // FieldsLeftLabel
            // 
            this.FieldsLeftLabel.AutoSize = true;
            this.FieldsLeftLabel.BackColor = System.Drawing.Color.Transparent;
            this.FieldsLeftLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.FieldsLeftLabel.ForeColor = System.Drawing.Color.Black;
            this.FieldsLeftLabel.Location = new System.Drawing.Point(12, 22);
            this.FieldsLeftLabel.Name = "FieldsLeftLabel";
            this.FieldsLeftLabel.Size = new System.Drawing.Size(112, 32);
            this.FieldsLeftLabel.TabIndex = 3;
            this.FieldsLeftLabel.Text = "To reveal";
            this.FieldsLeftLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FieldsLeftCounterLabel
            // 
            this.FieldsLeftCounterLabel.AutoSize = true;
            this.FieldsLeftCounterLabel.BackColor = System.Drawing.Color.Transparent;
            this.FieldsLeftCounterLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.FieldsLeftCounterLabel.ForeColor = System.Drawing.Color.Black;
            this.FieldsLeftCounterLabel.Location = new System.Drawing.Point(135, 22);
            this.FieldsLeftCounterLabel.Name = "FieldsLeftCounterLabel";
            this.FieldsLeftCounterLabel.Size = new System.Drawing.Size(56, 32);
            this.FieldsLeftCounterLabel.TabIndex = 4;
            this.FieldsLeftCounterLabel.Text = "###";
            this.FieldsLeftCounterLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Minesweeper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 549);
            this.Controls.Add(this.FieldsLeftCounterLabel);
            this.Controls.Add(this.FieldsLeftLabel);
            this.Controls.Add(this.GameArea);
            this.Name = "Minesweeper";
            this.Text = "Form1";
            this.GameArea.ResumeLayout(false);
            this.GameArea.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel GameArea;
        private Button RestartButton;
        private Label GameOverLabel;
        private Label FieldsLeftLabel;
        private Label FieldsLeftCounterLabel;
    }
}