
namespace AK_WindowsFormsApp1
{
    partial class AK_Form1
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
            this.AK_Frame1 = new System.Windows.Forms.GroupBox();
            this.AK_checkBox2 = new System.Windows.Forms.CheckBox();
            this.AK_checkBox1 = new System.Windows.Forms.CheckBox();
            this.AK_label1 = new System.Windows.Forms.Label();
            this.AK_textBox1 = new System.Windows.Forms.TextBox();
            this.AK_Frame1.SuspendLayout();
            this.SuspendLayout();
            // 
            // AK_Frame1
            // 
            this.AK_Frame1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.AK_Frame1.Controls.Add(this.AK_checkBox2);
            this.AK_Frame1.Controls.Add(this.AK_checkBox1);
            this.AK_Frame1.Controls.Add(this.AK_label1);
            this.AK_Frame1.Controls.Add(this.AK_textBox1);
            this.AK_Frame1.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AK_Frame1.Location = new System.Drawing.Point(12, 12);
            this.AK_Frame1.Name = "AK_Frame1";
            this.AK_Frame1.Size = new System.Drawing.Size(770, 213);
            this.AK_Frame1.TabIndex = 1;
            this.AK_Frame1.TabStop = false;
            // 
            // AK_checkBox2
            // 
            this.AK_checkBox2.AutoSize = true;
            this.AK_checkBox2.Location = new System.Drawing.Point(417, 64);
            this.AK_checkBox2.Name = "AK_checkBox2";
            this.AK_checkBox2.Size = new System.Drawing.Size(67, 22);
            this.AK_checkBox2.TabIndex = 3;
            this.AK_checkBox2.Text = "--->";
            this.AK_checkBox2.UseVisualStyleBackColor = true;
            this.AK_checkBox2.CheckedChanged += new System.EventHandler(this.AK_checkBox2_CheckedChanged);
            // 
            // AK_checkBox1
            // 
            this.AK_checkBox1.AutoSize = true;
            this.AK_checkBox1.Checked = true;
            this.AK_checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.AK_checkBox1.Location = new System.Drawing.Point(35, 63);
            this.AK_checkBox1.Name = "AK_checkBox1";
            this.AK_checkBox1.Size = new System.Drawing.Size(147, 22);
            this.AK_checkBox1.TabIndex = 2;
            this.AK_checkBox1.Text = "Suured tähed";
            this.AK_checkBox1.UseVisualStyleBackColor = true;
            this.AK_checkBox1.CheckedChanged += new System.EventHandler(this.AK_checkBox1_CheckedChanged);
            // 
            // AK_label1
            // 
            this.AK_label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.AK_label1.Location = new System.Drawing.Point(32, 99);
            this.AK_label1.Name = "AK_label1";
            this.AK_label1.Size = new System.Drawing.Size(695, 33);
            this.AK_label1.TabIndex = 1;
            // 
            // AK_textBox1
            // 
            this.AK_textBox1.Location = new System.Drawing.Point(35, 22);
            this.AK_textBox1.Name = "AK_textBox1";
            this.AK_textBox1.Size = new System.Drawing.Size(696, 26);
            this.AK_textBox1.TabIndex = 0;
            this.AK_textBox1.TextChanged += new System.EventHandler(this.AK_textBox1_TextChanged);
            // 
            // AK_Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 258);
            this.Controls.Add(this.AK_Frame1);
            this.Name = "AK_Form1";
            this.Text = "AK_Form1";
            this.AK_Frame1.ResumeLayout(false);
            this.AK_Frame1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox AK_Frame1;
        private System.Windows.Forms.Label AK_label1;
        private System.Windows.Forms.TextBox AK_textBox1;
        private System.Windows.Forms.CheckBox AK_checkBox1;
        private System.Windows.Forms.CheckBox AK_checkBox2;
    }
}