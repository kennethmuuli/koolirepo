using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace AK_WindowsFormsApp1
{
    public partial class km_Form3 : Form
    {
        string failipath;
        string failinimi;
        int w, h;
        int x1, y1, x2, y2;
        Image pic = null;


        public km_Form3()
        {
            InitializeComponent();
            w = km_pic1.Width;
            h = km_pic1.Height;
        }

        private void km_open_Click(object sender, EventArgs e)
        {
            
            //Seame yles filtri
            // | eraldab kirjeldust ja filtrit
            string t = "JPG failid|*.jpg";
            t = t + "|PNG failid|*.png";
            t = t + "|JPG ja PNG failid|*.jpg;*.png";
            t = t + "|KÕIK failid|*.*";

            km_openFileDialog.Filter = t;

            //avame faili valiku brauseri ja tirime pildi frame sisse
            km_openFileDialog.FileName = "";
            km_openFileDialog.ShowDialog();

            //tunnis kasutasime failinime, tegelikult valesti - võtsime sellega välja faili pathi, eraldasin need, et saaks vormile näidata välja ainult failinime
            //faili path
            failipath = km_openFileDialog.FileName;
            //faili nimi pathist, vajab namespace "using System.IO"
            failinimi = Path.GetFileName(failipath);
            

            //kontroll, et failipath poleks tyhi, vastasel juhul faili valitud pole, s.t. faili brauseris vajutati "cancel" sisuliselt
            if (failipath == "")
            {
                return;
            }

            //kuvab framel (groupBoxil) failinime koos laiendiga
            km_Frame1.Text = failinimi;
            //pilid sissetrimiseks on vaja faili teekonda
            km_pic1.Image = Image.FromFile(failipath);
            pic = Image.FromFile(failipath);

            //PS! Vormil picture box, s.t. "km_pic1" sizemode muudetud, et pildi suurusega arvestada
            km_closefile.Enabled = true;
            km_save.Enabled = true;

        }

        private void km_btnNormal_CheckedChanged(object sender, EventArgs e)
        {
            if (km_btnNormal.Checked == true)
            {
                km_pic1.SizeMode = PictureBoxSizeMode.Normal;
                km_pic1.Width = w;
                km_pic1.Height = h;
            }
        }

        private void km_btnStretch_CheckedChanged(object sender, EventArgs e)
        {
            if (km_btnStretch.Checked == true)
            {
                km_pic1.SizeMode = PictureBoxSizeMode.StretchImage;
                km_pic1.Width = w;
                km_pic1.Height = h;
            }
        }

        private void km_btnAutoSize_CheckedChanged(object sender, EventArgs e)
        {
            if (km_btnAutoSize.Checked == true)
            {
                km_pic1.SizeMode = PictureBoxSizeMode.AutoSize;
            }
        }

       

        private void km_btnCenter_CheckedChanged(object sender, EventArgs e)
        {
            if (km_btnCenter.Checked == true)
            {
                km_pic1.SizeMode = PictureBoxSizeMode.CenterImage;
                km_pic1.Width = w;
                km_pic1.Height = h;
            }
        }

        private void km_btnZoom_CheckedChanged(object sender, EventArgs e)
        {
            if (km_btnZoom.Checked == true)
            {
                km_pic1.SizeMode = PictureBoxSizeMode.Zoom;
                km_pic1.Width = w;
                km_pic1.Height = h;
            }
        }

        private void km_closefile_Click(object sender, EventArgs e)
        {
            pic = null;
            km_pic1.Image = null;
            km_pic2.Image = null;
            failipath = "";
            failinimi = "";
            km_Frame1.Text = "";
            km_closefile.Enabled = false;
            km_save.Enabled = false;
            pic = null;
        }

        private void km_save_Click(object sender, EventArgs e)
        {
            km_saveFileDialog.Filter = "JPG failid|*.jpg";
            //avame faili valiku brauseri ja valime file pathi, anname failile nime ja salvestame
            km_saveFileDialog.FileName = "";
            km_saveFileDialog.ShowDialog();
            failinimi = km_saveFileDialog.FileName;

            // Kontrollid
            if (failinimi == "") return;
            if (km_pic2.Image == null) return;

            Bitmap b = new Bitmap(km_pic2.Image);
            b.Save(failinimi, System.Drawing.Imaging.ImageFormat.Jpeg);

        }

        private void km_pic1_MouseDown(object sender, MouseEventArgs e)
        {
            string t = e.Button.ToString();
            if (t != "Left") return;


            // IF kontrollib kas pilt olemas, et null ref errorit valtida
            if (pic != null)
            {
                Point pp = km_Koordinaadid(e.X, e.Y);
                x1 = pp.X;
                y1 = pp.Y;
            }
            else return;
            

        }

        private void km_pic1_MouseMove(object sender, MouseEventArgs e)
        {
            string t = e.Button.ToString();
            if (t != "Left") return;

            // IF kontrollib kas pilt olemas, et null ref errorit valtida
            if (pic != null)
            {
                Point pp = km_Koordinaadid(e.X, e.Y);
                x2 = pp.X;
                y2 = pp.Y;
            }
            else return;
            

            // kuva koordinaate picture box nimel
            //km_Frame1.Text = e.X.ToString() + " " + e.Y.ToString();

            km_Draw_Rectangle(Color.Red, 3);


        }

        private void km_Draw_Rectangle(Color c, int k)
        {
            //Joonistame kasti (kursori positsiooni alusel)
            Bitmap bm = new Bitmap(pic);
            Graphics gr = Graphics.FromImage(bm);
            Pen pencil = new Pen(c, k);
            int x0 = Math.Min(x1, x2);
            int y0 = Math.Min(y1, y2);
            int dx = Math.Abs(x1 - x2);
            int dy = Math.Abs(y1 - y2);
            gr.DrawRectangle(pencil, x0, y0, dx, dy);
            km_pic1.Image = bm;

            //Joonistame kasti sees olevast pildist uue pildi (valja loike)
            if(dx < 1 || dy < 1) return;
            Bitmap area = new Bitmap(dx, dy);
            Graphics area_gr = Graphics.FromImage(area);
            Rectangle in_rect = new Rectangle(x0, y0, dx, dy);
            Rectangle out_rect = new Rectangle(0, 0, dx, dy);
            area_gr.DrawImage(pic, out_rect, in_rect, GraphicsUnit.Pixel);
            km_pic2.Image = area;
        }

        private Point km_Koordinaadid(int x, int y)
        {
            Point p = new Point(0, 0);

            if(km_btnNormal.Checked || km_btnAutoSize.Checked)
            {
                p.X = x;
                p.Y = y;
            }
            if (km_btnStretch.Checked) 
            {
                float kx = (float)pic.Width / km_pic1.Width;
                float ky = (float)pic.Height / km_pic1.Height;

                p.X = (int)(x * kx);
                p.Y = (int)(y * ky);
            }
            if(km_btnCenter.Checked)
            {
                int dx = (km_pic1.Width - pic.Width) / 2;
                int dy = (km_pic1.Height - pic.Height) / 2;

                p.X = x - dx;
                p.Y = y - dy;
            }
            if (km_btnZoom.Checked)
            {
                float kx = (float)pic.Width / km_pic1.Width;
                float ky = (float)pic.Height / km_pic1.Height;
                int dx = 0, dy = 0;


                if (kx > ky)
                {
                    ky = kx;
                    dy = (int)(km_pic1.Height - pic.Height/ky) / 2;
                }
                else
                {
                    kx = ky;
                    dx = (int)(km_pic1.Width - pic.Width / kx) / 2;
                }

                p.X = (int)((x - dx) * kx);
                p.Y = (int)((y - dy)*ky);
            }

            if (p.X < 0) p.X = 0;
            if (p.X > pic.Width) p.X = pic.Width;
            if (p.Y < 0) p.Y = 0;
            if (p.Y > pic.Height) p.Y = pic.Height;
            return p;
        }
    }
}
