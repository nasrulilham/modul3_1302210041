using System.Xml;

namespace modul3_1302210041
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label1.Text = "";
        }

        int angka;
        int hasil;
        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + "1";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }


        private void button4_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + "2";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + "3";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + "4";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            angka = int.Parse(label1.Text);
            hasil += angka;
            label1.Text = " ";
        }

        private void Button_5_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + "5";
        }

        private void Button_6_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + "6";
        }

        private void Button_7_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + "7";
        }

        private void Button_8_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + "8";
        }

        private void Button_9_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + "9";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Button_0_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + "0";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            angka = int.Parse(label1.Text);
            hasil += angka;
            label1.Text = hasil.ToString();
        }
    }
}