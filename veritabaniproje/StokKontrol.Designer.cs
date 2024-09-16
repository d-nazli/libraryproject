namespace veritabaniproje
{
    partial class StokKontrolfrm
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
            dataGridStok = new DataGridView();
            label1 = new Label();
            txtBarkodaGöreAra = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridStok).BeginInit();
            SuspendLayout();
            // 
            // dataGridStok
            // 
            dataGridStok.BackgroundColor = SystemColors.ControlLightLight;
            dataGridStok.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridStok.Location = new Point(12, 131);
            dataGridStok.Name = "dataGridStok";
            dataGridStok.Size = new Size(935, 291);
            dataGridStok.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F);
            label1.Location = new Point(12, 63);
            label1.Name = "label1";
            label1.Size = new Size(127, 20);
            label1.TabIndex = 1;
            label1.Text = "Barkoda Göre Ara";
            // 
            // txtBarkodaGöreAra
            // 
            txtBarkodaGöreAra.Location = new Point(12, 86);
            txtBarkodaGöreAra.Name = "txtBarkodaGöreAra";
            txtBarkodaGöreAra.Size = new Size(179, 23);
            txtBarkodaGöreAra.TabIndex = 3;
            txtBarkodaGöreAra.TextChanged += txtBarkodaGöreAra_TextChanged;
            // 
            // StokKontrolfrm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(956, 494);
            Controls.Add(txtBarkodaGöreAra);
            Controls.Add(label1);
            Controls.Add(dataGridStok);
            Name = "StokKontrolfrm";
            Text = "StokKontrol";
            Load += StokKontrolfrm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridStok).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridStok;
        private Label label1;
        private TextBox txtBarkodaGöreAra;
    }
}