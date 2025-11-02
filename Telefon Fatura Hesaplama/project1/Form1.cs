using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ad_soyad;
            float dakka_ucret,gb_ucret,ögrenci;
            float result = 50;

            ad_soyad = textBox1.Text;
            dakka_ucret = int.Parse(textBox2.Text);
            gb_ucret = int.Parse(textBox3.Text);

            string secim = comboBox1.SelectedItem.ToString();

            if (secim == "Bireysel")
            {
                result += (float)(dakka_ucret * 0.5);
                result += (float)(gb_ucret * 15);

                if (radioButton1.Checked)
                {
                    result -= (result * 20) / 100;

                    
                }
                if (result >= 500)
                {
                    result -= (result * 10) / 100;
                }

                
                
            }

            if (secim == "Kurumsal")
            {
                result += (float)(dakka_ucret * 0.3);
                result += (float)(gb_ucret * 15);

                if (radioButton1.Checked)
                {
                    result -= (result * 20) / 100;

                    if (result == 500)
                    {
                        result -= (result * 10) / 100;
                    }
                }

                if (radioButton2.Checked)
                {
                    if (result == 500)
                    {
                        result -= (result * 10) / 100;
                    }
                }
            }
            
            MessageBox.Show($"Müşter: {ad_soyad}\n" +
                            $"Paket: {secim}\n" +
                            $"Dakka Ücreti: {dakka_ucret}\n" +
                            $"İnternet Ücreti: {gb_ucret}\n" +
                            $"Abonelik: 50 TL\n" +
                            $"Toplam Fatura: {result}");

        }


    }
}
