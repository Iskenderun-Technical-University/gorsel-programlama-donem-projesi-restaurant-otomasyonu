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
    public partial class SicakIcecekler : Form
    {
        public SicakIcecekler()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a; //alınacak serbetli tatli sayısı için a değeri tanımladık 

            a = Convert.ToInt32(textBox1.Text);//a integer değer text ise string değer olduğu için dönüşüm yaptık
            a = a + 1;
            textBox1.Text = Convert.ToString(a);
            if (Convert.ToInt32(textBox1.Text) > 0)//eğer textbox 0 dan büyükse buton 2 yi aktifleştir.

            {
                button2.Enabled = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int a; //alınacak serbetli tatli için a değeri tanımladık 

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
            int b; //alınacak sıcak içecek  için b değeri tanımladık 

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
            int b; //alınacak sıcak içecek için b değeri tanımladık 

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
            int c; //alınacak sıcak içecek sayısı için c değeri tanımladık 

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
            int c; //alınacak sıcak içecek sayısı için c değeri tanımladık 

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
            int d; //alınacak sıcak içecek sayısı için d değeri tanımladık 
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
            int d; //alınacak sıcak içecek sayısı için d değeri tanımladık 

            d = Convert.ToInt32(textBox4.Text);//d integer değer text ise string değer olduğu için dönüşüm yaptık
            d = d - 1;
            textBox4.Text = Convert.ToString(d);
            if (textBox4.Text == Convert.ToString(0))//eğer textbox 0 ise buton 7 yi kapat.

            {
                button7.Enabled = false;
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            int f; //alınacak sıcak içecek sayısı için f değeri tanımladık 

            f = Convert.ToInt32(textBox5.Text);//f integer değer text ise string değer olduğu için dönüşüm yaptık
            f = f + 1;
            textBox5.Text = Convert.ToString(f);
            if (textBox5.Text == Convert.ToString(0))//eğer textbox 0 ise buton 9 yi kapat.

            {
                button9.Enabled = false;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            int f; //alınacak sıcak içecek sayısı için f değeri tanımladık 

            f = Convert.ToInt32(textBox5.Text);//f integer değer text ise string değer olduğu için dönüşüm yaptık
            f = f - 1;
            textBox5.Text = Convert.ToString(f);
            if (textBox5.Text == Convert.ToString(0))//eğer textbox 0 ise buton 9 yi kapat.

            {
                button9.Enabled = false;
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            int g; //alınacak sıcak içecek sayısı için g değeri tanımladık 

            g = Convert.ToInt32(textBox6.Text);//g integer değer text ise string değer olduğu için dönüşüm yaptık
            g = g + 1;
            textBox6.Text = Convert.ToString(g);
            if (Convert.ToInt32(textBox6.Text) > 0)//eğer textbox 0 dan büyükse buton 11 yi aktifleştir.

            {
                button11.Enabled = true;
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            int g; //alınacak sıcak içecek sayısı için g değeri tanımladık 

            g = Convert.ToInt32(textBox6.Text);//ag integer değer text ise string değer olduğu için dönüşüm yaptık
            g = g - 1;
            textBox6.Text = Convert.ToString(g);
            if (textBox6.Text == Convert.ToString(0))//eğer textbox 0 ise buton 11 yi kapat.

            {
                button11.Enabled = false;
            }
        }
        public static int gidentoplam = 0;
        private void button13_Click(object sender, EventArgs e)
        {

            int TürkKahvesi,Espresso, CafeLatte, Cappucino, FiltreKahve,SıcakKahve;
            TürkKahvesi = 30;
            Espresso = 25;
            CafeLatte = 15;
            Cappucino = 20;
            FiltreKahve= 15;
            SıcakKahve = 12;
            



            if (textBox1.Text != Convert.ToString(0))
            {
                gidentoplam = gidentoplam + Convert.ToInt32(textBox1.Text) *TürkKahvesi;//Eğer sepete bir ürün eklenirse o ürünün ismini ve fiyatını siparişler kısmına gönderiyoruz

            }
            if (textBox2.Text != Convert.ToString(0))
            {
                gidentoplam = gidentoplam + Convert.ToInt32(textBox2.Text) *Espresso;

            }
            if (textBox3.Text != Convert.ToString(0))
            {
                gidentoplam = gidentoplam + Convert.ToInt32(textBox3.Text) * CafeLatte;

            }
            if (textBox4.Text != Convert.ToString(0))
            {
                gidentoplam = gidentoplam + Convert.ToInt32(textBox4.Text) *Cappucino;


            }
            if (textBox5.Text != Convert.ToString(0))
            {
                gidentoplam = gidentoplam + Convert.ToInt32(textBox5.Text) *FiltreKahve;

            }
            if (textBox6.Text != Convert.ToString(0))
            {
                gidentoplam = gidentoplam + Convert.ToInt32(textBox6.Text) * SıcakKahve;

            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
