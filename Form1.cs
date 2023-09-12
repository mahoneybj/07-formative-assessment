namespace Formative_assessment_07
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox6_TextChanged(sender, e);
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            int num1 = Convert.ToInt32(textBox1.Text);
            int num2 = Convert.ToInt32(textBox2.Text);
            int num3 = Convert.ToInt32(textBox3.Text);
            int num4 = Convert.ToInt32(textBox4.Text);
            int num5 = Convert.ToInt32(textBox5.Text);
            int total = num1 + num2 + num3 + num4 + num5;
            string num = Convert.ToString(total);

            textBox6.Text = num;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox7_TextChanged(sender, e);

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            int num1 = Convert.ToInt32(textBox1.Text);
            int num2 = Convert.ToInt32(textBox2.Text);
            int num3 = Convert.ToInt32(textBox3.Text);
            int num4 = Convert.ToInt32(textBox4.Text);
            int num5 = Convert.ToInt32(textBox5.Text);
            double total = num1 + num2 + num3 + num4 + num5;
            string num = Convert.ToString(total/5);
            textBox7.Text = num;
        }
    }
}