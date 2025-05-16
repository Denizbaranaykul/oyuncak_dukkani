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

    public partial class Form3 : Form
    {

        private User _girisYapan;

        public Form3(User kullanici)
        {
            InitializeComponent();
            _girisYapan = kullanici;

            // Örneğin:
            lblKullaniciAdi.Text = _girisYapan.KullaniciAdi;
        }




        private string connStr = "Server=localhost;Database=oyuncak_dukkan;Uid=root;Pwd=12345;";

        public Form3()
        {
            InitializeComponent();
        }

        private void btnFotografEkle_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Resim Dosyaları|*.jpg;*.jpeg;*.png;*.bmp";

            if (openFile.ShowDialog() == DialogResult.OK)
            {
                pbUrunResmi.Image = Image.FromFile(openFile.FileName);
                pbUrunResmi.Tag = openFile.FileName;
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (cmbUrunSecSag.SelectedItem == null)
            {
                MessageBox.Show("Lütfen güncellenecek ürünü seçin!");
                return;
            }

            string urunAdi = txtUrunAdi.Text;
            string stokAdedi = txtStokAdedi.Text;
            string urunFiyati = txtUrunFiyat.Text;
            string resimYolu = pbUrunResmi.Tag?.ToString();
            string secilenUrun = cmbUrunSecSag.SelectedItem.ToString();

            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                try
                {
                    conn.Open();
                    string sql = "UPDATE urunler SET urun_adi = @adi, stok = @stok, fiyat = @fiyat, resim_yolu = @resim WHERE urun_adi = @eskiAdi";

                    using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@adi", urunAdi);
                        cmd.Parameters.AddWithValue("@stok", stokAdedi);
                        cmd.Parameters.AddWithValue("@fiyat", urunFiyati);
                        cmd.Parameters.AddWithValue("@resim", resimYolu ?? "");
                        cmd.Parameters.AddWithValue("@eskiAdi", secilenUrun);

                        int etkilenen = cmd.ExecuteNonQuery();
                        if (etkilenen > 0)
                            MessageBox.Show("Ürün başarıyla güncellendi!");
                        else
                            MessageBox.Show("Güncelleme başarısız!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message);
                }
            }
        }

        private void cmbUrunSecSol_SelectedIndexChanged(object sender, EventArgs e)
        {
            string secilenUrun = cmbUrunSecSol.SelectedItem.ToString();

            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                try
                {
                    conn.Open();
                    string sql = "SELECT stok, fiyat FROM urunler WHERE urun_adi = @adi";
                    using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@adi", secilenUrun);

                        using (MySqlDataReader dr = cmd.ExecuteReader())
                        {
                            if (dr.Read())
                            {
                                lblStok.Text = "stok : " + dr["stok"].ToString();
                                lblFiyat.Text = "ürünün fiyatı\n" + dr["fiyat"].ToString() + " TL";
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Veritabanı hatası: " + ex.Message);
                }
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            cmbUrunSecSol.Items.Clear();
            cmbUrunSecSag.Items.Clear();

            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                try
                {
                    conn.Open();
                    string sql = "SELECT urun_adi FROM urunler";
                    using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                    {
                        using (MySqlDataReader dr = cmd.ExecuteReader())
                        {
                            while (dr.Read())
                            {
                                string urunAdi = dr["urun_adi"].ToString();
                                cmbUrunSecSol.Items.Add(urunAdi);
                                cmbUrunSecSag.Items.Add(urunAdi);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Veritabanı hatası: " + ex.Message);
                }
            }
        }

        private void btn_geri_dön_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 anaForm = new Form1();
            anaForm.Show();
        }

        private void btn_bilgi_guncelle_Click(object sender, EventArgs e)
        {
            // Comboboxları temizle
            cmbUrunSecSol.Items.Clear();
            cmbUrunSecSag.Items.Clear();

            // Veritabanından güncel ürün isimlerini tekrar çek
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                try
                {
                    conn.Open();
                    string sql = "SELECT urun_adi FROM urunler";
                    using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                    {
                        using (MySqlDataReader dr = cmd.ExecuteReader())
                        {
                            while (dr.Read())
                            {
                                string urunAdi = dr["urun_adi"].ToString();
                                cmbUrunSecSol.Items.Add(urunAdi);
                                cmbUrunSecSag.Items.Add(urunAdi);
                            }
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
