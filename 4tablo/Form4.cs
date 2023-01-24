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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        M07Entities con = new M07Entities();

        public void Listele()
        {

            dataGridView1.DataSource = con.Siparis1.ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Listele();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Siparis1 save = new Siparis1();
            save.SiparisNo = Convert.ToInt32(textBox1.Tag);
            save.SiparisTuru = textBox2.Text;
            save.SiparisAdeti = Convert.ToInt32(textBox3.Text);
            save.SiparisFiyati = Convert.ToInt32(textBox4.Text);          
            con.Siparis1.Add(save);
            con.SaveChanges();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int No = Convert.ToInt32(textBox1.Tag);
            var update = con.Siparis1.Where(x => x.SiparisNo == No).FirstOrDefault();
            update.SiparisTuru = textBox2.Text;
            update.SiparisAdeti = Convert.ToInt32(textBox3.Text);
            update.SiparisFiyati = Convert.ToInt32(textBox4.Text);          
            con.SaveChanges();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int No = Convert.ToInt32(textBox1.Tag);
            var delete = con.Siparis1.Where(x => x.SiparisNo == No).FirstOrDefault();
            con.Siparis1.Remove(delete);
            con.SaveChanges();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Rapor go = new Rapor();
            go.Show();
            this.Hide();
        }
    }
    }

