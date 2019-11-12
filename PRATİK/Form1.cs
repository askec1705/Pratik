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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnOrnek1_Click(object sender, EventArgs e)
        {
            int telefonNumarasi = Convert.ToInt32(textBox1.Text);
            MessageBox.Show("Tebrikler telefon numarasını düzgün girdiniz");
        }

        private void BtnOrnek2_Click(object sender, EventArgs e)
        {
            try
            {
                int telefonNumarasi = Convert.ToInt32(textBox1.Text);
                MessageBox.Show("Tebrikler telefon numarasını düzgün girdiniz");
            }
            catch
            {
                MessageBox.Show("Geçerli bir telefon numarası giriniz!");
            }
        }

        private void BtnOrnek3_Click(object sender, EventArgs e)
        {
            try
            {
                int telefonNumarasi = Convert.ToInt32(textBox1.Text);
                MessageBox.Show("Tebrikler telefon numarasını düzgün girdiniz");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Geçerli bir telefon numarası giriniz!");
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnOrnek4_Click(object sender, EventArgs e)
        {
            try
            {
                int telefonNumarasi = Convert.ToInt32(textBox1.Text);
                MessageBox.Show("Tebrikler telefon numarasını düzgün girdiniz");
            }
            catch (DivideByZeroException ex) // sıfıra bölünme hatası
            {
                MessageBox.Show("Geçerli bir telefon numarası giriniz!");
                MessageBox.Show(ex.Message);
            }
            catch (FormatException ex) // geçersiz format 
            {
                MessageBox.Show("Geçerli bir telefon numarası giriniz!");
                MessageBox.Show(ex.Message);
            }
            catch (IndexOutOfRangeException ex) //aşırı yüklenme hatası
            {
                MessageBox.Show("Geçerli bir telefon numarası giriniz!");
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex) // genel hatalar
            {
                MessageBox.Show("Geçerli bir telefon numarası giriniz!");
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnOrnek5_Click(object sender, EventArgs e)
        {
            try
            {
                int telefonNumarasi = Convert.ToInt32(textBox1.Text);
                MessageBox.Show("Tebrikler telefon numarasını düzgün girdiniz");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Geçerli bir telefon numarası giriniz!");
                MessageBox.Show(ex.Message);
            }
            finally
            {
                MessageBox.Show("Her durumda çalışırım bölümü");
            }
        }
    }
}
