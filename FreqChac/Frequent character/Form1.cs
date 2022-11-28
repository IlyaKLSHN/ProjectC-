namespace Frequent_character
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
                    
            String str = textBox1.Text;
            int[] characterCount = new int[256];
            int length = str.Length;
            for (int i = 0; i < length; i++)
            {
                characterCount[str[i]]++;
            }
            int max_Count = -1;
            char character = ' ';
            for (int i = 0; i < length; i++)
            {
                if (max_Count < characterCount[str[i]])
                {
                    max_Count = characterCount[str[i]];
                    character = str[i];
                }
            }
            label2.Text = "Most Frequet Character - " + character;
            label3.Text = "It appears - " + max_Count + " times";
        
        }
    }
}