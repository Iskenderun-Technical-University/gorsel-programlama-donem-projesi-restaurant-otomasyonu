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
    }
}
