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
    public partial class Rapor : Form
    {
        public Rapor()
        {
            InitializeComponent();
        }

        M07Entities con = new M07Entities();

        private void button1_Click(object sender, EventArgs e)
        {
            var result = from urunler in con.Urun1 orderby urunler.UrunAdi descending select urunler;
            dataGridView1.DataSource = result.ToList();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var result = from adet in con.Siparis1 orderby adet.SiparisAdeti ascending select adet;
            dataGridView1.DataSource= result.ToList();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            // markalar tablosunun hpsini çektim

            var result = from marka in con.Markalar select marka;
            dataGridView1.DataSource = result.ToList();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var result = con.Markalar.Where(marka => marka.MarkaAdi == "Zara").GroupBy(marka => marka.MarkaKodu);

            dataGridView1.DataSource = result.ToList();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var result = from markadı in con.Markalar where markadı.MarkaAdi == "hm" && markadı.MarkaTuru == "giyim" select markadı;
            dataGridView1.DataSource = result.ToList();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            var result = from siparis in con.Siparis1 select siparis;
            dataGridView1.DataSource =result.ToList();  
        }
    }
}
