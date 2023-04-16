namespace Kullanıcıdan_Alınan_Değer_vize_final_hesabı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {                                               // Buttona yapıyoruz çünkü hesaplama işi butonda
            double v1 = Convert.ToDouble(ortalama.Text);    // kullanıcıdan girilen değeri işleme alır 
            double v2 = Convert.ToDouble(vize.Text);
            double v3 = Convert.ToDouble(final.Text);

            double dsn = (v1*0.4)+(v2*0.6);
            if (dsn >= 90)
            {
                label4.Text = "A" +dsn.ToString();
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            if (vize.Text == "")
            {                                                    // boş geçilirse sıfır yazılıacak
                vize.Text = "0";

            }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (ortalama.Text == "")
            {                                                    // boş geçilirse sıfır yazılıacak
                ortalama.Text = "0";
            }

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (final.Text == "")
            {
                final.Text = "0";
            }
        }

        private void vize_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}