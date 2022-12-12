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
    public partial class kullicibilgileri : Form
    {
        public kullicibilgileri()
        {
            InitializeComponent();
        }

        private void kullicibilgileri_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {


            Form1 form1 = new Form1();
            form1.Show();  //form 1 göster
            this.Hide();//form kullanıcı bilgilerini gizle
        }
    }
}
