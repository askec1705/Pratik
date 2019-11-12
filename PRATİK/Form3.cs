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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            //Girilen not 0 - 30 araligi ise "FF" 30 - 50 araligi "DD" 50 - 70 "BB" 70 - 100 "AA" aldınız seklinde kullaniciyi uyariniz..

            double not = double.Parse(textBox1.Text);
            string mesaj = " Aldınız.";

            
            if (not >= 0 && not <= 30)
            {
                MessageBox.Show("FF" + mesaj);
            }
            else if (not > 30 && not <= 50)
            {
                MessageBox.Show("DD" + mesaj);
            }
            else if (not > 50 && not <= 70)
            {
                MessageBox.Show("BB" + mesaj);
            }
            else if (not > 70 && not <= 100)
            {
                MessageBox.Show("AA" + mesaj);
            }
            else
            {
                MessageBox.Show("Lütfen belirlenen aralıkta bir değer giriniz.");
            }
            
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            //Disaridan urun adi girilecek, kasiyer bize urunun hangi reyonda oldugunu soyleyecek...
            //Domates, Biber, Patlican => Sebze Reyonu
            //Diş Macunu, Parfüm, Şampuan => Kozmetik Reyonu
            //Cep Telefonu, Bilgisayar, Ses Sistemi => Teknoloji Reyonu
            //Başka bir ürün girilirse "Bu ürün bizde yok!" uyarisi verilsin!

            string urunadi = textBox1.Text.ToLower();
            string mesaj = "";

            if (urunadi == "domates" || urunadi == "biber" || urunadi == "patlıcan")
            {
                mesaj += "Sebze Reyonu";
            }
            else if (urunadi == "diş macunu" || urunadi == "parfüm" || urunadi == "şampuan")
            {
                mesaj += "Kozmetik Reyonu";
            }
            else if (urunadi == "cep telefonu" || urunadi == "bilgisayar" || urunadi == "ses sistemi")
            {
                mesaj += "Teknoloji Reyonu";
            }
            else
            {
                mesaj += "Bu ürün bizde yok!";
            }
            MessageBox.Show(mesaj);
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            //Disaridan siparis alinacak olan kitap miktari girilsin. Sipari sayisi 20'den azsa toplam ucretten %5, 20 - 50 araliginda ise %10, 50-100 araligi ise %15, 100'den fazla ise %25 indirim yapilsin. Kitabın birim fiyatı => 5 TLdir... Amac => Odenecek tutari kullaniciya gostermek...

            // Toplam sipariş adediniz : 100
            // Birim fiyatı            : 5 TL
            // Toplam tutar            : 500 TL
            // Yapılan indirim oranı   : %25
            // Ödemeniz gereken tutar  : 375 TL

            int gelen_siparis_sayisi;
            bool result = int.TryParse(textBox1.Text, out gelen_siparis_sayisi);
            byte birim_fiyat = 5;
            double odenecek_tutar = 0;
            string indirim_orani = "";
            if (result && gelen_siparis_sayisi > 0)
            {
                if (gelen_siparis_sayisi <= 20)
                {
                    odenecek_tutar = (birim_fiyat * gelen_siparis_sayisi) * 0.95;
                    indirim_orani = "%5";
                }
                else if (gelen_siparis_sayisi <= 50)
                {
                    odenecek_tutar = (birim_fiyat * gelen_siparis_sayisi) * 0.90;
                    indirim_orani = "%10";
                }
                else if (gelen_siparis_sayisi <= 100)
                {
                    odenecek_tutar = (birim_fiyat * gelen_siparis_sayisi) * 0.85;
                    indirim_orani = "%15";
                }
                else
                {
                    odenecek_tutar = (birim_fiyat * gelen_siparis_sayisi) * 0.75;
                    indirim_orani = "%25";
                }

                MessageBox.Show(string.Format(
                     @"Toplam sipariş adediniz    : {0}   
Birim fiyatı                          : {1} 
Toplam tutar                      : {2} TL 
Yapılan indirim oranı         : {3} 
Ödemeniz gereken tutar  : {4}",
                     gelen_siparis_sayisi,
                     birim_fiyat,
                     (birim_fiyat * gelen_siparis_sayisi),
                     indirim_orani,
                     odenecek_tutar
                     ));
            }
            else
            {
                MessageBox.Show("Lütfen sayısal ve geçerli bir sipariş sayısı giriniz!");
                MessageBox.Show("Sayıları bilmiyorsanız ailenizden destek isteyiniz!");
            }


        }
    }
}
