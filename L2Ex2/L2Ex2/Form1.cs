namespace L2Ex2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            StreamReader streamReader = new StreamReader(path: "input.txt");
            {
                string line;
                while ((line = streamReader.ReadLine()) != null)
                {
                    string[] tempArray = line.Split(' ');
                    listBox1.Items.Add(tempArray[0]);
                    listBox1.Items.Add(tempArray[1]);
                    listBox1.Items.Add(tempArray[2]);
                }

            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem.ToString() != "")
                listBox2.Items.Add(listBox1.SelectedItem.ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox2.Items.Remove(listBox2.SelectedItem);
        }
    }
}
