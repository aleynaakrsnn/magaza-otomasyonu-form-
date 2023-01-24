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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        M07Entities con = new M07Entities();


        public void Listele()
        {

            dataGridView1.DataSource = con.Markalar.ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Listele();  
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow satir = dataGridView1.CurrentRow;
            textBox1.Tag = satir.Cells["MarkaNo"].Value.ToString();
            textBox2.Text = satir.Cells["MarkaAdi"].Value.ToString();
            textBox3.Text = satir.Cells["MarkaTuru"].Value.ToString();
            textBox4.Text = satir.Cells["MarkaKodu"].Value.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Markalar save = new Markalar();
            save.MarkaNo = Convert.ToInt32(textBox1.Tag);
            save.MarkaAdi = textBox2.Text;
            save.MarkaTuru = textBox3.Text;
            save.MarkaKodu = Convert.ToInt32(textBox4.Text);
          
            con.Markalar.Add(save);
            con.SaveChanges();
            Listele();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int No = Convert.ToInt32(textBox1.Tag);
            var update = con.Markalar.Where(x => x.MarkaNo == No).FirstOrDefault();
            update.MarkaAdi = textBox2.Text;
            update.MarkaTuru = textBox3.Text;
            update.MarkaKodu = Convert.ToInt32(textBox4.Text);        
            con.SaveChanges();
            Listele();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            int No = Convert.ToInt32(textBox1.Text);
            var delete = con.Markalar.Where(x => x.MarkaNo == No).FirstOrDefault();
            con.Markalar.Remove(delete);
            con.SaveChanges();
            Listele();
        }

        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {

            DataGridViewRow satir = dataGridView1.CurrentRow;
            textBox1.Tag = satir.Cells["MarkaNo"].Value.ToString();
            textBox2.Text = satir.Cells["MarkaAdi"].Value.ToString();
            textBox3.Text = satir.Cells["MarkaTuru"].Value.ToString();
            textBox4.Text = satir.Cells["MarkaKodu"].Value.ToString();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Form1 go = new Form1();
            go.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form3 go = new Form3();
            go.Show();
            this.Hide();
        }
    }
    }

