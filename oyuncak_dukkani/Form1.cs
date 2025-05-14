using System;
using System.Data.SQLite; // MySQL yerine SQLite kullan�yoruz
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
            string kullaniciAdi = txt_ad.Text;
            string sifre = txt_sifre.Text;

            string sql = "SELECT * FROM musteri WHERE kullanici_adi = @kadi AND sifre = @sifre";
            string sql2 = "SELECT * FROM yonetici WHERE kullanici_adi = @kadi AND sifre = @sifre";

            // Kullan�c� ya da y�netici giri� kontrol�n� yap
            if (radioButton1.Checked && GirisKontrol(kullaniciAdi, sifre, sql))
            {
                MessageBox.Show("Giri� ba�ar�l�!");
                form2 musteri = new form2();
                musteri.Show();
            }
            else if (radioButton2.Checked && GirisKontrol(kullaniciAdi, sifre, sql2))
            {
                MessageBox.Show("Giri� ba�ar�l�!");
                Form3 form3 = new Form3();
                form3.Show();
            }
            else
            {
                MessageBox.Show("Hatal� kullan�c� ad� veya �ifre!");
                label3.Text = "Kullan�c� ad� veya �ifre yanl��!";
            }
        }

        private bool GirisKontrol(string kullaniciAdi, string sifre, string sql)
        {
            // SQLite ba�lant� dizesi
            string connStr = @"Data Source=veritabani.db;Version=3;"; // Veritaban� dosyas�n�n yolunu do�ru ayarlamal�s�n

            using (var conn = new SQLiteConnection(connStr))
            {
                try
                {
                    conn.Open();
                    using (var cmd = new SQLiteCommand(sql, conn))
                    {
                        // SQL parametrelerini ekle
                        cmd.Parameters.AddWithValue("@kadi", kullaniciAdi);
                        cmd.Parameters.AddWithValue("@sifre", sifre);

                        using (var reader = cmd.ExecuteReader())
                        {
                            return reader.Read(); // true d�nerse giri� ba�ar�l�d�r
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Veritaban� ba�lant� hatas�: " + ex.Message);
                    return false;
                }
            }
        }

        private void btn_geli�tirici_Click(object sender, EventArgs e)
        {
            form2 form2 = new form2();
            form2.Show();
        }
    }
}
