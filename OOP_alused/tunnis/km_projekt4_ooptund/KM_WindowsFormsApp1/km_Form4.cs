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
    public partial class km_Form4 : Form
    {
        int kx = 8, ky = 8;
        Button[] km_btnArr;


        public km_Form4()
        {
            InitializeComponent();
            km_btnArr = new Button[kx * ky];
            Massiiv();
        }

        public void Massiiv()
        {
            int dx = km_panel.Width / kx;
            int dy = km_panel.Height / ky;
            for (int i = 0; i < km_btnArr.Length; i++)
            {
                km_btnArr[i] = new Button();
                km_panel.Controls.Add(km_btnArr[i]);
                km_btnArr[i].Width = dx;
                km_btnArr[i].Height = dy;
                int rida = i / kx;
                int veerg = i % kx;
                km_btnArr[i].Left = veerg * dx;
                km_btnArr[i].Top = rida * dy;
                km_btnArr[i].Text = i.ToString();
                km_btnArr[i].ForeColor = Color.Red;
                km_btnArr[i].BackColor = Color.LightBlue;
                km_btnArr[i].Click += new EventHandler(km_btnArr_Click);
            }
            km_btnArr[0].Text = "";
            km_btnArr[0].BackColor = Color.White;
        }

        private void km_btnArr_Click(object sender, EventArgs e)
        {
            int n = Array.IndexOf(km_btnArr, (Button)sender);

            km_btnArr[n].BackColor = Color.Black;
        }
    }
}
