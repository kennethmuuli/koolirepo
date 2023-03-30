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
            this.RestartButton = new System.Windows.Forms.Button();
            this.GameOverMessage = new System.Windows.Forms.RichTextBox();
            this.GameArea.SuspendLayout();
            this.SuspendLayout();
            // 
            // GameArea
            // 
            this.GameArea.Controls.Add(this.RestartButton);
            this.GameArea.Controls.Add(this.GameOverMessage);
            this.GameArea.Location = new System.Drawing.Point(125, 23);
            this.GameArea.Name = "GameArea";
            this.GameArea.Size = new System.Drawing.Size(500, 500);
            this.GameArea.TabIndex = 0;
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
            // GameOverMessage
            // 
            this.GameOverMessage.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.GameOverMessage.Location = new System.Drawing.Point(175, 170);
            this.GameOverMessage.Name = "GameOverMessage";
            this.GameOverMessage.Size = new System.Drawing.Size(156, 49);
            this.GameOverMessage.TabIndex = 0;
            this.GameOverMessage.Text = "Game over!";
            this.GameOverMessage.Visible = false;
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
            this.ResumeLayout(false);

        }

        #endregion

        private Panel GameArea;
        private Button RestartButton;
        private RichTextBox GameOverMessage;
    }
}