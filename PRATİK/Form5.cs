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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string gelen_username = txtGelenDeger1.Text;
            string gelen_password = txtGelenDeger2.Text;
            
            // Kullanıcı dışarıdna kullanıcı adı ve şifresini girecek.
            // 1) Kullanıcı kullanıcı adını yanlış girerse, "kullanıcı adınız yanlış, şifrenizi kontrol etmedim"
            // 2) Kullanıcı kullanıcı adını doğru girerse, şifresini kontrol ediniz.
            // 3) Kullanıcı şifresini yanlış girerse, "kullanıcı adınız doğru, fakat şifreniz yanlış"
            // 4) Kullanıcı şifresini doğru girerse, "Tebrikler, hayata dair büyük bir başarı"
            const string ahmet = "ahmet";

            switch (gelen_username)
            {
                case ahmet:
                    switch (gelen_password)
                    {
                        case "123":
                            MessageBox.Show("Tebrikler, hayata dair büyük bir başarı");
                            break;
                        default:
                            MessageBox.Show("kullanıcı adınız doğru, fakat şifreniz yanlış");
                            break;
                    }
                    break;
                default:
                    MessageBox.Show("kullanıcı adınız yanlış, şifrenizi kontrol etmedim");
                    break;
            }

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            // dışarıdan admin,ceo, moderator girilirse, yönetim paneli
            // user, girilirse, kullanıcı paneli
            // default bir değer girilirse, yetki hatası mesajı verdiriniz.

            string username = txtGelenDeger1.Text;

            switch (username)
            {
                case "admin":
                case "ceo":
                case "moderatör":
                    MessageBox.Show("Yönetim Paneli");
                    break;
                case "user":
                    MessageBox.Show("Kullanıcı Paneli");
                    break;
                default:
                    MessageBox.Show("Yetki Hatası");
                    break;
            }
        }
    }
}
