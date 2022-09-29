namespace BMI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            float KG;
            float SM;
            float BMI;
            KG = float.Parse(textBox1.Text);
            SM = float.Parse(textBox2.Text);
            BMI = KG / (SM * SM) * 10000;
            if (BMI < 18.5 )
            {
                label7.Text = BMI + " - Underweight";
            }
            else if (BMI > 18.5 && BMI < 24.9) 
            {
                label7.Text = BMI + " - Normal";
            }
            else if (BMI > 25 && BMI <29.9)
            {
                label7.Text = BMI + " - Overweight";
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}