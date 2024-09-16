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
    public partial class StokKontrolfrm : Form
    {
        public StokKontrolfrm()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-702LQK5\\SQLEXPRESS;Initial Catalog=libraryproject;Integrated Security=True;Encrypt=True;TrustServerCertificate=True;");
        DataSet daset = new DataSet();
        private void kitaplistele()
        {
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select *from kitap ", baglanti);
            adtr.Fill(daset, "kitap");
            dataGridStok.DataSource = daset.Tables["kitap"];
            baglanti.Close();
        }

        private void StokKontrolfrm_Load(object sender, EventArgs e)
        {
            kitaplistele();
        }

        private void txtBarkodaGöreAra_TextChanged(object sender, EventArgs e)
        {
            try
            {
                daset.Tables["kitap"].Clear();
                baglanti.Open();
                SqlDataAdapter adtr = new SqlDataAdapter("SELECT * FROM kitap WHERE kitapID LIKE @kitapID", baglanti);
                adtr.SelectCommand.Parameters.AddWithValue("@kitapID", "%" + txtBarkodaGöreAra.Text + "%");
                adtr.Fill(daset, "kitap");
                dataGridStok.DataSource = daset.Tables["kitap"];
            }
            finally
            {
                baglanti.Close();
            }
        }



    }
}

