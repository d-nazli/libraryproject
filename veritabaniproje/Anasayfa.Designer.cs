namespace veritabaniproje
{
    partial class Anasayfa
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            btnStok = new Button();
            btnkitapkayıt = new Button();
            groupBox2 = new GroupBox();
            btnKitapİade = new Button();
            btnÖdünçKitap = new Button();
            groupBox3 = new GroupBox();
            btnÜyeKayıt = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.GradientActiveCaption;
            groupBox1.Controls.Add(btnStok);
            groupBox1.Controls.Add(btnkitapkayıt);
            groupBox1.Font = new Font("Segoe UI", 13F);
            groupBox1.Location = new Point(44, 82);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(200, 142);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Kitap İşlemleri";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // btnStok
            // 
            btnStok.Location = new Point(6, 93);
            btnStok.Name = "btnStok";
            btnStok.Size = new Size(188, 30);
            btnStok.TabIndex = 1;
            btnStok.Text = "Stok Kontrol";
            btnStok.UseVisualStyleBackColor = true;
            btnStok.Click += btnStok_Click;
            // 
            // btnkitapkayıt
            // 
            btnkitapkayıt.Location = new Point(6, 41);
            btnkitapkayıt.Name = "btnkitapkayıt";
            btnkitapkayıt.Size = new Size(188, 35);
            btnkitapkayıt.TabIndex = 0;
            btnkitapkayıt.Text = "Kitap Kayıt";
            btnkitapkayıt.UseVisualStyleBackColor = true;
            btnkitapkayıt.Click += button1_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnKitapİade);
            groupBox2.Controls.Add(btnÖdünçKitap);
            groupBox2.Font = new Font("Segoe UI", 13F);
            groupBox2.Location = new Point(569, 82);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(200, 142);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Ödünç Kitap İşlemleri";
            // 
            // btnKitapİade
            // 
            btnKitapİade.Location = new Point(6, 93);
            btnKitapİade.Name = "btnKitapİade";
            btnKitapİade.Size = new Size(188, 30);
            btnKitapİade.TabIndex = 1;
            btnKitapİade.Text = "Kitapİade";
            btnKitapİade.UseVisualStyleBackColor = true;
            btnKitapİade.Click += btnKitapİade_Click;
            // 
            // btnÖdünçKitap
            // 
            btnÖdünçKitap.Location = new Point(6, 41);
            btnÖdünçKitap.Name = "btnÖdünçKitap";
            btnÖdünçKitap.Size = new Size(188, 35);
            btnÖdünçKitap.TabIndex = 0;
            btnÖdünçKitap.Text = "Ödünç Kitap";
            btnÖdünçKitap.UseVisualStyleBackColor = true;
            btnÖdünçKitap.Click += btnÖdünçKitap_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btnÜyeKayıt);
            groupBox3.Font = new Font("Segoe UI", 13F);
            groupBox3.Location = new Point(296, 82);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(200, 142);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Üye İşlemleri";
            // 
            // btnÜyeKayıt
            // 
            btnÜyeKayıt.Location = new Point(6, 41);
            btnÜyeKayıt.Name = "btnÜyeKayıt";
            btnÜyeKayıt.Size = new Size(175, 35);
            btnÜyeKayıt.TabIndex = 0;
            btnÜyeKayıt.Text = "Üye Kayıt";
            btnÜyeKayıt.UseVisualStyleBackColor = true;
            btnÜyeKayıt.Click += btnÜyeKayıt_Click;
            // 
            // Anasayfa
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(800, 299);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Anasayfa";
            Text = " Anasayfa";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private Button btnStok;
        private Button btnkitapkayıt;
        private Button btnKitapİade;
        private Button btnÖdünçKitap;
        private Button btnÜyeKayıt;
    }
}
