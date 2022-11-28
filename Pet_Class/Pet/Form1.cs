namespace Pet
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        class Pet
        {
            public string petname;
            public string pettype;
            public int petage;

            public Pet(string Name, string Type, int Age)
            {
                petname = Name;
                pettype = Type;
                petage = Age;
            }

        }
        private void button1_Click(object sender, EventArgs e)
        {
            Pet Pet1 = new Pet(textBox1.Text, textBox2.Text, Convert.ToInt16(textBox3.Text));
            
            textBox4.Text = "Name: "+ Pet1.petname + "\r\n" + "\r\nType: " + Pet1.pettype + "\r\nAge: " + Pet1.petage;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
    
}