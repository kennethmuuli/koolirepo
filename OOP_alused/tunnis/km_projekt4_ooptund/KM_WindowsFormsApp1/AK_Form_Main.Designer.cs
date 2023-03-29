
namespace AK_WindowsFormsApp1
{
    partial class AK_Form_Main
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
            this.AK_button1 = new System.Windows.Forms.Button();
            this.KM_btn2 = new System.Windows.Forms.Button();
            this.km_btn3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AK_button1
            // 
            this.AK_button1.Location = new System.Drawing.Point(62, 39);
            this.AK_button1.Name = "AK_button1";
            this.AK_button1.Size = new System.Drawing.Size(267, 57);
            this.AK_button1.TabIndex = 0;
            this.AK_button1.Text = "02.02.2023";
            this.AK_button1.UseVisualStyleBackColor = true;
            this.AK_button1.Click += new System.EventHandler(this.AK_button1_Click);
            // 
            // KM_btn2
            // 
            this.KM_btn2.Location = new System.Drawing.Point(62, 124);
            this.KM_btn2.Name = "KM_btn2";
            this.KM_btn2.Size = new System.Drawing.Size(267, 57);
            this.KM_btn2.TabIndex = 1;
            this.KM_btn2.Text = "16.02.2023";
            this.KM_btn2.UseVisualStyleBackColor = true;
            this.KM_btn2.Click += new System.EventHandler(this.KM_btn2_Click);
            // 
            // km_btn3
            // 
            this.km_btn3.Location = new System.Drawing.Point(62, 204);
            this.km_btn3.Name = "km_btn3";
            this.km_btn3.Size = new System.Drawing.Size(267, 57);
            this.km_btn3.TabIndex = 2;
            this.km_btn3.Text = "02.03.2023";
            this.km_btn3.UseVisualStyleBackColor = true;
            this.km_btn3.Click += new System.EventHandler(this.km_btn3_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(62, 287);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(267, 57);
            this.button1.TabIndex = 3;
            this.button1.Text = "16.03.2023";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AK_Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 427);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.km_btn3);
            this.Controls.Add(this.KM_btn2);
            this.Controls.Add(this.AK_button1);
            this.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "AK_Form_Main";
            this.Text = "KTA-22E";
            this.Load += new System.EventHandler(this.AK_Form_Main_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AK_button1;
        private System.Windows.Forms.Button KM_btn2;
        private System.Windows.Forms.Button km_btn3;
        private System.Windows.Forms.Button button1;
    }
}

