namespace oyuncak_dukkani
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        static string musteri_girisi = "musteri";
        static string yonetici_girisi = "yonetici";
        static int musteri_sifre = 12345;
        static int yonetici_sifre = 12345;
        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                if (textBox1.Text == "musteri" && Convert.ToInt32(textBox2.Text) == 12345)
                {
                    form2 musteri = new form2();
                    musteri.Show();
                }
                else
                {
                    MessageBox.Show("�ifre veya kullan�c� ad� yanl��");
                }
            }
            else if (radioButton2.Checked == true)
            {
                if (textBox1.Text == "yonetici" && Convert.ToInt32(textBox2.Text) == 12345)
                {

                }
                else
                {
                    MessageBox.Show("�ifre veya kullan�c� ad� yanl��");
                }
            }
        }

        private void btn_geli�tirici_Click(object sender, EventArgs e)
        {
            form2 geli�tirici = new form2();
            geli�tirici.Show();
        }
    }
}
