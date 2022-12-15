using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestoranOtomasyonu
{
    public partial class siparis : Form
    {
        public siparis()
        {
            InitializeComponent();
        }

        private void siparis_Load(object sender, EventArgs e)
        {
            textBox1.Text = Convert.ToString(corbalar.gidentoplam); // formlar arası fiyat veri iletimi yapılıyor
            textBox2.Text = Convert.ToString(AraSicaklar.gidentoplam);
            textBox3.Text= Convert.ToString(AnaYemekler.gidentoplam);
            textBox4.Text= Convert.ToString(ssutluTatlilar.gidentoplam);
            textBox5.Text= Convert.ToString(FormLabel.gidentoplam);
            textBox6.Text= Convert.ToString(SogukIcecekler.gidentoplam);
            textBox7.Text= Convert.ToString(SicakIcecekler.gidentoplam);
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int s1, s2, s3, s4, s5, s6, s7;
            s1 = Convert.ToInt32(textBox1.Text);
            s2 = Convert.ToInt32(textBox2.Text);    
            s3 = Convert.ToInt32(textBox3.Text);
            s4 = Convert.ToInt32(textBox4.Text);    
            s5 = Convert.ToInt32(textBox5.Text);
            s6 = Convert.ToInt32(textBox6.Text);
            s7 = Convert.ToInt32(textBox7.Text);

            int toplam = 0;
            toplam = s1 + s2 + s3 + s4 + s5 + s7 + s6;
            textBox8.Text = Convert.ToString(toplam);
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
