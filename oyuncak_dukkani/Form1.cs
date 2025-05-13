using MySql.Data.MySqlClient;
using System.Data;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Diagnostics.Eventing.Reader;
using System.Security.Cryptography.X509Certificates;
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

            if (radioButton1.Checked && GirisKontrol(kullaniciAdi, sifre, sql))
            {
                MessageBox.Show("Giriþ baþarýlý!");
                form2 musteri = new form2();
                musteri.Show();
            }
            else if (radioButton2.Checked && GirisKontrol(kullaniciAdi, sifre, sql2))
            {
                MessageBox.Show("Giriþ baþarýlý!");
                //Form3 form3 = new Form3();
                //form3.Show();
            }
            else
            {
                MessageBox.Show("Hatalý kullanýcý adý veya þifre!");
                label3.Text = "Kullanýcý adý veya þifre yanlýþ!";
            }


        }
        private bool GirisKontrol(string kullaniciAdi, string sifre, string sql)
        {
            string connStr = "Server=localhost;Database=oyuncak_dukkan;Uid=root;Pwd=12345;";

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
                            return reader.Read(); // true dönerse giriþ baþarýlýdýr
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Veritabaný baðlantý hatasý: " + ex.Message);
                    return false;
                }
            }
        }






    }
}
