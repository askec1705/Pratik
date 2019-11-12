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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        Random rnd = new Random();
        private void Form4_Load(object sender, EventArgs e)
        {
            //Formun ilk acilis aninda 8 haneli rastgele bir sayı lblRastgeleKarakterler adli label'a yazdirilacak ve kullanicidan butona bastigi anda textbox'taki yazıyla label'daki yazının karsilastirmasi yapilacak. Eger karsilastirma olumsuz ise lblKalanHakkimiz'deki deger bir azaltılacak. 
            //Eger kullanici 5 defa hatali giris yaparsa button'un aktiflik ozelligi kapatilacak...
            //Her hatali giriste yeni bir rastgele sayi turetilmelidir...

            lblRastgeleKarakterler.Text = rnd.Next(10000000, 100000000).ToString();
        }

        private void BtnGirisYap_Click(object sender, EventArgs e)
        {
            if (lblRastgeleKarakterler.Text == txtMetinGirisAlani.Text)
            {
                MessageBox.Show("Tebrikler giriş yaptınız");
                txtMetinGirisAlani.Text = "";
                lblRastgeleKarakterler.Text = "* * *";
                btnGirisYap.Enabled = false;
                txtMetinGirisAlani.Enabled = false;
                lblKalanHak.Text = "5";
            }
            else
            {
                lblRastgeleKarakterler.Text = rnd.Next(10000000, 100000000).ToString();
                txtMetinGirisAlani.Clear();
                txtMetinGirisAlani.Focus();
                lblKalanHak.Text = (int.Parse(lblKalanHak.Text) - 1).ToString();
                if (lblKalanHak.Text == "0")
                {
                    txtMetinGirisAlani.Text = null;
                    lblRastgeleKarakterler.Text = "* * *";
                    btnGirisYap.Enabled = false;
                    txtMetinGirisAlani.Enabled = false;
                    lblKalanHak.Text = "5";
                }
            } 
        }
    }
}
