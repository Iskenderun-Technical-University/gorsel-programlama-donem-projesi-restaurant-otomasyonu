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
            int d ; //alınacak çorba sayısı için d değeri tanımladık 

            d = Convert.ToInt32(textBox5.Text);//d integer değer text ise string değer olduğu için dönüşüm yaptık
            d = d + 1;
            textBox5.Text = Convert.ToString(d);
            if (Convert.ToInt32(textBox5.Text) > 0)//eğer textbox 0 dan büyükse buton 9 yi aktifleştir.

            {
                button9.Enabled = true;
            }

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

        private void button6_Click(object sender, EventArgs e)
        {
            int c; //alınacak çorba sayısı için c değeri tanımladık 

            c = Convert.ToInt32(textBox3.Text);//c integer değer text ise string değer olduğu için dönüşüm yaptık
            c = c + 1;
            textBox3.Text = Convert.ToString(c);
            if (Convert.ToInt32(textBox3.Text) > 0)//eğer textbox 0 dan büyükse buton 5 yi aktifleştir.

            {
                button5.Enabled = true;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int c; //alınacak çorba sayısı için c değeri tanımladık 

            c = Convert.ToInt32(textBox3.Text);//c integer değer text ise string değer olduğu için dönüşüm yaptık
            c = c - 1;
            textBox3.Text = Convert.ToString(c);
            if (textBox3.Text == Convert.ToString(0))//eğer textbox 0 ise buton 5 yi kapat.

            {
                button5.Enabled = false;
            }

        }

        private void button8_Click(object sender, EventArgs e)
        {
            int d; //alınacak çorba sayısı için d değeri tanımladık 

            d = Convert.ToInt32(textBox4.Text);//d integer değer text ise string değer olduğu için dönüşüm yaptık
            d = d + 1;
            textBox4.Text = Convert.ToString(d);
            if (Convert.ToInt32(textBox4.Text) > 0)//eğer textbox 0 dan büyükse buton 7 yi aktifleştir.

            {
                button7.Enabled = true;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            int d; //alınacak çorba sayısı için d değeri tanımladık 

            d = Convert.ToInt32(textBox4.Text);//d integer değer text ise string değer olduğu için dönüşüm yaptık
            d = d - 1;
            textBox4.Text = Convert.ToString(d);
            if (textBox4.Text == Convert.ToString(0))//eğer textbox 0 ise buton 7 yi kapat.

            {
                button7.Enabled = false;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            int d; //alınacak çorba sayısı için  d değeri tanımladık 

            d = Convert.ToInt32(textBox5.Text);//d integer değer text ise string değer olduğu için dönüşüm yaptık
            d = d - 1;
            textBox5.Text = Convert.ToString(d);
            if (textBox5.Text == Convert.ToString(0))//eğer textbox 0 ise buton 9 yi kapat.

            {
                button9.Enabled = false;
            }

        }

        private void button12_Click(object sender, EventArgs e)
        {
            int f; //alınacak çorba sayısı için f değeri tanımladık 

            f = Convert.ToInt32(textBox4.Text);//f integer değer text ise string değer olduğu için dönüşüm yaptık
            f = f + 1;
            textBox6.Text = Convert.ToString(f);
            if (Convert.ToInt32(textBox6.Text) > 0)//eğer textbox 0 dan büyükse buton 11 yi aktifleştir.

            {
                button11.Enabled = true;
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            int f; //alınacak çorba sayısı için f değeri tanımladık 

            f = Convert.ToInt32(textBox6.Text);//f integer değer text ise string değer olduğu için dönüşüm yaptık
            f = f - 1;
            textBox6.Text = Convert.ToString(f);
            if (textBox6.Text == Convert.ToString(0))//eğer textbox 0 ise buton 11 yi kapat.

            {
                button11.Enabled = false;
            }

        }
    }
}
