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
            this.Menu = new System.Windows.Forms.Panel();
            this.StartButton = new System.Windows.Forms.Button();
            this.LivesCounterLabel = new System.Windows.Forms.Label();
            this.MediumButton = new System.Windows.Forms.Button();
            this.DifficultButton = new System.Windows.Forms.Button();
            this.DifficultyLabel = new System.Windows.Forms.Label();
            this.EasyButton = new System.Windows.Forms.Button();
            this.BombsCounterLabel = new System.Windows.Forms.Label();
            this.BombsCounter = new System.Windows.Forms.Label();
            this.LivesCounter = new System.Windows.Forms.Label();
            this.GameArea.SuspendLayout();
            this.Menu.SuspendLayout();
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
            this.RestartButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.RestartButton.FlatAppearance.BorderSize = 2;
            this.RestartButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.RestartButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RestartButton.Location = new System.Drawing.Point(217, 250);
            this.RestartButton.Name = "RestartButton";
            this.RestartButton.Size = new System.Drawing.Size(75, 33);
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
            this.FieldsLeftLabel.Location = new System.Drawing.Point(52, 22);
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
            this.FieldsLeftCounterLabel.Location = new System.Drawing.Point(78, 71);
            this.FieldsLeftCounterLabel.Name = "FieldsLeftCounterLabel";
            this.FieldsLeftCounterLabel.Size = new System.Drawing.Size(56, 32);
            this.FieldsLeftCounterLabel.TabIndex = 4;
            this.FieldsLeftCounterLabel.Text = "###";
            this.FieldsLeftCounterLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Menu
            // 
            this.Menu.Controls.Add(this.StartButton);
            this.Menu.Controls.Add(this.MediumButton);
            this.Menu.Controls.Add(this.DifficultButton);
            this.Menu.Controls.Add(this.DifficultyLabel);
            this.Menu.Controls.Add(this.EasyButton);
            this.Menu.Location = new System.Drawing.Point(12, 12);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(707, 525);
            this.Menu.TabIndex = 50;
            // 
            // StartButton
            // 
            this.StartButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.StartButton.FlatAppearance.BorderSize = 2;
            this.StartButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.StartButton.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.StartButton.Location = new System.Drawing.Point(284, 347);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(146, 51);
            this.StartButton.TabIndex = 7;
            this.StartButton.Text = "START";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // LivesCounterLabel
            // 
            this.LivesCounterLabel.AutoSize = true;
            this.LivesCounterLabel.BackColor = System.Drawing.Color.Transparent;
            this.LivesCounterLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LivesCounterLabel.ForeColor = System.Drawing.Color.Black;
            this.LivesCounterLabel.Location = new System.Drawing.Point(49, 225);
            this.LivesCounterLabel.Name = "LivesCounterLabel";
            this.LivesCounterLabel.Size = new System.Drawing.Size(110, 32);
            this.LivesCounterLabel.TabIndex = 10;
            this.LivesCounterLabel.Text = "Lives left";
            this.LivesCounterLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LivesCounterLabel.Visible = false;
            // 
            // MediumButton
            // 
            this.MediumButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.MediumButton.FlatAppearance.BorderSize = 2;
            this.MediumButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.MediumButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MediumButton.Location = new System.Drawing.Point(308, 213);
            this.MediumButton.Name = "MediumButton";
            this.MediumButton.Size = new System.Drawing.Size(90, 33);
            this.MediumButton.TabIndex = 6;
            this.MediumButton.Text = "Medium";
            this.MediumButton.UseVisualStyleBackColor = true;
            this.MediumButton.Click += new System.EventHandler(this.MediumButton_Click);
            // 
            // DifficultButton
            // 
            this.DifficultButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.DifficultButton.FlatAppearance.BorderSize = 2;
            this.DifficultButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DifficultButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DifficultButton.Location = new System.Drawing.Point(404, 213);
            this.DifficultButton.Name = "DifficultButton";
            this.DifficultButton.Size = new System.Drawing.Size(90, 33);
            this.DifficultButton.TabIndex = 5;
            this.DifficultButton.Text = "Difficult";
            this.DifficultButton.UseVisualStyleBackColor = true;
            this.DifficultButton.Click += new System.EventHandler(this.DifficultButton_Click);
            // 
            // DifficultyLabel
            // 
            this.DifficultyLabel.AutoSize = true;
            this.DifficultyLabel.BackColor = System.Drawing.Color.Transparent;
            this.DifficultyLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DifficultyLabel.ForeColor = System.Drawing.Color.Black;
            this.DifficultyLabel.Location = new System.Drawing.Point(259, 154);
            this.DifficultyLabel.Name = "DifficultyLabel";
            this.DifficultyLabel.Size = new System.Drawing.Size(195, 32);
            this.DifficultyLabel.TabIndex = 4;
            this.DifficultyLabel.Text = "Choose difficulty";
            this.DifficultyLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EasyButton
            // 
            this.EasyButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.EasyButton.FlatAppearance.BorderSize = 2;
            this.EasyButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.EasyButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EasyButton.Location = new System.Drawing.Point(214, 213);
            this.EasyButton.Name = "EasyButton";
            this.EasyButton.Size = new System.Drawing.Size(90, 33);
            this.EasyButton.TabIndex = 3;
            this.EasyButton.Text = "Easy";
            this.EasyButton.UseVisualStyleBackColor = true;
            this.EasyButton.Click += new System.EventHandler(this.EasyButton_Click);
            // 
            // BombsCounterLabel
            // 
            this.BombsCounterLabel.AutoSize = true;
            this.BombsCounterLabel.BackColor = System.Drawing.Color.Transparent;
            this.BombsCounterLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BombsCounterLabel.ForeColor = System.Drawing.Color.Black;
            this.BombsCounterLabel.Location = new System.Drawing.Point(12, 130);
            this.BombsCounterLabel.Name = "BombsCounterLabel";
            this.BombsCounterLabel.Size = new System.Drawing.Size(183, 32);
            this.BombsCounterLabel.TabIndex = 9;
            this.BombsCounterLabel.Text = "Bombs in game";
            this.BombsCounterLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BombsCounter
            // 
            this.BombsCounter.AutoSize = true;
            this.BombsCounter.BackColor = System.Drawing.Color.Transparent;
            this.BombsCounter.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BombsCounter.ForeColor = System.Drawing.Color.Black;
            this.BombsCounter.Location = new System.Drawing.Point(78, 177);
            this.BombsCounter.Name = "BombsCounter";
            this.BombsCounter.Size = new System.Drawing.Size(56, 32);
            this.BombsCounter.TabIndex = 10;
            this.BombsCounter.Text = "###";
            this.BombsCounter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LivesCounter
            // 
            this.LivesCounter.AutoSize = true;
            this.LivesCounter.BackColor = System.Drawing.Color.Transparent;
            this.LivesCounter.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LivesCounter.ForeColor = System.Drawing.Color.Black;
            this.LivesCounter.Location = new System.Drawing.Point(78, 269);
            this.LivesCounter.Name = "LivesCounter";
            this.LivesCounter.Size = new System.Drawing.Size(56, 32);
            this.LivesCounter.TabIndex = 11;
            this.LivesCounter.Text = "###";
            this.LivesCounter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LivesCounter.Visible = false;
            // 
            // Minesweeper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 549);
            this.Controls.Add(this.LivesCounter);
            this.Controls.Add(this.Menu);
            this.Controls.Add(this.LivesCounterLabel);
            this.Controls.Add(this.BombsCounter);
            this.Controls.Add(this.BombsCounterLabel);
            this.Controls.Add(this.FieldsLeftCounterLabel);
            this.Controls.Add(this.FieldsLeftLabel);
            this.Controls.Add(this.GameArea);
            this.Name = "Minesweeper";
            this.Text = "Form1";
            this.GameArea.ResumeLayout(false);
            this.GameArea.PerformLayout();
            this.Menu.ResumeLayout(false);
            this.Menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel GameArea;
        private Label GameOverLabel;
        private Button RestartButton;
        private Label FieldsLeftLabel;
        private Label FieldsLeftCounterLabel;
        private Panel Menu;
        private Button StartButton;
        private Button MediumButton;
        private Button DifficultButton;
        private Label DifficultyLabel;
        private Button EasyButton;
        private Label BombsCounterLabel;
        private Label BombsCounter;
        private Label LivesCounter;
        private Label LivesCounterLabel;
    }
}