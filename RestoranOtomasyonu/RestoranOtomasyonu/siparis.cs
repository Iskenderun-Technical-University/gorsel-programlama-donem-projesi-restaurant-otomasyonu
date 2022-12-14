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
        }
    }
}
