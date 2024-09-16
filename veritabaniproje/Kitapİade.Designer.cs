namespace veritabaniproje
{
    partial class Kitapİade
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
            gridkitapiade = new DataGridView();
            btnTeslimAl = new Button();
            btnİptalKitapİade = new Button();
            label1 = new Label();
            label2 = new Label();
            txttcara = new TextBox();
            txtbarkodara = new TextBox();
            ((System.ComponentModel.ISupportInitialize)gridkitapiade).BeginInit();
            SuspendLayout();
            // 
            // gridkitapiade
            // 
            gridkitapiade.BackgroundColor = SystemColors.ControlLightLight;
            gridkitapiade.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridkitapiade.Location = new Point(30, 146);
            gridkitapiade.Name = "gridkitapiade";
            gridkitapiade.Size = new Size(736, 199);
            gridkitapiade.TabIndex = 0;
            gridkitapiade.CellContentClick += dataGridİade_CellContentClick;
            // 
            // btnTeslimAl
            // 
            btnTeslimAl.Location = new Point(548, 385);
            btnTeslimAl.Name = "btnTeslimAl";
            btnTeslimAl.Size = new Size(91, 32);
            btnTeslimAl.TabIndex = 1;
            btnTeslimAl.Text = "Teslim Al";
            btnTeslimAl.UseVisualStyleBackColor = true;
            btnTeslimAl.Click += btnTeslimAl_Click;
            // 
            // btnİptalKitapİade
            // 
            btnİptalKitapİade.Location = new Point(668, 385);
            btnİptalKitapİade.Name = "btnİptalKitapİade";
            btnİptalKitapİade.Size = new Size(87, 32);
            btnİptalKitapİade.TabIndex = 2;
            btnİptalKitapİade.Text = "İptal";
            btnİptalKitapİade.UseVisualStyleBackColor = true;
            btnİptalKitapİade.Click += btnİptalKitapİade_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F);
            label1.Location = new Point(40, 65);
            label1.Name = "label1";
            label1.Size = new Size(107, 20);
            label1.TabIndex = 3;
            label1.Text = "TC ye Göre Ara";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F);
            label2.Location = new Point(299, 65);
            label2.Name = "label2";
            label2.Size = new Size(127, 20);
            label2.TabIndex = 4;
            label2.Text = "Barkoda Göre Ara";
            label2.Click += label2_Click;
            // 
            // txttcara
            // 
            txttcara.Location = new Point(40, 98);
            txttcara.Name = "txttcara";
            txttcara.Size = new Size(209, 23);
            txttcara.TabIndex = 5;
            txttcara.TextChanged += tcara_TextChanged;
            // 
            // txtbarkodara
            // 
            txtbarkodara.Location = new Point(299, 98);
            txtbarkodara.Name = "txtbarkodara";
            txtbarkodara.Size = new Size(191, 23);
            txtbarkodara.TabIndex = 6;
            txtbarkodara.TextChanged += txtbarkodara_TextChanged;
            // 
            // Kitapİade
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(txtbarkodara);
            Controls.Add(txttcara);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnİptalKitapİade);
            Controls.Add(btnTeslimAl);
            Controls.Add(gridkitapiade);
            Name = "Kitapİade";
            Text = "Kitapİade";
            Load += Kitapİade_Load;
            ((System.ComponentModel.ISupportInitialize)gridkitapiade).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView gridkitapiade;
        private Button btnTeslimAl;
        private Button btnİptalKitapİade;
        private Label label1;
        private Label label2;
        private TextBox txttcara;
        private TextBox txtbarkodara;
    }
}