
namespace AK_WindowsFormsApp1
{
    partial class km_Form3
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
            this.km_Frame1 = new System.Windows.Forms.GroupBox();
            this.km_btnZoom = new System.Windows.Forms.RadioButton();
            this.km_btnCenter = new System.Windows.Forms.RadioButton();
            this.km_btnAutoSize = new System.Windows.Forms.RadioButton();
            this.km_btnStretch = new System.Windows.Forms.RadioButton();
            this.km_btnNormal = new System.Windows.Forms.RadioButton();
            this.km_pic1 = new System.Windows.Forms.PictureBox();
            this.km_menu = new System.Windows.Forms.MenuStrip();
            this.km_file = new System.Windows.Forms.ToolStripMenuItem();
            this.km_open = new System.Windows.Forms.ToolStripMenuItem();
            this.km_save = new System.Windows.Forms.ToolStripMenuItem();
            this.km_closefile = new System.Windows.Forms.ToolStripMenuItem();
            this.km_openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.km_saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.km_pic2 = new System.Windows.Forms.PictureBox();
            this.km_Frame1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.km_pic1)).BeginInit();
            this.km_menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.km_pic2)).BeginInit();
            this.SuspendLayout();
            // 
            // km_Frame1
            // 
            this.km_Frame1.BackColor = System.Drawing.Color.Cornsilk;
            this.km_Frame1.Controls.Add(this.km_pic2);
            this.km_Frame1.Controls.Add(this.km_btnZoom);
            this.km_Frame1.Controls.Add(this.km_btnCenter);
            this.km_Frame1.Controls.Add(this.km_btnAutoSize);
            this.km_Frame1.Controls.Add(this.km_btnStretch);
            this.km_Frame1.Controls.Add(this.km_btnNormal);
            this.km_Frame1.Controls.Add(this.km_pic1);
            this.km_Frame1.Location = new System.Drawing.Point(12, 56);
            this.km_Frame1.Name = "km_Frame1";
            this.km_Frame1.Size = new System.Drawing.Size(1309, 486);
            this.km_Frame1.TabIndex = 0;
            this.km_Frame1.TabStop = false;
            this.km_Frame1.Text = "Pildid";
            // 
            // km_btnZoom
            // 
            this.km_btnZoom.AutoSize = true;
            this.km_btnZoom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.km_btnZoom.Location = new System.Drawing.Point(48, 209);
            this.km_btnZoom.Name = "km_btnZoom";
            this.km_btnZoom.Size = new System.Drawing.Size(66, 22);
            this.km_btnZoom.TabIndex = 5;
            this.km_btnZoom.Text = "Zoom";
            this.km_btnZoom.UseVisualStyleBackColor = true;
            this.km_btnZoom.CheckedChanged += new System.EventHandler(this.km_btnZoom_CheckedChanged);
            // 
            // km_btnCenter
            // 
            this.km_btnCenter.AutoSize = true;
            this.km_btnCenter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.km_btnCenter.Location = new System.Drawing.Point(48, 172);
            this.km_btnCenter.Name = "km_btnCenter";
            this.km_btnCenter.Size = new System.Drawing.Size(136, 22);
            this.km_btnCenter.TabIndex = 4;
            this.km_btnCenter.Text = "CenterImage";
            this.km_btnCenter.UseVisualStyleBackColor = true;
            this.km_btnCenter.CheckedChanged += new System.EventHandler(this.km_btnCenter_CheckedChanged);
            // 
            // km_btnAutoSize
            // 
            this.km_btnAutoSize.AutoSize = true;
            this.km_btnAutoSize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.km_btnAutoSize.Location = new System.Drawing.Point(48, 133);
            this.km_btnAutoSize.Name = "km_btnAutoSize";
            this.km_btnAutoSize.Size = new System.Drawing.Size(116, 22);
            this.km_btnAutoSize.TabIndex = 3;
            this.km_btnAutoSize.Text = "Auto Size";
            this.km_btnAutoSize.UseVisualStyleBackColor = true;
            this.km_btnAutoSize.CheckedChanged += new System.EventHandler(this.km_btnAutoSize_CheckedChanged);
            // 
            // km_btnStretch
            // 
            this.km_btnStretch.AutoSize = true;
            this.km_btnStretch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.km_btnStretch.Location = new System.Drawing.Point(48, 93);
            this.km_btnStretch.Name = "km_btnStretch";
            this.km_btnStretch.Size = new System.Drawing.Size(96, 22);
            this.km_btnStretch.TabIndex = 2;
            this.km_btnStretch.Text = "Stretch";
            this.km_btnStretch.UseVisualStyleBackColor = true;
            this.km_btnStretch.CheckedChanged += new System.EventHandler(this.km_btnStretch_CheckedChanged);
            // 
            // km_btnNormal
            // 
            this.km_btnNormal.AutoSize = true;
            this.km_btnNormal.Checked = true;
            this.km_btnNormal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.km_btnNormal.Location = new System.Drawing.Point(48, 56);
            this.km_btnNormal.Name = "km_btnNormal";
            this.km_btnNormal.Size = new System.Drawing.Size(86, 22);
            this.km_btnNormal.TabIndex = 1;
            this.km_btnNormal.TabStop = true;
            this.km_btnNormal.Text = "Normal";
            this.km_btnNormal.UseVisualStyleBackColor = true;
            this.km_btnNormal.CheckedChanged += new System.EventHandler(this.km_btnNormal_CheckedChanged);
            // 
            // km_pic1
            // 
            this.km_pic1.BackColor = System.Drawing.Color.White;
            this.km_pic1.Location = new System.Drawing.Point(227, 56);
            this.km_pic1.Name = "km_pic1";
            this.km_pic1.Size = new System.Drawing.Size(410, 380);
            this.km_pic1.TabIndex = 0;
            this.km_pic1.TabStop = false;
            this.km_pic1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.km_pic1_MouseDown);
            this.km_pic1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.km_pic1_MouseMove);
            // 
            // km_menu
            // 
            this.km_menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.km_file});
            this.km_menu.Location = new System.Drawing.Point(0, 0);
            this.km_menu.Name = "km_menu";
            this.km_menu.Size = new System.Drawing.Size(1333, 29);
            this.km_menu.TabIndex = 1;
            this.km_menu.Text = "km_menuStrip1";
            // 
            // km_file
            // 
            this.km_file.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.km_open,
            this.km_save,
            this.km_closefile});
            this.km_file.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.km_file.ForeColor = System.Drawing.Color.Red;
            this.km_file.Name = "km_file";
            this.km_file.Size = new System.Drawing.Size(49, 25);
            this.km_file.Text = "File";
            // 
            // km_open
            // 
            this.km_open.ForeColor = System.Drawing.Color.Red;
            this.km_open.Name = "km_open";
            this.km_open.Size = new System.Drawing.Size(152, 26);
            this.km_open.Text = "Open";
            this.km_open.Click += new System.EventHandler(this.km_open_Click);
            // 
            // km_save
            // 
            this.km_save.Enabled = false;
            this.km_save.ForeColor = System.Drawing.Color.Red;
            this.km_save.Name = "km_save";
            this.km_save.Size = new System.Drawing.Size(180, 26);
            this.km_save.Text = "Save As";
            this.km_save.Click += new System.EventHandler(this.km_save_Click);
            // 
            // km_closefile
            // 
            this.km_closefile.Enabled = false;
            this.km_closefile.ForeColor = System.Drawing.Color.Red;
            this.km_closefile.Name = "km_closefile";
            this.km_closefile.Size = new System.Drawing.Size(152, 26);
            this.km_closefile.Text = "Close File";
            this.km_closefile.Click += new System.EventHandler(this.km_closefile_Click);
            // 
            // km_openFileDialog
            // 
            this.km_openFileDialog.FileName = "openFileDialog1";
            // 
            // km_pic2
            // 
            this.km_pic2.BackColor = System.Drawing.Color.White;
            this.km_pic2.Location = new System.Drawing.Point(691, 56);
            this.km_pic2.Name = "km_pic2";
            this.km_pic2.Size = new System.Drawing.Size(410, 380);
            this.km_pic2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.km_pic2.TabIndex = 6;
            this.km_pic2.TabStop = false;
            // 
            // km_Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1333, 623);
            this.Controls.Add(this.km_Frame1);
            this.Controls.Add(this.km_menu);
            this.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "km_Form3";
            this.Text = "km_Form3";
            this.km_Frame1.ResumeLayout(false);
            this.km_Frame1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.km_pic1)).EndInit();
            this.km_menu.ResumeLayout(false);
            this.km_menu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.km_pic2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox km_Frame1;
        private System.Windows.Forms.PictureBox km_pic1;
        private System.Windows.Forms.MenuStrip km_menu;
        private System.Windows.Forms.ToolStripMenuItem km_file;
        private System.Windows.Forms.ToolStripMenuItem km_open;
        private System.Windows.Forms.ToolStripMenuItem km_save;
        private System.Windows.Forms.OpenFileDialog km_openFileDialog;
        private System.Windows.Forms.SaveFileDialog km_saveFileDialog;
        private System.Windows.Forms.RadioButton km_btnZoom;
        private System.Windows.Forms.RadioButton km_btnCenter;
        private System.Windows.Forms.RadioButton km_btnAutoSize;
        private System.Windows.Forms.RadioButton km_btnStretch;
        private System.Windows.Forms.RadioButton km_btnNormal;
        private System.Windows.Forms.ToolStripMenuItem km_closefile;
        private System.Windows.Forms.PictureBox km_pic2;
    }
}