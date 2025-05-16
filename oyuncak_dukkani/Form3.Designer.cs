namespace oyuncak_dukkani
{
    partial class Form3
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
            panel1 = new Panel();
            btn_bilgi_guncelle = new Button();
            btn_geri_dön = new Button();
            lblFiyat = new Label();
            lblFiyatSol = new Label();
            lblStok = new Label();
            lblStokAdediSol = new Label();
            cmbUrunSecSol = new ComboBox();
            lblUrunSecinizSol = new Label();
            lblUrunBilgileri = new Label();
            lblUrunGuncelleme = new Label();
            panel3 = new Panel();
            lblUrunSecinizSag = new Label();
            cmbUrunSecSag = new ComboBox();
            btnGuncelle = new Button();
            pbUrunResmi = new PictureBox();
            btnFotografEkle = new Button();
            txtUrunFiyat = new TextBox();
            txtStokAdedi = new TextBox();
            txtUrunAdi = new TextBox();
            label6 = new Label();
            label8 = new Label();
            label11 = new Label();
            panel4 = new Panel();
            lblKullaniciAdi = new Label();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbUrunResmi).BeginInit();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.PaleTurquoise;
            panel1.Controls.Add(btn_bilgi_guncelle);
            panel1.Controls.Add(btn_geri_dön);
            panel1.Controls.Add(lblFiyat);
            panel1.Controls.Add(lblFiyatSol);
            panel1.Controls.Add(lblStok);
            panel1.Controls.Add(lblStokAdediSol);
            panel1.Controls.Add(cmbUrunSecSol);
            panel1.Controls.Add(lblUrunSecinizSol);
            panel1.Location = new Point(12, 59);
            panel1.Name = "panel1";
            panel1.Size = new Size(334, 485);
            panel1.TabIndex = 0;
            // 
            // btn_bilgi_guncelle
            // 
            btn_bilgi_guncelle.BackColor = Color.Pink;
            btn_bilgi_guncelle.Location = new Point(137, 406);
            btn_bilgi_guncelle.Name = "btn_bilgi_guncelle";
            btn_bilgi_guncelle.Size = new Size(145, 29);
            btn_bilgi_guncelle.TabIndex = 7;
            btn_bilgi_guncelle.Text = "verileri güncelle";
            btn_bilgi_guncelle.UseVisualStyleBackColor = false;
            btn_bilgi_guncelle.Click += btn_bilgi_guncelle_Click;
            // 
            // btn_geri_dön
            // 
            btn_geri_dön.BackColor = Color.Pink;
            btn_geri_dön.Location = new Point(25, 406);
            btn_geri_dön.Name = "btn_geri_dön";
            btn_geri_dön.Size = new Size(91, 29);
            btn_geri_dön.TabIndex = 6;
            btn_geri_dön.Text = "geriye dön";
            btn_geri_dön.UseVisualStyleBackColor = false;
            btn_geri_dön.Click += btn_geri_dön_Click;
            // 
            // lblFiyat
            // 
            lblFiyat.AutoSize = true;
            lblFiyat.Font = new Font("Segoe UI", 15F);
            lblFiyat.Location = new Point(108, 309);
            lblFiyat.Name = "lblFiyat";
            lblFiyat.Size = new Size(40, 35);
            lblFiyat.TabIndex = 5;
            lblFiyat.Text = "TL";
            // 
            // lblFiyatSol
            // 
            lblFiyatSol.AutoSize = true;
            lblFiyatSol.Font = new Font("Segoe UI", 15F);
            lblFiyatSol.Location = new Point(108, 256);
            lblFiyatSol.Name = "lblFiyatSol";
            lblFiyatSol.Size = new Size(154, 35);
            lblFiyatSol.TabIndex = 4;
            lblFiyatSol.Text = "ürünün fiyatı";
            // 
            // lblStok
            // 
            lblStok.AutoSize = true;
            lblStok.Font = new Font("Segoe UI", 15F);
            lblStok.Location = new Point(108, 191);
            lblStok.Name = "lblStok";
            lblStok.Size = new Size(80, 35);
            lblStok.TabIndex = 3;
            lblStok.Text = "stok : ";
            // 
            // lblStokAdediSol
            // 
            lblStokAdediSol.AutoSize = true;
            lblStokAdediSol.Font = new Font("Segoe UI", 15F);
            lblStokAdediSol.Location = new Point(108, 134);
            lblStokAdediSol.Name = "lblStokAdediSol";
            lblStokAdediSol.Size = new Size(130, 35);
            lblStokAdediSol.TabIndex = 2;
            lblStokAdediSol.Text = "stok adedi";
            // 
            // cmbUrunSecSol
            // 
            cmbUrunSecSol.FormattingEnabled = true;
            cmbUrunSecSol.Location = new Point(96, 77);
            cmbUrunSecSol.Name = "cmbUrunSecSol";
            cmbUrunSecSol.Size = new Size(186, 28);
            cmbUrunSecSol.TabIndex = 1;
            cmbUrunSecSol.SelectedIndexChanged += cmbUrunSecSol_SelectedIndexChanged;
            // 
            // lblUrunSecinizSol
            // 
            lblUrunSecinizSol.AutoSize = true;
            lblUrunSecinizSol.Font = new Font("Segoe UI", 15F);
            lblUrunSecinizSol.Location = new Point(108, 16);
            lblUrunSecinizSol.Name = "lblUrunSecinizSol";
            lblUrunSecinizSol.Size = new Size(160, 35);
            lblUrunSecinizSol.TabIndex = 0;
            lblUrunSecinizSol.Text = "ürünü seçiniz";
            // 
            // lblUrunBilgileri
            // 
            lblUrunBilgileri.AutoSize = true;
            lblUrunBilgileri.Font = new Font("Segoe UI", 15F);
            lblUrunBilgileri.Location = new Point(83, 4);
            lblUrunBilgileri.Name = "lblUrunBilgileri";
            lblUrunBilgileri.Size = new Size(155, 35);
            lblUrunBilgileri.TabIndex = 4;
            lblUrunBilgileri.Text = "ürün bilgileri";
            // 
            // lblUrunGuncelleme
            // 
            lblUrunGuncelleme.AutoSize = true;
            lblUrunGuncelleme.Font = new Font("Segoe UI", 15F);
            lblUrunGuncelleme.Location = new Point(444, 4);
            lblUrunGuncelleme.Name = "lblUrunGuncelleme";
            lblUrunGuncelleme.Size = new Size(201, 35);
            lblUrunGuncelleme.TabIndex = 5;
            lblUrunGuncelleme.Text = "ürün güncelleme";
            // 
            // panel3
            // 
            panel3.BackColor = Color.LightGoldenrodYellow;
            panel3.Controls.Add(lblUrunSecinizSag);
            panel3.Controls.Add(cmbUrunSecSag);
            panel3.Controls.Add(btnGuncelle);
            panel3.Controls.Add(pbUrunResmi);
            panel3.Controls.Add(btnFotografEkle);
            panel3.Controls.Add(txtUrunFiyat);
            panel3.Controls.Add(txtStokAdedi);
            panel3.Controls.Add(txtUrunAdi);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(label8);
            panel3.Controls.Add(label11);
            panel3.Location = new Point(352, 59);
            panel3.Name = "panel3";
            panel3.Size = new Size(450, 485);
            panel3.TabIndex = 6;
            // 
            // lblUrunSecinizSag
            // 
            lblUrunSecinizSag.AutoSize = true;
            lblUrunSecinizSag.Font = new Font("Segoe UI", 15F);
            lblUrunSecinizSag.Location = new Point(67, 16);
            lblUrunSecinizSag.Name = "lblUrunSecinizSag";
            lblUrunSecinizSag.Size = new Size(160, 35);
            lblUrunSecinizSag.TabIndex = 13;
            lblUrunSecinizSag.Text = "ürünü seçiniz";
            // 
            // cmbUrunSecSag
            // 
            cmbUrunSecSag.FormattingEnabled = true;
            cmbUrunSecSag.Location = new Point(67, 68);
            cmbUrunSecSag.Name = "cmbUrunSecSag";
            cmbUrunSecSag.Size = new Size(164, 28);
            cmbUrunSecSag.TabIndex = 12;
            // 
            // btnGuncelle
            // 
            btnGuncelle.Location = new Point(67, 408);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(164, 51);
            btnGuncelle.TabIndex = 11;
            btnGuncelle.Text = "güncelleme";
            btnGuncelle.UseVisualStyleBackColor = true;
            btnGuncelle.Click += btnGuncelle_Click;
            // 
            // pbUrunResmi
            // 
            pbUrunResmi.Location = new Point(264, 75);
            pbUrunResmi.Name = "pbUrunResmi";
            pbUrunResmi.Size = new Size(167, 141);
            pbUrunResmi.SizeMode = PictureBoxSizeMode.StretchImage;
            pbUrunResmi.TabIndex = 10;
            pbUrunResmi.TabStop = false;
            // 
            // btnFotografEkle
            // 
            btnFotografEkle.Location = new Point(267, 239);
            btnFotografEkle.Name = "btnFotografEkle";
            btnFotografEkle.Size = new Size(164, 79);
            btnFotografEkle.TabIndex = 9;
            btnFotografEkle.Text = "fotoğraf ekleyin";
            btnFotografEkle.UseVisualStyleBackColor = true;
            btnFotografEkle.Click += btnFotografEkle_Click;
            // 
            // txtUrunFiyat
            // 
            txtUrunFiyat.Location = new Point(67, 362);
            txtUrunFiyat.Name = "txtUrunFiyat";
            txtUrunFiyat.Size = new Size(164, 27);
            txtUrunFiyat.TabIndex = 8;
            // 
            // txtStokAdedi
            // 
            txtStokAdedi.Location = new Point(67, 258);
            txtStokAdedi.Name = "txtStokAdedi";
            txtStokAdedi.Size = new Size(164, 27);
            txtStokAdedi.TabIndex = 7;
            // 
            // txtUrunAdi
            // 
            txtUrunAdi.Location = new Point(67, 161);
            txtUrunAdi.Name = "txtUrunAdi";
            txtUrunAdi.Size = new Size(164, 27);
            txtUrunAdi.TabIndex = 6;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 15F);
            label6.Location = new Point(67, 311);
            label6.Name = "label6";
            label6.Size = new Size(154, 35);
            label6.TabIndex = 4;
            label6.Text = "ürünün fiyatı";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 15F);
            label8.Location = new Point(67, 201);
            label8.Name = "label8";
            label8.Size = new Size(130, 35);
            label8.TabIndex = 2;
            label8.Text = "stok adedi";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 15F);
            label11.Location = new Point(62, 99);
            label11.Name = "label11";
            label11.Size = new Size(155, 35);
            label11.TabIndex = 0;
            label11.Text = "ürünün adını";
            // 
            // panel4
            // 
            panel4.BackColor = Color.BurlyWood;
            panel4.Controls.Add(lblKullaniciAdi);
            panel4.Controls.Add(lblUrunGuncelleme);
            panel4.Controls.Add(lblUrunBilgileri);
            panel4.Location = new Point(12, 5);
            panel4.Name = "panel4";
            panel4.Size = new Size(790, 48);
            panel4.TabIndex = 7;
            // 
            // lblKullaniciAdi
            // 
            lblKullaniciAdi.AutoSize = true;
            lblKullaniciAdi.Location = new Point(303, 16);
            lblKullaniciAdi.Name = "lblKullaniciAdi";
            lblKullaniciAdi.Size = new Size(88, 20);
            lblKullaniciAdi.TabIndex = 6;
            lblKullaniciAdi.Text = "kullanıcı adı";
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(820, 568);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Name = "Form3";
            Text = "Form3";
            Load += Form3_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbUrunResmi).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label lblFiyat;
        private Label lblFiyatSol;
        private Label lblStok;
        private Label lblStokAdediSol;
        private ComboBox cmbUrunSecSol;
        private Label lblUrunSecinizSol;
        private Label lblUrunBilgileri;
        private Label lblUrunGuncelleme;
        private Panel panel3;
        private Button btnGuncelle;
        private PictureBox pbUrunResmi;
        private Button btnFotografEkle;
        private TextBox txtUrunFiyat;
        private TextBox txtStokAdedi;
        private TextBox txtUrunAdi;
        private Label label6;
        private Label label8;
        private Label label11;
        private Label lblUrunSecinizSag;
        private ComboBox cmbUrunSecSag;
        private Panel panel4;
        private Button btn_geri_dön;
        private Button btn_bilgi_guncelle;
        private Label lblKullaniciAdi;
    }
}