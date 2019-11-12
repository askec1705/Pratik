using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRATİK
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void BtnOrnek1_Click(object sender, EventArgs e)
        {
            if (txtDeger.Text == "admin")
            {
                MessageBox.Show("Tebrikler giriş yaptınız");
            } // true
            else
            {
                MessageBox.Show("Ne kadar zor olabilir ?");
            } // false
        }

        private void BtnOrnek2_Click(object sender, EventArgs e)
        {
            //Eger girilen not 0'dan kucukse "0'dan küçük bir not girişi yapamazsınız" 100'den buyukse "100'den büyük bir not girişi yapamazsınız" mesajini gostersin...

            double not = double.Parse(txtDeger.Text);

            if (not < 0)
            {
                MessageBox.Show("0'dan küçük bir not girişi yapamazsınız");
            }
            else if (not > 100)
            {
                MessageBox.Show("100'den büyük bir not girişi yapamazsınız");
            }
            else
            {
                MessageBox.Show("Notunuz : " + not);
            }
        }

        private void BtnOrnek3_Click(object sender, EventArgs e)
        {
            //txtGirisAlani'ndan girilen sayi cift ise "Sayı Çifttir" tek ise "Sayı Tektir" mesajini kullaniciya gosteriniz...

            int sayi = int.Parse(txtDeger.Text);

            if (sayi % 2 == 0)
            {
                MessageBox.Show("Sayı Çifttir");
            }
            else
            {
                MessageBox.Show("Sayı Tektir");
            }
        }

        private void BtnOrnek4_Click(object sender, EventArgs e)
        {
            //Disaridan girilen kelimenin uzunlugu 8 karaktere esit ya da buyukse kayit onaylandi, degilse daha uzun bir sifre giriniz...

            string password = txtDeger.Text;

            if (password.Length >= 8)
            {
                MessageBox.Show("Kayıt Onaylandı.");
            }
            else
            {
                MessageBox.Show("Daha Uzun Bir Şifre Giriniz.");
            }
        }
    }
}
