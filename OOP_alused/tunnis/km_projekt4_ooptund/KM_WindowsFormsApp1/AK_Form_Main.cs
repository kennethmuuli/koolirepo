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
    public partial class AK_Form_Main : Form
    {
        Form F1 = new AK_Form1();
        Form F2 = new KM_Form2();
        Form F3 = new km_Form3();
        Form F4 = new km_Form4();

        public AK_Form_Main()
        {
            InitializeComponent();
        }

        private void AK_Form_Main_Load(object sender, EventArgs e)
        {

        }

        private void AK_button1_Click(object sender, EventArgs e)
        {
            
            F1.Visible = true;
            F1.Activate();
            // Vormi saab avada ainult yhe korra
            AK_button1.Enabled = false; 

        }

        private void KM_btn2_Click(object sender, EventArgs e)
        {
            if (F2.Visible==false)
            {
                F2 = new KM_Form2();
                F2.Visible = true;
                //Vormi saab avada ja sulgeda mitu kord, kuid ainult sama vormi
                F2.Activate();
            }
        }

        private void km_btn3_Click(object sender, EventArgs e)
        {
            if (F3.Visible == false)
            {
                F3 = new km_Form3();
                F3.Visible = true;
                //Vormi saab avada ja sulgeda mitu kord, kuid ainult sama vormi
                F3.Activate();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (F4.Visible == false)
            {
                F4 = new km_Form4();
                F4.Visible = true;
                //Vormi saab avada ja sulgeda mitu kord, kuid ainult sama vormi
                F4.Activate();
            }
        }
    }
}
