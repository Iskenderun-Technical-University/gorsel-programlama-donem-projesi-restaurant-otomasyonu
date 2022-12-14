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
    }
}
