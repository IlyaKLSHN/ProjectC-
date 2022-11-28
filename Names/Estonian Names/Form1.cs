namespace Estonian_Names
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

        private void button1_Click(object sender, EventArgs e)
        {
            string[] boyn = File.ReadAllLines("C:\\Users\\ilyak\\Desktop\\boy names.txt");
            string[] girln = File.ReadAllLines("C:\\Users\\ilyak\\Desktop\\girl names.txt");
            string searchelement = textBox1.Text;
            bool exists = Array.Exists(boyn, element => element == searchelement);
            if (exists)
            {
                label2.Text = "Most popular name.";
            }
            else
            {
                bool exists2 = Array.Exists(girln, element => element == searchelement);
                if (exists2)
                {
                    label2.Text = "Most popular name.";
                }
                else
                {
                    label2.Text = "The name was not popular amongst female \n nor male names.";
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}