using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace oyuncak_dukkani
{
    public partial class form2 : Form
    {
        public form2()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            checkedListBox1.Items.Add(oyuncak5_lbl.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            checkedListBox1.Items.Add(oyuncak1_lbl.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            checkedListBox1.Items.Add(oyuncak2_lbl.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            checkedListBox1.Items.Add(oyuncak3_lbl.Text);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            checkedListBox1.Items.Add(oyuncak4_lbl.Text);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            checkedListBox1.Items.Add(oyuncak6_lbl.Text);

        }

        private void button7_Click(object sender, EventArgs e)
        {
            checkedListBox1.Items.Add(oyuncak7_lbl.Text);

        }

        private void button8_Click(object sender, EventArgs e)
        {
            checkedListBox1.Items.Add(oyuncak8_lbl.Text);

        }

        private void button9_Click(object sender, EventArgs e)
        {
            checkedListBox1.Items.Add(oyuncak9_lbl.Text);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            checkedListBox1.Items.Add(oyuncak10_lbl.Text);

        }

        private void button11_Click(object sender, EventArgs e)
        {
            checkedListBox1.Items.Add(oyuncak11_lbl.Text);

        }

        private void button12_Click(object sender, EventArgs e)
        {
            checkedListBox1.Items.Add(oyuncak12_lbl.Text);

        }

        private void button13_Click(object sender, EventArgs e)
        {
            checkedListBox1.Items.Add(oyuncak13_lbl.Text);

        }

        private void button14_Click(object sender, EventArgs e)
        {
            checkedListBox1.Items.Add(oyuncak14_lbl.Text);

        }

      
      

        private void btn_delete_Click(object sender, EventArgs e)
        {
            // Eğer işaretli hiçbir öğe yoksa uyarı ver
            if (checkedListBox1.CheckedItems.Count == 0)
            {
                MessageBox.Show("Seçili ürün yok!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Devam etme
            }
            // Önce işaretli öğeleri geçici bir listeye al
            List<object> secilenler = new List<object>();

            foreach (object item in checkedListBox1.CheckedItems)
            {
                secilenler.Add(item);
            }

            // Sonra bu liste üzerinden sil
            foreach (object item in secilenler)
            {
                checkedListBox1.Items.Remove(item);
            }
        }

        private void btn_tamamla_Click(object sender, EventArgs e)
        {
            if(checkedListBox1.Items.Count==0)
            {
                MessageBox.Show("sepetiniz zaten boş");
                return;
            }
            checkedListBox1.Items.Clear();
            MessageBox.Show("Alışveriş başarıyla tamamlandı");

        }
    }
}
