using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace veritabaniproje
{
    public partial class uyekayit : Form
    {
        public uyekayit()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-702LQK5\\SQLEXPRESS;Initial Catalog=libraryproject;Integrated Security=True;Encrypt=True;TrustServerCertificate=True;");
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void uyekayit_Load(object sender, EventArgs e)
        {

        }

        private void btnuyekayit_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            try
            {
                SqlCommand komut = new SqlCommand("INSERT INTO Kullanici (kullaniciID, isim, soyisim, [E-posta], Telefon, Adres, uyeliktarihi) VALUES (@kullaniciID, @isim, @soyisim, @eposta, @Telefon, @Adres, @uyeliktarihi)", baglanti);
                komut.Parameters.AddWithValue("@kullaniciID", txtTC.Text);
                komut.Parameters.AddWithValue("@isim", txtAD.Text);
                komut.Parameters.AddWithValue("@soyisim", txtSoyad.Text);
                komut.Parameters.AddWithValue("@eposta", txtEposta.Text); 
                komut.Parameters.AddWithValue("@Telefon", txtTel.Text);
                komut.Parameters.AddWithValue("@Adres", txtAdres.Text);

                DateTime uyelikTarihi;
                if (DateTime.TryParse(cbtxtuyeliktarihi.Text, out uyelikTarihi))//datetime türüne donusturdum
                {
                    komut.Parameters.AddWithValue("@uyeliktarihi", uyelikTarihi);
                }
                else
                {
                    MessageBox.Show("Geçersiz tarih formatı.");
                    return;
                }

                komut.ExecuteNonQuery();
                MessageBox.Show("Üye Kaydı Yapıldı");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata oluştu: " + ex.Message);
            }
            finally
            {
                baglanti.Close();
            }

            foreach (Control item in this.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }


        }

        private void btniptaluyekayit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
