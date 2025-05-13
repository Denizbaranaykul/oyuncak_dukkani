namespace oyuncak_dukkani
{
    partial class Form1
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
            txt_ad = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txt_sifre = new TextBox();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            btn_geliştirici = new Button();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txt_ad
            // 
            txt_ad.Location = new Point(238, 190);
            txt_ad.Name = "txt_ad";
            txt_ad.Size = new Size(220, 27);
            txt_ad.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(238, 167);
            label1.Name = "label1";
            label1.Size = new Size(88, 20);
            label1.TabIndex = 1;
            label1.Text = "kullanici adi";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(238, 251);
            label2.Name = "label2";
            label2.Size = new Size(37, 20);
            label2.TabIndex = 3;
            label2.Text = "şifre";
            // 
            // txt_sifre
            // 
            txt_sifre.Location = new Point(238, 274);
            txt_sifre.Name = "txt_sifre";
            txt_sifre.Size = new Size(220, 27);
            txt_sifre.TabIndex = 2;
            // 
            // button1
            // 
            button1.Location = new Point(238, 336);
            button1.Name = "button1";
            button1.Size = new Size(220, 58);
            button1.TabIndex = 4;
            button1.Text = "giriş";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Untitled_design;
            pictureBox1.Location = new Point(238, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(220, 88);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(238, 118);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(115, 24);
            radioButton1.TabIndex = 6;
            radioButton1.TabStop = true;
            radioButton1.Text = "müşteri girişi";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(371, 118);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(120, 24);
            radioButton2.TabIndex = 7;
            radioButton2.TabStop = true;
            radioButton2.Text = "kullanıcı girişi";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // btn_geliştirici
            // 
            btn_geliştirici.Location = new Point(577, 138);
            btn_geliştirici.Name = "btn_geliştirici";
            btn_geliştirici.Size = new Size(126, 29);
            btn_geliştirici.TabIndex = 8;
            btn_geliştirici.Text = "geliştirici_girişi";
            btn_geliştirici.UseVisualStyleBackColor = true;
            btn_geliştirici.Click += btn_geliştirici_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 8.25F);
            label3.ForeColor = Color.Red;
            label3.Location = new Point(238, 231);
            label3.Name = "label3";
            label3.Size = new Size(0, 19);
            label3.TabIndex = 9;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(btn_geliştirici);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(pictureBox1);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(txt_sifre);
            Controls.Add(label1);
            Controls.Add(txt_ad);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_ad;
        private Label label1;
        private Label label2;
        private TextBox txt_sifre;
        private Button button1;
        private PictureBox pictureBox1;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private Button btn_geliştirici;
        private Label label3;
    }
}
