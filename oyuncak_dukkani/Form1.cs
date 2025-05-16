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
                MessageBox.Show("L�tfen kullan�c� ad� ve �ifre girin!");
                return;
            }

            if (!radioButton1.Checked && !radioButton2.Checked)
            {
                MessageBox.Show("L�tfen bir giri� t�r� se�in!");
                return;
            }

            if (radioButton1.Checked) // M��teri giri�
            {
                User musteri = GirisKontrol(kullaniciAdi, sifre, "SELECT * FROM musteri WHERE kullanici_adi=@kadi AND sifre=@sifre");
                if (musteri != null)
                {
                    MessageBox.Show("M��teri giri�i ba�ar�l�!");
                    form2 musteriForm = new form2(musteri);
                    musteriForm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Hatal� kullan�c� ad� veya �ifre!");
                }
            }
            else if (radioButton2.Checked) // Y�netici giri�
            {
                User yonetici = GirisKontrol(kullaniciAdi, sifre, "SELECT * FROM yonetici WHERE kullanici_adi=@kadi AND sifre=@sifre");
                if (yonetici != null)
                {
                    MessageBox.Show("Y�netici giri�i ba�ar�l�!");
                    Form3 yoneticiForm = new Form3(yonetici);
                    yoneticiForm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Hatal� kullan�c� ad� veya �ifre!");
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
                    MessageBox.Show("Veritaban� ba�lant� hatas�: " + ex.Message);
                }
            }
            return user;
        }

        private void btnKayitOl_Click(object sender, EventArgs e)
        {
            Form4 kay�t_form = new Form4();
            kay�t_form.Show();
        }
    }
}