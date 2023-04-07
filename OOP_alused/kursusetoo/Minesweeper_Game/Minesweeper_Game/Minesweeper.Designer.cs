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
            this.GameArea.SuspendLayout();
            this.SuspendLayout();
            // 
            // GameArea
            // 
            this.GameArea.Controls.Add(this.GameOverLabel);
            this.GameArea.Controls.Add(this.RestartButton);
            this.GameArea.Location = new System.Drawing.Point(125, 23);
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
            // Minesweeper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 549);
            this.Controls.Add(this.GameArea);
            this.Name = "Minesweeper";
            this.Text = "Form1";
            this.GameArea.ResumeLayout(false);
            this.GameArea.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel GameArea;
        private Button RestartButton;
        private Label GameOverLabel;
    }
}