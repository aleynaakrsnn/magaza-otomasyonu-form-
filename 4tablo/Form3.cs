using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4tablo
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }


        M07Entities con = new M07Entities();


        public void Listele()
        {

            dataGridView1.DataSource = con.Urun1.ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Listele(); 
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow satir = dataGridView1.CurrentRow;
            textBox1.Tag = satir.Cells["UrunNo"].Value.ToString();
            textBox2.Text = satir.Cells["UrunAdi"].Value.ToString();
            textBox3.Text = satir.Cells["UrunAdeti"].Value.ToString();
            textBox4.Text = satir.Cells["UrunFiyati"].Value.ToString();
            textBox5.Text = satir.Cells["UrunKodu"].Value.ToString();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Urun1 save = new Urun1();
            save.UrunNo = Convert.ToInt32(textBox1.Tag);
            save.UrunAdi = textBox2.Text;
            save.UrunAdeti = Convert.ToInt32(textBox5.Text);
            save.UrunFiyati = Convert.ToInt32(textBox3.Text);
            save.UrunKodu = Convert.ToInt32(textBox4.Text);
            con.Urun1.Add(save);
            con.SaveChanges();
          
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int No = Convert.ToInt32(textBox1.Tag);
            var update = con.Urun1.Where(x => x.UrunNo == No).FirstOrDefault();
            update.UrunAdi = textBox2.Text;
            update.UrunAdeti = Convert.ToInt32(textBox5.Text);
            update.UrunFiyati = Convert.ToInt32(textBox3.Text);
            update.UrunKodu = Convert.ToInt32(textBox4.Text);
            con.SaveChanges();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int No = Convert.ToInt32(textBox1.Tag);
            var delete = con.Urun1.Where(x => x.UrunNo == No).FirstOrDefault();
            con.Urun1.Remove(delete);
            con.SaveChanges();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form4 go = new Form4();
            go.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Form2 go = new Form2();
            go.Show();
            this.Hide();
        }
    }
}
