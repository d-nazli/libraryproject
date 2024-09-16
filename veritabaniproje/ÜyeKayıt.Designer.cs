namespace veritabaniproje
{
    partial class uyekayit
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            txtTC = new TextBox();
            txtAD = new TextBox();
            txtSoyad = new TextBox();
            txtEposta = new TextBox();
            txtTel = new TextBox();
            txtAdres = new TextBox();
            cbtxtuyeliktarihi = new ComboBox();
            btnuyekayit = new Button();
            btniptaluyekayit = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(138, 77);
            label1.Name = "label1";
            label1.Size = new Size(20, 15);
            label1.TabIndex = 0;
            label1.Text = "TC";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(136, 119);
            label2.Name = "label2";
            label2.Size = new Size(22, 15);
            label2.TabIndex = 1;
            label2.Text = "Ad";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(119, 158);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 2;
            label3.Text = "Soyad";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(111, 203);
            label4.Name = "label4";
            label4.Size = new Size(47, 15);
            label4.TabIndex = 3;
            label4.Text = "E-Posta";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(113, 249);
            label5.Name = "label5";
            label5.Size = new Size(45, 15);
            label5.TabIndex = 4;
            label5.Text = "Telefon";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(121, 286);
            label6.Name = "label6";
            label6.Size = new Size(37, 15);
            label6.TabIndex = 5;
            label6.Text = "Adres";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(88, 332);
            label7.Name = "label7";
            label7.Size = new Size(70, 15);
            label7.TabIndex = 6;
            label7.Text = "Üyelik Tarihi";
            // 
            // txtTC
            // 
            txtTC.Location = new Point(162, 77);
            txtTC.Name = "txtTC";
            txtTC.Size = new Size(246, 23);
            txtTC.TabIndex = 8;
            // 
            // txtAD
            // 
            txtAD.Location = new Point(162, 119);
            txtAD.Name = "txtAD";
            txtAD.Size = new Size(246, 23);
            txtAD.TabIndex = 9;
            // 
            // txtSoyad
            // 
            txtSoyad.Location = new Point(162, 158);
            txtSoyad.Name = "txtSoyad";
            txtSoyad.Size = new Size(246, 23);
            txtSoyad.TabIndex = 10;
            // 
            // txtEposta
            // 
            txtEposta.Location = new Point(162, 203);
            txtEposta.Name = "txtEposta";
            txtEposta.Size = new Size(246, 23);
            txtEposta.TabIndex = 11;
            // 
            // txtTel
            // 
            txtTel.Location = new Point(162, 249);
            txtTel.Name = "txtTel";
            txtTel.Size = new Size(246, 23);
            txtTel.TabIndex = 12;
            // 
            // txtAdres
            // 
            txtAdres.Location = new Point(162, 286);
            txtAdres.Name = "txtAdres";
            txtAdres.Size = new Size(246, 23);
            txtAdres.TabIndex = 13;
            // 
            // cbtxtuyeliktarihi
            // 
            cbtxtuyeliktarihi.FormattingEnabled = true;
            cbtxtuyeliktarihi.Location = new Point(162, 332);
            cbtxtuyeliktarihi.Name = "cbtxtuyeliktarihi";
            cbtxtuyeliktarihi.Size = new Size(246, 23);
            cbtxtuyeliktarihi.TabIndex = 15;
            cbtxtuyeliktarihi.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // btnuyekayit
            // 
            btnuyekayit.Location = new Point(186, 381);
            btnuyekayit.Name = "btnuyekayit";
            btnuyekayit.Size = new Size(81, 33);
            btnuyekayit.TabIndex = 16;
            btnuyekayit.Text = "Ekle";
            btnuyekayit.UseVisualStyleBackColor = true;
            btnuyekayit.Click += btnuyekayit_Click;
            // 
            // btniptaluyekayit
            // 
            btniptaluyekayit.Location = new Point(295, 381);
            btniptaluyekayit.Name = "btniptaluyekayit";
            btniptaluyekayit.Size = new Size(85, 33);
            btniptaluyekayit.TabIndex = 17;
            btniptaluyekayit.Text = "İptal";
            btniptaluyekayit.UseVisualStyleBackColor = true;
            btniptaluyekayit.Click += btniptaluyekayit_Click;
            // 
            // uyekayit
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(465, 450);
            Controls.Add(btniptaluyekayit);
            Controls.Add(btnuyekayit);
            Controls.Add(cbtxtuyeliktarihi);
            Controls.Add(txtAdres);
            Controls.Add(txtTel);
            Controls.Add(txtEposta);
            Controls.Add(txtSoyad);
            Controls.Add(txtAD);
            Controls.Add(txtTC);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "uyekayit";
            Text = "ÜyeKayıt";
            Load += uyekayit_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox txtTC;
        private TextBox txtAD;
        private TextBox txtSoyad;
        private TextBox txtEposta;
        private TextBox txtTel;
        private TextBox txtAdres;
        private ComboBox cbtxtuyeliktarihi;
        private Button btnuyekayit;
        private Button btniptaluyekayit;
    }
}