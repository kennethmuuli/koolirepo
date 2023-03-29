using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AK_WindowsFormsApp1
{
    public partial class AK_Form1 : Form
    {
        public AK_Form1()
        {
            InitializeComponent();
        }

        private void AK_textBox1_TextChanged(object sender, EventArgs e)
        {
            string t = AK_textBox1.Text;
            string tt;
            if (AK_checkBox2.Checked == false)
                tt = t;
            else
            {
                tt = "";
                for (int i = 0; i < t.Length; i++)
                {
                    char c = t[i];
                    tt = c + tt;
                }
            }

            if (AK_checkBox1.Checked)
                AK_label1.Text = tt.ToUpper();
            else
                AK_label1.Text = tt.ToLower();
        }

        private void AK_checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (AK_checkBox1.Checked)
                AK_checkBox1.Text = "Suured tähed";
            else
                AK_checkBox1.Text = "Väiksed tähed";
            AK_textBox1_TextChanged(null, null);
        }

        private void AK_checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (AK_checkBox2.Checked)
                AK_checkBox2.Text = "<---";
            else
                AK_checkBox2.Text = "--->";
            AK_textBox1_TextChanged(null, null);
        }
    }
}
