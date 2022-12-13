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
    public partial class corbalar : Form
    {
        public corbalar()
        {
            InitializeComponent();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a; //alınacak çorba sayısı için a değeri tanımladık 
           
            a=Convert.ToInt32(textBox1.Text);//a integer değer text ise string değer olduğu için dönüşüm yaptık
            a = a + 1;
            textBox1.Text=Convert.ToString(a);
            if(Convert.ToInt32(textBox1.Text)>0)//eğer textbox 0 dan büyükse buton 2 yi aktifleştir.

            {
                button2.Enabled = true;
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            int a; //alınacak çorba sayısı için a değeri tanımladık 

            a = Convert.ToInt32(textBox1.Text);//a integer değer text ise string değer olduğu için dönüşüm yaptık
            a = a - 1;
            textBox1.Text = Convert.ToString(a);
            if (textBox1.Text == Convert.ToString(0))//eğer textbox 0 ise buton 2 yi kapat.

            {
                button2.Enabled = false;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int b; //alınacak çorba sayısı için b değeri tanımladık 

            b = Convert.ToInt32(textBox2.Text);//b integer değer text ise string değer olduğu için dönüşüm yaptık
            
            b = b + 1;
            textBox2.Text = Convert.ToString(b);
            if (Convert.ToInt32(textBox2.Text) > 0)//eğer textbox 0 dan büyükse buton 4 yi aktifleştir.

            {
                button3.Enabled = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int b; //alınacak çorba sayısı için b değeri tanımladık 

            b = Convert.ToInt32(textBox2.Text);//b integer değer text ise string değer olduğu için dönüşüm yaptık
            b = b - 1;
            textBox2.Text = Convert.ToString(b);
            if (textBox2.Text == Convert.ToString(0))//eğer textbox 0 ise buton 3 yi kapat.

            {
                button3.Enabled = false;
            }

        }
    }
}
