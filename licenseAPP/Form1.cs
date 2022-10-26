namespace licenseAPP
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

        private void button1_Click(object sender, EventArgs e)
        {
            string[] text = File.ReadAllLines("C:\\Users\\IlyaK\\Desktop\\lolkek.txt");

            string[] givememaxpoints = { "b", "d", "a", "a", "c", "a", "b", "a", "c", "d", "b", "c", "d", "a", "d", "c", "c", "b", "d", "a" };

            int cifra = 0;

            int otveti = 0;

            foreach (string element in text)
            {
                if (element == text[cifra])
                {

                    otveti++;
                   
                }
                cifra++;
            }
            label2.Text = otveti.ToString();

            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}