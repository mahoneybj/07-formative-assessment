namespace Formative_assessment_07
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            textBox2.Text = string.Empty;

            double total = 0;

            if (radioButton1.Checked)
            {
                listBox1.Items.Add("Small pizza with:");
                total += 5;
            }
            else
            {
                listBox1.Items.Add("Large pizza with:");
                total += 10;
            }

            if (checkBox1.Checked) { total += 0.5; listBox1.Items.Add("Anchovies"); }
            if (checkBox2.Checked) { total += 1; listBox1.Items.Add("Extra cheese"); }
            if (checkBox3.Checked) { total += 0.75; listBox1.Items.Add("Olives"); }
            if (checkBox4.Checked) { total += 0.5; listBox1.Items.Add("Mushrooms"); }
            if (checkBox5.Checked) { total += 1.5; listBox1.Items.Add("Pepperoni"); }


            textBox2.Text = Convert.ToString(total);




        }


    }
}