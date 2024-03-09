namespace Lab2Ex1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public string user = string.Empty;


        private void button1_Click(object sender, EventArgs e)
        {
            StreamReader streamReader = new StreamReader(path: "fisier1.txt");
            {
                string line = string.Empty;
                string pw = string.Empty;

                while ((line = streamReader.ReadLine()) != null)
                {
                    string[] tempArray = line.Split(' ');
                    user = tempArray[0];
                    pw = tempArray[1];
                }
                if (textBox1.Text == user && pw == textBox2.Text)
                {
                    Form2 seconForm = new Form2();
                    seconForm.Show();
                }


            }
        }
    }
}
