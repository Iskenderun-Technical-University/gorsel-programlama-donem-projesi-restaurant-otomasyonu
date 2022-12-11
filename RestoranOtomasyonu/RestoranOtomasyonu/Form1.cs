namespace RestoranOtomasyonu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

       

        private void button1_Click_1(object sender, EventArgs e)
        {
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            kullicibilgileri kullanicibilgilerisec = new kullicibilgileri();
            kullanicibilgilerisec.Show();
            this.Hide();
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();  //form 2 göster
            this.Hide();//form1 gizle
        }
    }
}