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
    public partial class KM_Form2 : Form
    {

        public List<string> unsortedList;

        public KM_Form2()
        {
            InitializeComponent();
        }

        


        private void km_btnLisa_Click(object sender, EventArgs e)
        {
            string t = km_txtBox1.Text;
            int valitud = km_list1.SelectedIndex;

            if(valitud == -1)
            {
                km_list1.Items.Add(t);
                km_list1.SelectedIndex = -1;
            }
            else
            {
                km_list1.Items.Insert(valitud, t);
            }

            
            km_txtBox1.Text = null; // km_txtBox1.Clear(); OR km_txtBox1.Text = ""
            km_txtBox1.Focus();

        }

        private void km_check1_CheckedChanged(object sender, EventArgs e)
        {

            if (km_check1.Checked == true)
            {

                km_list1.Sorted = true;
                km_check1.Text = "Sorted";
            }
            else
            {
                km_list1.Sorted=false;
                km_check1.Text = "Unsorted";
            }
        }

        private void km_Kustutada_Click(object sender, EventArgs e)
        {
            if(km_rb1.Checked == true)
            {

                int valitud = km_list1.SelectedIndex;

                if (valitud == -1)
                {
                    MessageBox.Show("Valik puudub.");
                    return;
                }
                else
                {
                    string t = "Kas oled kindel, et soovid kustudada rida:" + (char)13 + km_list1.Items[valitud];
                    DialogResult vastus = MessageBox.Show(t, "Hoiatus!", MessageBoxButtons.YesNo);

                    if (vastus == DialogResult.Yes)
                    {
                        km_list1.Items.RemoveAt(valitud);

                    }
                    else
                    {
                        km_list1.SelectedIndex = -1;
                    }
                }
            }
            else
            {
                int ridu = km_list1.Items.Count;

                if (ridu == 0)
                {
                    return;
                }
                string tekst = "Kas oled kindel, et soovid kustudada rida:" + (char)13;

                for (int i = 0; i < km_list1.Items.Count; i++)
                    {
                        if(km_list1.GetSelected(i))
                        {
                            tekst = tekst + (char)13 + km_list1.Items[i];
                        }
                    }

                DialogResult vastus = MessageBox.Show(tekst, "Hoiatus!", MessageBoxButtons.YesNo);

                if (vastus == DialogResult.Yes)
                {
                    for (int i = km_list1.Items.Count-1; i >= 0; i--)
                    {
                        if (km_list1.GetSelected(i))
                        {
                            km_list1.Items.RemoveAt(i);
                        }
                    }
                }
                else
                {
                    km_list1.SelectedIndex = -1;
                }

            }
        }

        private void km_rb1_CheckedChanged(object sender, EventArgs e)
        {
            if (km_rb1.Checked == true)
            {
                km_list1.SelectionMode = SelectionMode.One;
            }
        }

        private void km_rb2_CheckedChanged(object sender, EventArgs e)
        {
            if (km_rb2.Checked == true)
            {
                km_list1.SelectionMode = SelectionMode.MultiSimple;
            }
        }

        private void km_rb3_CheckedChanged(object sender, EventArgs e)
        {
            if (km_rb3.Checked == true)
            {
                km_list1.SelectionMode = SelectionMode.MultiExtended;
            }
        }
    }
}
