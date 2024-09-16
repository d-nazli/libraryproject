
using System.Data.SqlClient;


namespace veritabaniproje


{
    public partial class Anasayfa : Form
    {
        public Anasayfa()
        {
            InitializeComponent();
        }
        public string conString = "Data Source=DESKTOP-702LQK5\\SQLEXPRESS;Initial Catalog=libraryproject;Integrated Security=True;Trust Server Certificate=True";
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            KitapKayit kitapkayit = new KitapKayit();
            kitapkayit.ShowDialog();
        }

        private void btn‹yeKay˝t_Click(object sender, EventArgs e)
        {
            uyekayit uyeekle = new uyekayit();
            uyeekle.ShowDialog();
        }

        private void btnStok_Click(object sender, EventArgs e)
        {
            StokKontrolfrm stok = new StokKontrolfrm();

            stok.ShowDialog();
        }

        private void btn÷d¸nÁKitap_Click(object sender, EventArgs e)
        {
            odunckitap odunc = new odunckitap();
            odunc.ShowDialog();
        }

        private void btnKitap›ade_Click(object sender, EventArgs e)
        {
            Kitap›ade kitap›ade = new Kitap›ade();
            kitap›ade.ShowDialog();
        }
    }
}
