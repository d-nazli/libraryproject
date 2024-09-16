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
    public partial class KitapKayit : Form
    {
        public KitapKayit()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-702LQK5\\SQLEXPRESS;Initial Catalog=libraryproject;Integrated Security=True;Encrypt=True;TrustServerCertificate=True;");
        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnEkleKitapKayıt_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            
                SqlCommand komut = new SqlCommand("INSERT INTO kitap (kitapID,ISBN, kitapAdi, yazarID, sayfaSayi, stokSayi, kategori, yayineviID) VALUES (@kitapID,@ISBN,@kitapAdi,@yazarID,@sayfaSayi,@stokSayi,@kategori,@yayineviID)", baglanti);
                komut.Parameters.AddWithValue("@kitapID", txtKitapBarkod.Text);
                komut.Parameters.AddWithValue("@ISBN", txtISBN.Text);
                komut.Parameters.AddWithValue("@kitapAdi", txtKitapAdi.Text);
                komut.Parameters.AddWithValue("@yazarID", txtYazarID.Text);
                komut.Parameters.AddWithValue("@sayfaSayi", txtSayfaSayi.Text);
                komut.Parameters.AddWithValue("@stokSayi", txtStokSayi.Text);
                komut.Parameters.AddWithValue("@kategori", txtKategori.Text);
                komut.Parameters.AddWithValue("@yayineviID", txtYayineviID.Text);

                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Kitap Kaydı Yapıldı");
          

            foreach (Control item in this.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }

        }

        private void KitapKayit_Load(object sender, EventArgs e)
        {

        }

        private void btnİptalKayit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
