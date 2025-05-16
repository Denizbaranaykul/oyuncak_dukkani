namespace oyuncak_dukkani
{
    partial class Form4
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
            lblKullaniciAdi = new Label();
            txt_kullanıcıadı = new TextBox();
            label2 = new Label();
            txtSifre = new TextBox();
            label3 = new Label();
            txtSifreTekrar = new TextBox();
            label4 = new Label();
            txtIsim = new TextBox();
            txtSoyisim = new TextBox();
            label5 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // lblKullaniciAdi
            // 
            lblKullaniciAdi.AutoSize = true;
            lblKullaniciAdi.Location = new Point(286, 37);
            lblKullaniciAdi.Name = "lblKullaniciAdi";
            lblKullaniciAdi.Size = new Size(88, 20);
            lblKullaniciAdi.TabIndex = 0;
            lblKullaniciAdi.Text = "kullanıcı adı";
            // 
            // txt_kullanıcıadı
            // 
            txt_kullanıcıadı.BackColor = Color.White;
            txt_kullanıcıadı.Location = new Point(274, 60);
            txt_kullanıcıadı.Name = "txt_kullanıcıadı";
            txt_kullanıcıadı.Size = new Size(125, 27);
            txt_kullanıcıadı.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(319, 112);
            label2.Name = "label2";
            label2.Size = new Size(37, 20);
            label2.TabIndex = 2;
            label2.Text = "sifre";
            // 
            // txtSifre
            // 
            txtSifre.BackColor = Color.White;
            txtSifre.Location = new Point(274, 144);
            txtSifre.Name = "txtSifre";
            txtSifre.Size = new Size(125, 27);
            txtSifre.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(301, 199);
            label3.Name = "label3";
            label3.Size = new Size(83, 20);
            label3.TabIndex = 4;
            label3.Text = "Şifre Tekrar";
            // 
            // txtSifreTekrar
            // 
            txtSifreTekrar.BackColor = Color.White;
            txtSifreTekrar.Location = new Point(274, 236);
            txtSifreTekrar.Name = "txtSifreTekrar";
            txtSifreTekrar.Size = new Size(125, 27);
            txtSifreTekrar.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(291, 290);
            label4.Name = "label4";
            label4.Size = new Size(36, 20);
            label4.TabIndex = 6;
            label4.Text = "isim";
            // 
            // txtIsim
            // 
            txtIsim.BackColor = Color.White;
            txtIsim.Location = new Point(274, 313);
            txtIsim.Name = "txtIsim";
            txtIsim.Size = new Size(125, 27);
            txtIsim.TabIndex = 7;
            // 
            // txtSoyisim
            // 
            txtSoyisim.BackColor = Color.White;
            txtSoyisim.Location = new Point(274, 395);
            txtSoyisim.Name = "txtSoyisim";
            txtSoyisim.Size = new Size(125, 27);
            txtSoyisim.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(291, 354);
            label5.Name = "label5";
            label5.Size = new Size(58, 20);
            label5.TabIndex = 9;
            label5.Text = "soyisim";
            // 
            // button1
            // 
            button1.Location = new Point(502, 190);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 10;
            button1.Text = "kayıt ol";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(label5);
            Controls.Add(txtSoyisim);
            Controls.Add(txtIsim);
            Controls.Add(label4);
            Controls.Add(txtSifreTekrar);
            Controls.Add(label3);
            Controls.Add(txtSifre);
            Controls.Add(label2);
            Controls.Add(txt_kullanıcıadı);
            Controls.Add(lblKullaniciAdi);
            Name = "Form4";
            Text = "Form4";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblKullaniciAdi;
        private TextBox txt_kullanıcıadı;
        private Label label2;
        private TextBox txtSifre;
        private Label label3;
        private TextBox txtSifreTekrar;
        private Label label4;
        private TextBox txtIsim;
        private TextBox txtSoyisim;
        private Label label5;
        private Button button1;
    }
}