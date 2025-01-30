using System.Windows.Forms;

namespace WinFormsApp28
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private double CalculateArea(double length, double width)
        {
            return length * width;
        }

        private double CalculateArea(double radius)
        {
            return Math.PI * Math.Pow(radius, 2);
        }

        private double CalculateAreaTriangle(double baseLength, double height)
        {
            return (baseLength * height) / 2;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double radius = Convert.ToDouble(textBox1.Text);
                double area = CalculateArea(radius);
                string result = $"Circle: {area}";
                History.Items.Add(result);
                textBox6.Text = result;
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter a valid number for the radius.");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                double baselength = Convert.ToDouble(textBox5.Text);
                double height = Convert.ToDouble(textBox4.Text);
                double area = CalculateAreaTriangle(baselength, height);
                string result = $"Triangle: {area}";
                History.Items.Add(result);
                textBox6.Text = result;
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter valid numbers for base and height.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                double length = Convert.ToDouble(textBox3.Text);
                double width = Convert.ToDouble(textBox2.Text);
                double area = CalculateArea(length, width);
                string result = $"Rectangle: {area}";
                History.Items.Add(result);
                textBox6.Text = result;
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter valid numbers for length and width.");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            History.Items.Remove(History.Text);
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void History_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
