using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace oyuncak_dukkani
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string kullaniciAdi = txt_ad.Text.Trim();
            string sifre = txt_sifre.Text.Trim();

            if (string.IsNullOrEmpty(kullaniciAdi) || string.IsNullOrEmpty(sifre))
            {
                MessageBox.Show("Lütfen kullanýcý adý ve þifre girin!");
                return;
            }

            if (!radioButton1.Checked && !radioButton2.Checked)
            {
                MessageBox.Show("Lütfen bir giriþ türü seçin!");
                return;
            }

            if (radioButton1.Checked) // Müþteri giriþ
            {
                User musteri = GirisKontrol(kullaniciAdi, sifre, "SELECT * FROM musteri WHERE kullanici_adi=@kadi AND sifre=@sifre");
                if (musteri != null)
                {
                    MessageBox.Show("Müþteri giriþi baþarýlý!");
                    form2 musteriForm = new form2(musteri);
                    musteriForm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Hatalý kullanýcý adý veya þifre!");
                }
            }
            else if (radioButton2.Checked) // Yönetici giriþ
            {
                User yonetici = GirisKontrol(kullaniciAdi, sifre, "SELECT * FROM yonetici WHERE kullanici_adi=@kadi AND sifre=@sifre");
                if (yonetici != null)
                {
                    MessageBox.Show("Yönetici giriþi baþarýlý!");
                    Form3 yoneticiForm = new Form3(yonetici);
                    yoneticiForm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Hatalý kullanýcý adý veya þifre!");
                }
            }
        }

        private User GirisKontrol(string kullaniciAdi, string sifre, string sql)
        {
            string connStr = "Server=localhost;Database=oyuncak_dukkan;Uid=root;Pwd=12345;";
            User user = null;

            using (var conn = new MySqlConnection(connStr))
            {
                try
                {
                    conn.Open();
                    using (var cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@kadi", kullaniciAdi);
                        cmd.Parameters.AddWithValue("@sifre", sifre);

                        using (var reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                user = new User
                                {
                                    Id = Convert.ToInt32(reader["id"]),
                                    KullaniciAdi = reader["kullanici_adi"].ToString(),
                                    Sifre = reader["sifre"].ToString(),
                                    Isim = reader["isim"].ToString(),
                                    Soyisim = reader["soyisim"].ToString()
                                };
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Veritabaný baðlantý hatasý: " + ex.Message);
                }
            }
            return user;
        }

        private void btnKayitOl_Click(object sender, EventArgs e)
        {
            Form4 kayýt_form = new Form4();
            kayýt_form.Show();
        }
    }
}