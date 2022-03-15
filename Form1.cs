using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication30
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int cpuFiyat=0, toplamFiyat=0, ramFiyat=0, hddFiyat=0;
            

            if (radioButton1.Checked)
            {
                cpuFiyat = 7300;
            }

            else if (radioButton2.Checked)
            {
                cpuFiyat = 4300;
            }
            else if (radioButton3.Checked)
            {
                cpuFiyat = 1700;
            }
            else if (radioButton4.Checked)
            {
                cpuFiyat = 4550;
            }
            else if (radioButton5.Checked)
            {
                cpuFiyat = 2500;
            }

            toplamFiyat += cpuFiyat;

            if (radioButton6.Checked)
            {
                ramFiyat = 1500;
            }
            else if (radioButton7.Checked)
            {
                ramFiyat = 850;
            }
            else if (radioButton8.Checked)
            {
                ramFiyat = 300;
            }
            toplamFiyat += ramFiyat;

            if (radioButton9.Checked)
            {
                hddFiyat = 500;
            }
            else if (radioButton10.Checked)
            {
                hddFiyat = 350;
            }
            else if (radioButton11.Checked)
            {
                hddFiyat = 100;
            }

             toplamFiyat += hddFiyat;

            if (checkBox1.Checked)
            {
                toplamFiyat += 440;
            }
            if (checkBox2.Checked)
            {
                toplamFiyat += 260;
            }
            if (checkBox3.Checked)
            {
                toplamFiyat += 200;
            }

            MessageBox.Show("Toplam Fiyat = " + toplamFiyat.ToString());


        }
    }
}
