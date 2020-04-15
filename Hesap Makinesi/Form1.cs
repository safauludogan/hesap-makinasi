using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Hesap_Makinesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        long[] dizi = new long[1];
        int kucult;
        byte bolum, carpim, cikarma, toplama;
        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text=textBox1.Text.Substring(0, textBox1.Text.Length - 1);
            kucult = textBox1.Text.Length;
            if (kucult < 15)
            {
                textBox1.Font = new Font("", 18, FontStyle.Bold);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            textBox1.Enabled = false;
            sifir.Start();
        }

        private void sifir_Tick(object sender, EventArgs e)
        {
            if (textBox1.Text=="")
            {
                textBox1.Text = "0";
                textBox1.Font = new Font("", 18, FontStyle.Bold);
            }           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bolum = 0;
            carpim = 0;
            cikarma = 0;
            toplama = 0;
            textBox1.Clear();
        }
        void islemler()
        {
            
            if (textBox1.Text == "0")
            {
                textBox1.Clear();

            }
            for (int i = 0; i < textBox1.Text.Length; i++)
            {
                if (textBox1.Text.Substring(i, 1) == "/" || textBox1.Text.Substring(i, 1) == "*" || textBox1.Text.Substring(i, 1) == "+" || textBox1.Text.Substring(i, 1) == "-")
                {
                     textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
                     dizi[0] = Convert.ToInt64(textBox1.Text);                 
                     textBox1.Clear();
                }
            }
            kucult = textBox1.Text.Length;
            if (kucult >= 14)
            {
                textBox1.Font = new Font("", 12, FontStyle.Bold);
            }
        }
        private void bir_Click(object sender, EventArgs e)
        {
            islemler();
            if (kucult < 16)
            {
                textBox1.Text += "1";
            }
        }
        private void iki_Click(object sender, EventArgs e)
        {
            islemler();
            if (kucult < 16)
            {
                textBox1.Text += "2";
            }
        }

        private void uc_Click(object sender, EventArgs e)
        {
            islemler();
            if (kucult < 16)
            {
                textBox1.Text += "3";
            }
        }

        private void dort_Click(object sender, EventArgs e)
        {
            islemler();
            if (kucult < 16)
            {
                textBox1.Text += "4";
            }
        }

        private void bes_Click(object sender, EventArgs e)
        {
            islemler();
            if (kucult < 16)
            {
                textBox1.Text += "5";
            }
        }

        private void alti_Click(object sender, EventArgs e)
        {
            islemler();
            if (kucult < 16)
            {
                textBox1.Text += "6";
            }
        }

        private void yedi_Click(object sender, EventArgs e)
        {
           
            islemler();
            if (kucult < 16)
            {
                textBox1.Text += "7";
            }
        }

        private void sekiz_Click(object sender, EventArgs e)
        {
            islemler();
            if (kucult < 16)
            {
                textBox1.Text += "8";
            }
        }

        private void dokuz_Click(object sender, EventArgs e)
        {
            islemler();
            if (kucult < 16)
            {
                textBox1.Text += "9";
            }
        }

        private void sifirTusu_Click(object sender, EventArgs e)
        {
            islemler();
            if (kucult < 16)
            {
                textBox1.Text += "0";
            }
        }
        long boll;
        private void bol_Click(object sender, EventArgs e)
        {
            bolum = 1;
            carpim = 0;
            cikarma = 0;
            toplama = 0;
            if (textBox1.Text == "0")
            {
                textBox1.Clear();
            }
            kucult = textBox1.Text.Length;
            if (kucult >= 14)
            {
                textBox1.Font = new Font("", 12, FontStyle.Bold);
            }
            if (kucult < 17)
            {
                for (int i = 0; i < textBox1.Text.Length; i++)
                {
                    try
                    {
                        if (textBox1.Text.Substring(i, 1) == "*" || textBox1.Text.Substring(i, 1) == "+" || textBox1.Text.Substring(i, 1) == "-")
                        {
                            textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
                        }
                        if (textBox1.Text.Substring(i, 1) != "/")
                        {
                            boll = 1;
                        }
                        else
                        {
                            boll = 0;
                        }
                    }
                    catch
                    { }
                }
                if (boll == 1) 
                {
                    textBox1.Text += "/";        
                }
            }
        }
        long carpp;
        private void carp_Click(object sender, EventArgs e)
        {
            bolum = 0;
            carpim = 1;
            cikarma = 0;
            toplama = 0;
            if (textBox1.Text == "0")
            {
                textBox1.Clear();
            }
            kucult = textBox1.Text.Length;
            if (kucult >= 14)
            {
                textBox1.Font = new Font("", 12, FontStyle.Bold);
            }
            if (kucult < 18)
            {
                for (int i = 0; i < textBox1.Text.Length; i++)
                {
                    try
                    {
                        if (textBox1.Text.Substring(i, 1) == "/" || textBox1.Text.Substring(i, 1) == "+" || textBox1.Text.Substring(i, 1) == "-")
                        {
                            textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
                        }
                        if (textBox1.Text.Substring(i, 1) != "*")
                        {
                            carpp = 1;
                        }
                        else
                        {
                            carpp = 0;
                        }
                    }
                    catch
                    { }
                }
                if (carpp == 1)
                {
                    textBox1.Text += "*";
                }
            }
        }
        long cikarr;
        private void cikar_Click(object sender, EventArgs e)
        {
            bolum = 0;
            carpim = 0;
            cikarma = 1;
            toplama = 0;
            if (textBox1.Text == "0")
            {
                textBox1.Clear();
            }
            kucult = textBox1.Text.Length;
            if (kucult >= 14)
            {
                textBox1.Font = new Font("", 12, FontStyle.Bold);
            }
            if (kucult < 18)
            {
                for (int i = 0; i < textBox1.Text.Length; i++)
                {
                    try
                    {
                        if (textBox1.Text.Substring(i, 1) == "*" || textBox1.Text.Substring(i, 1) == "+" || textBox1.Text.Substring(i, 1) == "/")
                        {
                            textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
                        }
                        if (textBox1.Text.Substring(i, 1) != "-")
                        {
                            cikarr = 1;
                        }
                        else
                        {
                            cikarr = 0;
                        }
                    }
                    catch
                    { }
                }
                if (cikarr == 1)
                {
                    textBox1.Text += "-";
                }
            }
        }
        long toplaa;
        private void topla_Click(object sender, EventArgs e)
        {
            bolum = 0;
            carpim = 0;
            cikarma = 0;
            toplama = 1;
            if (textBox1.Text == "0")
            {
                textBox1.Clear();
            }
            kucult = textBox1.Text.Length;
            if (kucult >= 14)
            {
                textBox1.Font = new Font("", 12, FontStyle.Bold);
            }
            if (kucult < 18)
            {
                for (int i = 0; i < textBox1.Text.Length; i++)
                {
                    try
                    {
                        if (textBox1.Text.Substring(i, 1) == "*" || textBox1.Text.Substring(i, 1) == "/" || textBox1.Text.Substring(i, 1) == "-")
                        {
                            textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
                        }
                        if (textBox1.Text.Substring(i, 1) != "+")
                        {
                            toplaa = 1;
                        }
                        else
                        {
                            toplaa = 0;
                        }
                    }
                    catch
                    { }
                }
                if (toplaa == 1)
                {
                    textBox1.Text += "+";
                }
            }
        }
        int sonuc;
        private void esittir_Click(object sender, EventArgs e)
        {
            try
            {
                sonuc = Convert.ToInt32(textBox1.Text);
          
            if (bolum == 1) 
            {
                textBox1.Text = (dizi[0] / sonuc).ToString();
            }
            if (carpim == 1)
            {
                textBox1.Text = (dizi[0] * sonuc).ToString();
            }
            if (cikarma == 1)
            {
                textBox1.Text = (dizi[0] - sonuc).ToString();
            }
            if (toplama == 1)
            {
                textBox1.Text = (dizi[0] + sonuc).ToString();
            }
            }
            catch { }
        }
    }
}
