using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pizzacı
{
    public partial class Form1 : Form
    {

        int fiyat = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                fiyat += 100;
            }
            else
            {
                fiyat -= 100;
            }
            label18.Text = fiyat.ToString()+"TL";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                fiyat += 120;
            }
            else
            {
                fiyat -= 120;
            }
            label18.Text = fiyat.ToString() + "TL";
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton4.Checked)
            {
                fiyat += 150;
            }
            else
            {
                fiyat -= 150;
            }
            label18.Text = fiyat.ToString() + "TL";
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked)
            {
                fiyat += 110;
            }
            else
            {
                fiyat -= 110;
            }
            label18.Text = fiyat.ToString() + "TL";
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton5.Checked)
            {
                fiyat += 5;
            }
            else
            {
                fiyat -= 5;
            }
            label18.Text = fiyat.ToString() + "TL";
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton7.Checked)
            {
                fiyat += 10;
            }
            else
            {
                fiyat -= 10;
            }
            label18.Text = fiyat.ToString() + "TL";
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton6.Checked)
            {
                fiyat += 15;
            }
            else
            {
                fiyat -= 15;
            }
            label18.Text = fiyat.ToString() + "TL";
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                fiyat += 5;
            }
            else
            {
                fiyat -= 5;
            }
            label18.Text = fiyat.ToString() + "TL";
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                fiyat += 5;
            }
            else
            {
                fiyat -= 5;
            }
            label18.Text = fiyat.ToString() + "TL";
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked)
            {
                fiyat += 5;
            }
            else
            {
                fiyat -= 5;
            }
            label18.Text = fiyat.ToString() + "TL";
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                fiyat += 5;
            }
            else
            {
                fiyat -= 5;
            }
            label18.Text = fiyat.ToString() + "TL";
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox5.Checked)
            {
                fiyat += 5;
            }
            else
            {
                fiyat -= 5;
            }
            label18.Text = fiyat.ToString() + "TL";
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox6.Checked)
            {
                fiyat += 5;
            }
            else
            {
                fiyat -= 5;
            }
            label18.Text = fiyat.ToString() + "TL";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ad = textBox1.Text;
            string soyad = textBox3.Text;
            string telefon = maskedTextBox1.Text;
            string adresAdi = textBox2.Text;
            string acikAdres = richTextBox1.Text;

            if(ad!="" && soyad!="" && telefon!="" && adresAdi!="" && acikAdres != "")
            {
                MessageBox.Show("Siparişiniz alındı.");
                textBox1.Text = "";
                textBox3.Text = "";
                maskedTextBox1.Text = "";
                textBox2.Text = "";
                richTextBox1.Text = "";
                label18.Text = "";
                radioButton8.Checked = true;
                radioButton1.Checked = true;
                checkBox1.Checked = false;
                checkBox2.Checked = false;
                checkBox3.Checked = false;
                checkBox4.Checked = false;
                checkBox5.Checked = false;
                checkBox6.Checked = false;
            }
            else
            {
                MessageBox.Show("Boş alan bırakmayın!");
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            radioButton8.Checked = true;
        }
    }
}
