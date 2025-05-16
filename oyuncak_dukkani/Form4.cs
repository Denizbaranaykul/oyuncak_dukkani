using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace oyuncak_dukkani
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        private string connStr = "Server=localhost;Database=oyuncak_dukkan;Uid=root;Pwd=12345;";
        private void button1_Click(object sender, EventArgs e)
        {
            string kullaniciAdi = txt_kullanıcıadı.Text.Trim();
            string sifre = txtSifre.Text;
            string sifreTekrar = txtSifreTekrar.Text;
            string isim = txtIsim.Text.Trim();
            string soyisim = txtSoyisim.Text.Trim();

            if (string.IsNullOrEmpty(kullaniciAdi) || string.IsNullOrEmpty(sifre) || string.IsNullOrEmpty(sifreTekrar))
            {
                MessageBox.Show("Lütfen zorunlu alanları doldurun!");
                return;
            }

            if (sifre != sifreTekrar)
            {
                MessageBox.Show("Şifreler uyuşmuyor!");
                return;
            }

            // Kullanıcı adı veritabanında varsa engelle
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                try
                {
                    conn.Open();
                    string kontrolSql = "SELECT COUNT(*) FROM musteri WHERE kullanici_adi = @kadi";
                    using (MySqlCommand cmd = new MySqlCommand(kontrolSql, conn))
                    {
                        cmd.Parameters.AddWithValue("@kadi", kullaniciAdi);
                        int sayi = Convert.ToInt32(cmd.ExecuteScalar());

                        if (sayi > 0)
                        {
                            MessageBox.Show("Bu kullanıcı adı zaten alınmış!");
                            return;
                        }
                    }

                    // Kayıt ekleme
                    string ekleSql = "INSERT INTO musteri (kullanici_adi, sifre, isim, soyisim) VALUES (@kadi, @sifre, @isim, @soyisim)";
                    using (MySqlCommand cmd = new MySqlCommand(ekleSql, conn))
                    {
                        cmd.Parameters.AddWithValue("@kadi", kullaniciAdi);
                        cmd.Parameters.AddWithValue("@sifre", sifre);
                        cmd.Parameters.AddWithValue("@isim", isim);
                        cmd.Parameters.AddWithValue("@soyisim", soyisim);

                        int sonuc = cmd.ExecuteNonQuery();

                        if (sonuc > 0)
                        {
                            MessageBox.Show("Kayıt başarılı! Giriş yapabilirsiniz.");
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Kayıt başarısız oldu.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Veritabanı hatası: " + ex.Message);
                }
            }
        }
    }
}
