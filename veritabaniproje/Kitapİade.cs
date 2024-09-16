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

namespace veritabaniproje
{
    public partial class Kitapİade : Form
    {
        public Kitapİade()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-702LQK5\\SQLEXPRESS;Initial Catalog=libraryproject;Integrated Security=True;Encrypt=True;TrustServerCertificate=True;");
        DataSet daset = new DataSet();

        private void odunckitaplistele()
        {
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select *from odunckitap ", baglanti);
            adtr.Fill(daset, "odunckitap");
            gridkitapiade.DataSource = daset.Tables["odunckitap"];
            baglanti.Close();
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Kitapİade_Load(object sender, EventArgs e)
        {
            odunckitaplistele();

        }

        private void dataGridİade_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnİptalKitapİade_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tcara_TextChanged(object sender, EventArgs e)
        {
            daset.Tables["odunckitap"].Clear();
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select *from odunckitap where kullaniciID like'%" + txttcara.Text + "%'", baglanti);
            adtr.Fill(daset, "odunckitap");
            baglanti.Close();
            if (txttcara.Text == "")
            {
                daset.Tables["odunckitap"].Clear();
                odunckitaplistele();
            }
        }

        private void txtbarkodara_TextChanged(object sender, EventArgs e)
        {

            daset.Tables["odunckitap"].Clear();
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select *from odunckitap where kitapID like'%" + txtbarkodara.Text + "%'", baglanti);
            adtr.Fill(daset, "odunckitap");
            baglanti.Close();
            if (txtbarkodara.Text == "")
            {
                daset.Tables["odunckitap"].Clear();
                odunckitaplistele();
            }
        }

        private void btnTeslimAl_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("delete from odunckitap where kullaniciID=@kullaniciID and kitapID=@kitapID",baglanti);
            komut.Parameters.AddWithValue("@kullaniciID", gridkitapiade.CurrentRow.Cells["kullaniciID"].Value.ToString());
            komut.Parameters.AddWithValue("@kitapID", gridkitapiade.CurrentRow.Cells["kitapID"].Value.ToString());
            komut.ExecuteNonQuery();

            SqlCommand komut2 = new SqlCommand("update kitap set stokSayi=stokSayi+1 where kitapID=@kitapID",baglanti);
            komut2.Parameters.AddWithValue("@kitapID", gridkitapiade.CurrentRow.Cells["kitapID"].Value.ToString());
            komut2.ExecuteNonQuery();
            MessageBox.Show("kitaplar iade edildi");
            baglanti.Close();


            daset.Tables["odunckitap"].Clear();
            odunckitaplistele();
        }
    }
}
