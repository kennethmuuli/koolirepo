
namespace AK_WindowsFormsApp1
{
    partial class km_Form4
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
            this.km_panel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // km_panel
            // 
            this.km_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.km_panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.km_panel.Location = new System.Drawing.Point(46, 36);
            this.km_panel.Name = "km_panel";
            this.km_panel.Size = new System.Drawing.Size(479, 441);
            this.km_panel.TabIndex = 0;
            // 
            // km_Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(881, 539);
            this.Controls.Add(this.km_panel);
            this.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "km_Form4";
            this.Text = "km_Form4";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel km_panel;
    }
}