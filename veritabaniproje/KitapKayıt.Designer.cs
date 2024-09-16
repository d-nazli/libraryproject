namespace veritabaniproje
{
    partial class KitapKayit
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label2 = new Label();
            label4 = new Label();
            label1 = new Label();
            label3 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            txtKitapBarkod = new TextBox();
            txtKitapAdi = new TextBox();
            txtYazarID = new TextBox();
            txtYayineviID = new TextBox();
            txtSayfaSayi = new TextBox();
            txtKategori = new TextBox();
            txtStokSayi = new TextBox();
            txtISBN = new TextBox();
            btnkitapkayit = new Button();
            btnİptalKayit = new Button();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(152, 134);
            label2.Name = "label2";
            label2.Size = new Size(55, 15);
            label2.TabIndex = 1;
            label2.Text = "Kitap Adı";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(133, 92);
            label4.Name = "label4";
            label4.Size = new Size(74, 15);
            label4.TabIndex = 0;
            label4.Text = "Kitap Barkod";
            label4.Click += label4_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(159, 176);
            label1.Name = "label1";
            label1.Size = new Size(48, 15);
            label1.TabIndex = 2;
            label1.Text = "Yazar ID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(143, 225);
            label3.Name = "label3";
            label3.Size = new Size(64, 15);
            label3.TabIndex = 3;
            label3.Text = "Yayınevi ID";
            label3.Click += label3_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(140, 270);
            label5.Name = "label5";
            label5.Size = new Size(67, 15);
            label5.TabIndex = 4;
            label5.Text = "Sayfa Sayısı";
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(156, 309);
            label6.Name = "label6";
            label6.Size = new Size(51, 15);
            label6.TabIndex = 5;
            label6.Text = "Kategori";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(145, 351);
            label7.Name = "label7";
            label7.Size = new Size(62, 15);
            label7.TabIndex = 6;
            label7.Text = "Stok Sayısı";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(175, 393);
            label8.Name = "label8";
            label8.Size = new Size(32, 15);
            label8.TabIndex = 7;
            label8.Text = "ISBN";
            label8.Click += label8_Click;
            // 
            // txtKitapBarkod
            // 
            txtKitapBarkod.Location = new Point(229, 92);
            txtKitapBarkod.Name = "txtKitapBarkod";
            txtKitapBarkod.Size = new Size(242, 23);
            txtKitapBarkod.TabIndex = 8;
            // 
            // txtKitapAdi
            // 
            txtKitapAdi.Location = new Point(229, 134);
            txtKitapAdi.Name = "txtKitapAdi";
            txtKitapAdi.Size = new Size(242, 23);
            txtKitapAdi.TabIndex = 9;
            // 
            // txtYazarID
            // 
            txtYazarID.Location = new Point(229, 176);
            txtYazarID.Name = "txtYazarID";
            txtYazarID.Size = new Size(242, 23);
            txtYazarID.TabIndex = 10;
            // 
            // txtYayineviID
            // 
            txtYayineviID.Location = new Point(229, 222);
            txtYayineviID.Name = "txtYayineviID";
            txtYayineviID.Size = new Size(242, 23);
            txtYayineviID.TabIndex = 11;
            txtYayineviID.TextChanged += textBox4_TextChanged;
            // 
            // txtSayfaSayi
            // 
            txtSayfaSayi.Location = new Point(229, 267);
            txtSayfaSayi.Name = "txtSayfaSayi";
            txtSayfaSayi.Size = new Size(242, 23);
            txtSayfaSayi.TabIndex = 12;
            // 
            // txtKategori
            // 
            txtKategori.Location = new Point(229, 309);
            txtKategori.Name = "txtKategori";
            txtKategori.Size = new Size(242, 23);
            txtKategori.TabIndex = 13;
            // 
            // txtStokSayi
            // 
            txtStokSayi.Location = new Point(229, 351);
            txtStokSayi.Name = "txtStokSayi";
            txtStokSayi.Size = new Size(242, 23);
            txtStokSayi.TabIndex = 14;
            // 
            // txtISBN
            // 
            txtISBN.Location = new Point(229, 393);
            txtISBN.Name = "txtISBN";
            txtISBN.Size = new Size(242, 23);
            txtISBN.TabIndex = 15;
            // 
            // btnkitapkayit
            // 
            btnkitapkayit.Location = new Point(253, 435);
            btnkitapkayit.Name = "btnkitapkayit";
            btnkitapkayit.Size = new Size(75, 32);
            btnkitapkayit.TabIndex = 16;
            btnkitapkayit.Text = "Ekle";
            btnkitapkayit.UseVisualStyleBackColor = true;
            btnkitapkayit.Click += btnEkleKitapKayıt_Click;
            // 
            // btnİptalKayit
            // 
            btnİptalKayit.Location = new Point(354, 435);
            btnİptalKayit.Name = "btnİptalKayit";
            btnİptalKayit.Size = new Size(75, 32);
            btnİptalKayit.TabIndex = 17;
            btnİptalKayit.Text = "İptal";
            btnİptalKayit.UseVisualStyleBackColor = true;
            btnİptalKayit.Click += btnİptalKayit_Click;
            // 
            // KitapKayit
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(611, 487);
            Controls.Add(btnİptalKayit);
            Controls.Add(btnkitapkayit);
            Controls.Add(txtISBN);
            Controls.Add(txtStokSayi);
            Controls.Add(txtKategori);
            Controls.Add(txtSayfaSayi);
            Controls.Add(txtYayineviID);
            Controls.Add(txtYazarID);
            Controls.Add(txtKitapAdi);
            Controls.Add(txtKitapBarkod);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(label4);
            Name = "KitapKayit";
            Text = "KitapKayıt";
            Load += KitapKayit_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label4;
        private Label label1;
        private Label label3;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox txtKitapBarkod;
        private TextBox txtKitapAdı;
        private TextBox txtYazarID;
        private TextBox txtYayıneviID;
        private TextBox txtSayfaSayi;
        private TextBox txtKategori;
        private TextBox txtStokSayi;
        private TextBox txtISBN;
        private Button btnEkleKitapKayıt;
        private Button btnİptalKayıt;
        private TextBox txtKitapAdi;
        private TextBox txtYayineviID;
        private Button btnkitapkayit;
        private Button btnİptalKayit;
    }
}