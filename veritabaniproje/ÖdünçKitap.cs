using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace veritabaniproje
{
    public partial class odunckitap : Form
    {
        public odunckitap()
        {
            InitializeComponent();
            txtTC.TextChanged += new EventHandler(txtTC_TextChanged);
            txtbarkod.TextChanged += new EventHandler(txtbarkod_TextChanged);
            btnTeslimEtÖdünç.Click += new System.EventHandler(btnTeslimEtÖdünç_Click);
            btnSil.Click += new EventHandler(btnSil_Click);
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-702LQK5\\SQLEXPRESS;Initial Catalog=libraryproject;Integrated Security=True;Encrypt=True;TrustServerCertificate=True;");
        DataSet daset = new DataSet();
        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void gboxÜyeBilgileri_Enter(object sender, EventArgs e)
        {

        }




        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();

            SqlCommand komut = new SqlCommand("INSERT INTO sepet(kitapID,kitapAdi,yazarID,sayfaSayi,teslimtarihi,iadetarihi) VALUES(@kitapID,@kitapAdi,@yazarID,@sayfaSayi,@teslimtarihi,@iadetarihi)", baglanti);
            komut.Parameters.AddWithValue("@kitapID", txtbarkod.Text);
            komut.Parameters.AddWithValue("@kitapAdi", txtkitapadi.Text);
            komut.Parameters.AddWithValue("@yazarID", txtyazarID.Text);
            komut.Parameters.AddWithValue("@sayfaSayi", txtsayfasayi.Text);
            komut.Parameters.AddWithValue("@teslimtarihi", dateTimePicker1.Text);
            komut.Parameters.AddWithValue("@iadetarihi", dateTimePicker2.Text);
            komut.ExecuteNonQuery();

            baglanti.Close();

            MessageBox.Show("Kitaplar sepete eklendi", "ekleme işlemi");
            daset.Tables["sepet"].Clear();
            sepetlistele();
            foreach (Control item in gboxKitapBilgileri.Controls)
            {
                if (item is System.Windows.Forms.TextBox)
                {
                    item.Text = "";
                }
            }
        }

        private void ÖdünçKitap_Load(object sender, EventArgs e)
        {
            gridsepet.DataSource = null;
            txtbarkod.TextChanged += new EventHandler(txtbarkod_TextChanged);
            sepetlistele();

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtTC_TextChanged(object sender, EventArgs e)
        {

            if (txtTC.Text.Length == 9)
            {
                string tcKimlik = txtTC.Text;
                string query = "SELECT isim, soyisim, Telefon FROM Kullanici WHERE kullaniciID = @TC";

                using (SqlConnection connection = new SqlConnection("Data Source=DESKTOP-702LQK5\\SQLEXPRESS;Initial Catalog=libraryproject;Integrated Security=True;Encrypt=True;TrustServerCertificate=True;"))
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@TC", tcKimlik);

                    try
                    {
                        connection.Open();
                        SqlDataReader reader = command.ExecuteReader();

                        if (reader.Read())
                        {  //değerleri textboxa atadım
                            txtAd.Text = reader["isim"].ToString();
                            txtSoyad.Text = reader["soyisim"].ToString();
                            txtTel.Text = reader["Telefon"].ToString();
                        }
                        else
                        {

                            txtAd.Text = "";
                            txtSoyad.Text = "";
                            txtTel.Text = "";
                            MessageBox.Show("Kullanıcı bulunamadı.");
                        }

                        reader.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Bir hata oluştu: " + ex.Message);
                    }
                    finally
                    {
                        connection.Close();
                    }
                }
            }
            else
            {

                txtAd.Text = "";
                txtSoyad.Text = "";
                txtTel.Text = "";
            }
        }


        private void btnİptalÖdünç_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void sepetlistele()
        {
            baglanti.Open();
            if (daset.Tables.Contains("sepet"))
            {
                daset.Tables["sepet"].Clear();
            }
            SqlDataAdapter adtr = new SqlDataAdapter("select * from sepet", baglanti);
            adtr.Fill(daset, "sepet");
            gridsepet.DataSource = daset.Tables["sepet"];
            baglanti.Close();
        }


        private void txtbarkod_TextChanged(object sender, EventArgs e)
        {

            if (txtbarkod.Text.Length == 0)
            {

                txtkitapadi.Text = "";
                txtyazarID.Text = "";
                txtsayfasayi.Text = "";
                return;
            }


            int minimumBarkodUzunlugu = 4;

            if (txtbarkod.Text.Length < minimumBarkodUzunlugu)
            {

                return;
            }


            string barkod = txtbarkod.Text;
            string query = "SELECT kitapAdi, yazarID, yayineviID, sayfaSayi FROM kitap WHERE kitapID = @kitapID";

            using (SqlConnection connection = new SqlConnection("Data Source=DESKTOP-702LQK5\\SQLEXPRESS;Initial Catalog=libraryproject;Integrated Security=True;Encrypt=True;TrustServerCertificate=True;"))
            {
                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@kitapID", barkod);

                try
                {

                    connection.Open();

                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {

                        txtkitapadi.Text = reader["kitapAdi"].ToString();
                        txtyazarID.Text = reader["yazarID"].ToString();
                        txtsayfasayi.Text = reader["sayfaSayi"].ToString();
                    }
                    else
                    {

                        txtkitapadi.Text = "";
                        txtyazarID.Text = "";
                        txtsayfasayi.Text = "";
                        MessageBox.Show("Kitap bulunamadı.");
                    }


                    reader.Close();
                }
                catch (Exception ex)
                {

                    MessageBox.Show("Bir hata oluştu: " + ex.Message);
                }
            }
        }




        private void btnSil_Click(object sender, EventArgs e)
        {

            if (gridsepet.CurrentRow == null || gridsepet.CurrentRow.Cells["kitapID"].Value == null)
            {
                MessageBox.Show("Lütfen silinecek bir kaydı seçin.", "Hata");
                return;
            }


            string kitapID = gridsepet.CurrentRow.Cells["kitapID"].Value.ToString();

            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete from sepet where kitapID = @kitapID", baglanti);
                komut.Parameters.AddWithValue("@kitapID", kitapID);
                komut.ExecuteNonQuery();
                baglanti.Close();

                MessageBox.Show("Silme işlemi yapıldı", "Silme İşlemi");


                if (daset.Tables.Contains("sepet"))
                {
                    daset.Tables["sepet"].Clear();
                }
                sepetlistele();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata oluştu: " + ex.Message, "Hata");
                if (baglanti.State == System.Data.ConnectionState.Open)
                {
                    baglanti.Close();
                }
            }
        }



        private void btnTeslimEtÖdünç_Click(object sender, EventArgs e)
        {

            for (int i = 0; i < gridsepet.Rows.Count - 1; i++)
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("insert into odunckitap(kullaniciID,isim,soyisim,yazarID,sayfaSayi,Telefon,kitapID,kitapAdi,teslimtarihi,iadetarihi) values(@kullaniciID,@isim,@soyisim,@yazarID,@sayfaSayi,@Telefon,@kitapID,@kitapAdi,@teslimtarihi,@iadetarihi)", baglanti);
                komut.Parameters.AddWithValue("@kullaniciID", txtTC.Text);
                komut.Parameters.AddWithValue("@isim", txtAd.Text);
                komut.Parameters.AddWithValue("@soyisim", txtSoyad.Text);
                komut.Parameters.AddWithValue("@Telefon", txtTel.Text);
                komut.Parameters.AddWithValue("kitapID", gridsepet.Rows[i].Cells["kitapID"].Value.ToString());
                komut.Parameters.AddWithValue("kitapAdi", gridsepet.Rows[i].Cells["kitapAdi"].Value.ToString());
                komut.Parameters.AddWithValue("teslimtarihi", gridsepet.Rows[i].Cells["teslimtarihi"].Value.ToString());
                komut.Parameters.AddWithValue("iadetarihi", gridsepet.Rows[i].Cells["iadetarihi"].Value.ToString());
                komut.Parameters.AddWithValue("yazarID", gridsepet.Rows[i].Cells["yazarID"].Value.ToString());
                komut.Parameters.AddWithValue("sayfaSayi", gridsepet.Rows[i].Cells["sayfaSayi"].Value.ToString());
                komut.ExecuteNonQuery();

                SqlCommand komut2 = new SqlCommand("update kitap set stokSayi=stokSayi-1 where kitapID='" + gridsepet.Rows[i].Cells["kitapID"].Value.ToString() + "'", baglanti); ;
                komut2.ExecuteNonQuery();
                baglanti.Close();
            }
            baglanti.Open();
            SqlCommand komut3 = new SqlCommand("delete from sepet", baglanti);
             komut3.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("kitaplar teslim edildi");
            daset.Tables["sepet"].Clear();
            sepetlistele();
            txtTC.Text = "";
            txtbarkod.Text = "";


        }

        private void label8_Click_1(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}