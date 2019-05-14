using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sinema_Bufe_Satis_Uygulamasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        int kasaTutar = 0;
        private void button1_Click(object sender, EventArgs e)
        {



            int misir, bilet, cay,su, toplam;
            misir =Convert.ToInt16(numericUpDown1.Text);
            cay = Convert.ToInt16(numericUpDown2.Text);
            su = Convert.ToInt16(numericUpDown3.Text);
            bilet =Convert.ToInt16(numericUpDown4.Text);
            
            

       


            toplam = misir * 5 + bilet * 8 + su * 1 + cay * 2;
            lblToplam.Text = toplam.ToString() + " TL";

            kasaTutar = kasaTutar + toplam;
            lblKasa.Text = kasaTutar.ToString() + " TL";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            numericUpDown1.Text="";
            numericUpDown2.Text="";
            numericUpDown3.Text="";
            numericUpDown4.Text="";
            numericUpDown1.Focus();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
           

        }

        private void txtMisir_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMisir_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void txtCay_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void txtSu_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void txtBilet_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }
    }
}
