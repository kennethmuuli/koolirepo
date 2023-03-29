namespace AK_WindowsFormsApp1
{
    partial class KM_Form2
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
            this.km_list1 = new System.Windows.Forms.ListBox();
            this.km_txtBox1 = new System.Windows.Forms.TextBox();
            this.km_btnLisa = new System.Windows.Forms.Button();
            this.km_check1 = new System.Windows.Forms.CheckBox();
            this.km_Kustutada = new System.Windows.Forms.Button();
            this.km_rb1 = new System.Windows.Forms.RadioButton();
            this.km_rb2 = new System.Windows.Forms.RadioButton();
            this.km_rb3 = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // km_list1
            // 
            this.km_list1.FormattingEnabled = true;
            this.km_list1.ItemHeight = 23;
            this.km_list1.Location = new System.Drawing.Point(517, 43);
            this.km_list1.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.km_list1.Name = "km_list1";
            this.km_list1.Size = new System.Drawing.Size(255, 234);
            this.km_list1.TabIndex = 0;
            // 
            // km_txtBox1
            // 
            this.km_txtBox1.Location = new System.Drawing.Point(32, 43);
            this.km_txtBox1.Name = "km_txtBox1";
            this.km_txtBox1.Size = new System.Drawing.Size(228, 31);
            this.km_txtBox1.TabIndex = 1;
            // 
            // km_btnLisa
            // 
            this.km_btnLisa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.km_btnLisa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.km_btnLisa.Location = new System.Drawing.Point(318, 43);
            this.km_btnLisa.Name = "km_btnLisa";
            this.km_btnLisa.Size = new System.Drawing.Size(159, 31);
            this.km_btnLisa.TabIndex = 2;
            this.km_btnLisa.Text = "--->";
            this.km_btnLisa.UseVisualStyleBackColor = false;
            this.km_btnLisa.Click += new System.EventHandler(this.km_btnLisa_Click);
            // 
            // km_check1
            // 
            this.km_check1.AutoSize = true;
            this.km_check1.Location = new System.Drawing.Point(517, 295);
            this.km_check1.Name = "km_check1";
            this.km_check1.Size = new System.Drawing.Size(133, 27);
            this.km_check1.TabIndex = 3;
            this.km_check1.Text = "Unsorted";
            this.km_check1.UseVisualStyleBackColor = true;
            this.km_check1.CheckedChanged += new System.EventHandler(this.km_check1_CheckedChanged);
            // 
            // km_Kustutada
            // 
            this.km_Kustutada.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.km_Kustutada.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.km_Kustutada.Location = new System.Drawing.Point(318, 97);
            this.km_Kustutada.Name = "km_Kustutada";
            this.km_Kustutada.Size = new System.Drawing.Size(159, 31);
            this.km_Kustutada.TabIndex = 4;
            this.km_Kustutada.Text = "Delete";
            this.km_Kustutada.UseVisualStyleBackColor = false;
            this.km_Kustutada.Click += new System.EventHandler(this.km_Kustutada_Click);
            // 
            // km_rb1
            // 
            this.km_rb1.AutoSize = true;
            this.km_rb1.Checked = true;
            this.km_rb1.Location = new System.Drawing.Point(656, 295);
            this.km_rb1.Name = "km_rb1";
            this.km_rb1.Size = new System.Drawing.Size(67, 27);
            this.km_rb1.TabIndex = 5;
            this.km_rb1.TabStop = true;
            this.km_rb1.Text = "One";
            this.km_rb1.UseVisualStyleBackColor = true;
            this.km_rb1.CheckedChanged += new System.EventHandler(this.km_rb1_CheckedChanged);
            // 
            // km_rb2
            // 
            this.km_rb2.AutoSize = true;
            this.km_rb2.Location = new System.Drawing.Point(656, 328);
            this.km_rb2.Name = "km_rb2";
            this.km_rb2.Size = new System.Drawing.Size(93, 27);
            this.km_rb2.TabIndex = 6;
            this.km_rb2.Text = "Multi";
            this.km_rb2.UseVisualStyleBackColor = true;
            this.km_rb2.CheckedChanged += new System.EventHandler(this.km_rb2_CheckedChanged);
            // 
            // km_rb3
            // 
            this.km_rb3.AutoSize = true;
            this.km_rb3.Location = new System.Drawing.Point(656, 361);
            this.km_rb3.Name = "km_rb3";
            this.km_rb3.Size = new System.Drawing.Size(106, 27);
            this.km_rb3.TabIndex = 7;
            this.km_rb3.Text = "Extend";
            this.km_rb3.UseVisualStyleBackColor = true;
            this.km_rb3.CheckedChanged += new System.EventHandler(this.km_rb3_CheckedChanged);
            // 
            // KM_Form2
            // 
            this.AcceptButton = this.km_btnLisa;
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 508);
            this.Controls.Add(this.km_rb3);
            this.Controls.Add(this.km_rb2);
            this.Controls.Add(this.km_rb1);
            this.Controls.Add(this.km_Kustutada);
            this.Controls.Add(this.km_check1);
            this.Controls.Add(this.km_btnLisa);
            this.Controls.Add(this.km_txtBox1);
            this.Controls.Add(this.km_list1);
            this.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.Name = "KM_Form2";
            this.Text = "KM_Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox km_list1;
        private System.Windows.Forms.TextBox km_txtBox1;
        private System.Windows.Forms.Button km_btnLisa;
        private System.Windows.Forms.CheckBox km_check1;
        private System.Windows.Forms.Button km_Kustutada;
        private System.Windows.Forms.RadioButton km_rb1;
        private System.Windows.Forms.RadioButton km_rb2;
        private System.Windows.Forms.RadioButton km_rb3;
    }
}