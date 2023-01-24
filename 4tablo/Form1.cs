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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        M07Entities con = new M07Entities();

        public bool GirisYap(string ad, string sifre)
        {
            var login = from marka in con.Kullanici where marka.KullaniciAdi == ad && marka.Sifre == sifre select marka;
            if (login.Any())
            {
                return true;

            }
            else
            {
                return false;
            }
        }

        //private void button1_Click(object sender, EventArgs e)
        //{
        //    if (GirisYap(textBox1.Text, textBox2.Text))

        //    {
        //        MessageBox.Show("başarılı");
        //        Form2 go = new Form2();
        //        go.Show();
        //        this.Hide();
        //    }
        //    else
        //    {
        //        MessageBox.Show("başarısız");
        //        textBox1.Clear();
        //        textBox2.Clear();
        //    }
        //}

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (GirisYap(textBox3.Text, textBox4.Text))

            {
                MessageBox.Show("başarılı");
                Form2 go = new Form2();
                go.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("başarısız");
                textBox3.Clear();
                textBox4.Clear();
            }
        }
    }
}
