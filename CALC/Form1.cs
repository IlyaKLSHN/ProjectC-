using System.Data;

namespace CALC
{
    public partial class Calculate : Form
    {
        public Calculate()
        {
            InitializeComponent();
        }

        private void Calculate_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int Seat1 = Int16.Parse(textBox1.Text) * 15;
            textBox4.Text = Seat1.ToString() + " ˆ";

            int Seat2 = Int16.Parse(textBox2.Text) * 12;
            textBox5.Text = Seat2.ToString() + " ˆ";

            int Seat3 = Int16.Parse(textBox3.Text) * 9;
            textBox6.Text = Seat3.ToString() + " ˆ";

            int Total = Seat1 + Seat2 + Seat3;
            textBox7.Text = Total.ToString() + " ˆ";
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
        }
     
        

        private void button2_Click(object sender, EventArgs e)
        {
               this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            float Seat1;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            float Seat2;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            float Seat3;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }
    }
}