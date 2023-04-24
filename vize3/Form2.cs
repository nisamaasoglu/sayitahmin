using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace vize3
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        int girilenSayi, tutulanSayi, sayac = 3;

        private void button1_Click(object sender, EventArgs e)

        {
            Random rastgele = new Random();
            tutulanSayi = rastgele.Next(0, 11);

            if (textBox1.Text == "")
            {
                textBox1.Text = "";
            }
            else
            {
                int girilenSayi = int.Parse(textBox1.Text);
                if (girilenSayi < 1 || girilenSayi > 10)
                {
                    label3.Text = "GİRİLEN SAYI 1 İLE 10 ARASINDA OLMALI!!!";
                    return;
                }
            }
            {
                if (girilenSayi < tutulanSayi)
                {
                    label2.Text = "↑";
                    sayac--;
                }
                else if (girilenSayi > tutulanSayi)
                {
                    label2.Text = "↓";
                    sayac--;
                }
                else if (girilenSayi == tutulanSayi)
                {
                    button1.Enabled = false;
                    label3.Text = "TEBRİKLER.\n KAZANDINIZ!!!";


                }
            }

            label1.Text = sayac.ToString();

            if (sayac == 0)
            {
                button1.Enabled = false;
                label3.Text = "OYUN BİTTİ.KAYBETTİN :(\n Sayı " + tutulanSayi;
            }
            else
            {
                button1.Enabled = true;
                label3.Text = "ÜZGÜNÜM :( \n TEKRAR DENE.";
            }


        }
        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void label1_Click(object sender, EventArgs e)
        {
            sayac = 2;
            label1.Text = sayac.ToString();
            label2.Text = "";
            textBox1.Text = "";

            button1.Enabled = true;
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            girilenSayi = Convert.ToInt32(textBox1.Text);
        }
    }
}




