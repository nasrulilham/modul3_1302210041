namespace modul3_1302210041
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int a, b, c;
        private void button1_Click(object sender, EventArgs e)
        {
            int num = 1;
            label1.Text = num.ToString();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            int num = 2;
            label1.Text = num.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int num = 3;
            label1.Text = num.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int num = 4;
            label1.Text = num.ToString();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            a = int.Parse(label1.Text);
            label1.Text+= " ";
        }

        private void Button_5_Click(object sender, EventArgs e)
        {
            int num = 5;
            label1.Text = num.ToString();
        }

        private void Button_6_Click(object sender, EventArgs e)
        {
            int num = 6;
            label1.Text = num.ToString();
        }

        private void Button_7_Click(object sender, EventArgs e)
        {
            int num = 7;
            label1.Text = num.ToString();
        }

        private void Button_8_Click(object sender, EventArgs e)
        {
            int num = 8;
            label1.Text = num.ToString();
        }

        private void Button_9_Click(object sender, EventArgs e)
        {
            int num = 9;
            label1.Text = num.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Button_0_Click(object sender, EventArgs e)
        {
            int num = 0;
            label1.Text = num.ToString();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            b = int.Parse(label1.Text);
            c = a + b;
            label1.Text = c.ToString();
        }
    }
}