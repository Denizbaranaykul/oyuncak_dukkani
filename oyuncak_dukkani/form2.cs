using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace oyuncak_dukkani
{
    public partial class form2 : Form
    {
        private User _girisYapan;

        public form2(User kullanici)
        {
            InitializeComponent();
            _girisYapan = kullanici;

            // Örneğin:
            lblKullaniciAdi.Text = _girisYapan.KullaniciAdi;
        }
        public form2()
        {
            InitializeComponent();
            
        }

        Dictionary<string, decimal> urunFiyatlari = new Dictionary<string, decimal>();

        string connStr = "Server=localhost;Database=oyuncak_dukkan;Uid=root;Pwd=12345;";

        private void ToplamFiyatGuncelle()
        {
            decimal toplam = 0;
            foreach (var item in checkedListBox1.Items)
            {
                string urunAdi = item.ToString();
                if (urunFiyatlari.ContainsKey(urunAdi))
                {
                    toplam += urunFiyatlari[urunAdi];
                }
            }
            lblToplamFiyat.Text = "Toplam Fiyat: " + toplam.ToString("C");
        }

        private void form2_Load(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connStr))
                {
                    conn.Open();
                    string sql = "SELECT urun_adi, fiyat FROM urunler";

                    using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                    using (MySqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            string urunAdi = dr["urun_adi"].ToString().Trim();
                            decimal fiyat = Convert.ToDecimal(dr["fiyat"]);

                            urunFiyatlari[urunAdi] = fiyat;

                            // Label eşleştirmeleri
                            if (oyuncak1_lbl.Text.Trim().ToLower() == urunAdi.ToLower()) oyuncak1_fiyat_lbl.Text = fiyat + " TL";
                            else if (oyuncak2_lbl.Text.Trim().ToLower() == urunAdi.ToLower()) oyuncak2_fiyat_lbl.Text = fiyat + " TL";
                            else if (oyuncak3_lbl.Text.Trim().ToLower() == urunAdi.ToLower()) oyuncak3_fiyat_lbl.Text = fiyat + " TL";
                            else if (oyuncak4_lbl.Text.Trim().ToLower() == urunAdi.ToLower()) oyuncak4_fiyat_lbl.Text = fiyat + " TL";
                            else if (oyuncak5_lbl.Text.Trim().ToLower() == urunAdi.ToLower()) oyuncak5_fiyat_lbl.Text = fiyat + " TL";
                            else if (oyuncak6_lbl.Text.Trim().ToLower() == urunAdi.ToLower()) oyuncak6_fiyat_lbl.Text = fiyat + " TL";
                            else if (oyuncak7_lbl.Text.Trim().ToLower() == urunAdi.ToLower()) oyuncak7_fiyat_lbl.Text = fiyat + " TL";
                            else if (oyuncak8_lbl.Text.Trim().ToLower() == urunAdi.ToLower()) oyuncak8_fiyat_lbl.Text = fiyat + " TL";
                            else if (oyuncak9_lbl.Text.Trim().ToLower() == urunAdi.ToLower()) oyuncak9_fiyat_lbl.Text = fiyat + " TL";
                            else if (oyuncak10_lbl.Text.Trim().ToLower() == urunAdi.ToLower()) oyuncak10_fiyat_lbl.Text = fiyat + " TL";
                            else if (oyuncak11_lbl.Text.Trim().ToLower() == urunAdi.ToLower()) oyuncak11_fiyat_lbl.Text = fiyat + " TL";
                            else if (oyuncak12_lbl.Text.Trim().ToLower() == urunAdi.ToLower()) oyuncak12_fiyat_lbl.Text = fiyat + " TL";
                            else if (oyuncak13_lbl.Text.Trim().ToLower() == urunAdi.ToLower()) oyuncak13_fiyat_lbl.Text = fiyat + " TL";
                            else if (oyuncak14_lbl.Text.Trim().ToLower() == urunAdi.ToLower()) oyuncak14_fiyat_lbl.Text = fiyat + " TL";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fiyatlar getirilirken hata oluştu: " + ex.Message);
            }

            lblToplamFiyat.Text = "Toplam Fiyat: 0 TL";
        }

        // Tüm sepete ekle butonları
        private void button1_Click(object sender, EventArgs e) => SepeteEkle(oyuncak1_lbl.Text);
        private void button2_Click(object sender, EventArgs e) => SepeteEkle(oyuncak2_lbl.Text);
        private void button3_Click(object sender, EventArgs e) => SepeteEkle(oyuncak3_lbl.Text);
        private void button4_Click(object sender, EventArgs e) => SepeteEkle(oyuncak4_lbl.Text);
        private void button5_Click(object sender, EventArgs e) => SepeteEkle(oyuncak5_lbl.Text);
        private void button6_Click(object sender, EventArgs e) => SepeteEkle(oyuncak6_lbl.Text);
        private void button7_Click(object sender, EventArgs e) => SepeteEkle(oyuncak7_lbl.Text);
        private void button8_Click(object sender, EventArgs e) => SepeteEkle(oyuncak8_lbl.Text);
        private void button9_Click(object sender, EventArgs e) => SepeteEkle(oyuncak9_lbl.Text);
        private void button10_Click(object sender, EventArgs e) => SepeteEkle(oyuncak10_lbl.Text);
        private void button11_Click(object sender, EventArgs e) => SepeteEkle(oyuncak11_lbl.Text);
        private void button12_Click(object sender, EventArgs e) => SepeteEkle(oyuncak12_lbl.Text);
        private void button13_Click(object sender, EventArgs e) => SepeteEkle(oyuncak13_lbl.Text);
        private void button14_Click(object sender, EventArgs e) => SepeteEkle(oyuncak14_lbl.Text);

        private void SepeteEkle(string urunAdi)
        {
            checkedListBox1.Items.Add(urunAdi);
            ToplamFiyatGuncelle();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (checkedListBox1.CheckedItems.Count == 0)
            {
                MessageBox.Show("Seçili ürün yok!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            List<object> secilenler = new List<object>();

            foreach (object item in checkedListBox1.CheckedItems)
                secilenler.Add(item);

            foreach (object item in secilenler)
                checkedListBox1.Items.Remove(item);

            ToplamFiyatGuncelle();
        }

        private void btn_tamamla_Click(object sender, EventArgs e)
        {
            if (checkedListBox1.Items.Count == 0)
            {
                MessageBox.Show("Sepetiniz zaten boş");
                return;
            }

            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                try
                {
                    conn.Open();

                    foreach (var item in checkedListBox1.Items)
                    {
                        string urunAdi = item.ToString();

                        // Stok kontrolü
                        string stokKontrolSql = "SELECT stok FROM urunler WHERE urun_adi = @adi";
                        using (MySqlCommand cmdKontrol = new MySqlCommand(stokKontrolSql, conn))
                        {
                            cmdKontrol.Parameters.AddWithValue("@adi", urunAdi);
                            object result = cmdKontrol.ExecuteScalar();

                            if (result == null)
                            {
                                MessageBox.Show($"Ürün bulunamadı: {urunAdi}");
                                return;
                            }

                            int stok = Convert.ToInt32(result);

                            if (stok <= 0)
                            {
                                MessageBox.Show($"Ürün stokta yok: {urunAdi}");
                                return;
                            }
                        }

                        // Stok azalt
                        string sql = "UPDATE urunler SET stok = stok - 1 WHERE urun_adi = @adi";
                        using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                        {
                            cmd.Parameters.AddWithValue("@adi", urunAdi);
                            cmd.ExecuteNonQuery();
                        }
                    }

                    MessageBox.Show("Alışveriş başarıyla tamamlandı. Stoklar güncellendi.");
                    checkedListBox1.Items.Clear();
                    ToplamFiyatGuncelle();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message);
                }
            }
        }

        private void btnGeriDon_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 anaForm = new Form1();
            anaForm.Show();
        }

    }
}