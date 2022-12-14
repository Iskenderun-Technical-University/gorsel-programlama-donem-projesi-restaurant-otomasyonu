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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void çorbalarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            corbalar corbalar = new corbalar();
            corbalar.Show();
        }

        private void araSıcaklarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AraSicaklar araSicaklar = new AraSicaklar();
            araSicaklar.Show();
        }

        private void anaYemeklerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AnaYemekler anaYemekler = new AnaYemekler();
            anaYemekler.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void sütlüTatlılarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ssutluTatlilar ssutluTatlilar = new ssutluTatlilar();
            ssutluTatlilar.Show();
        }

        private void şerbetliTatlılarToolStripMenuItem_Click(object sender, EventArgs e)
        {
         FormLabel formLabel = new FormLabel();
            formLabel.Show();
        }
    }
}
