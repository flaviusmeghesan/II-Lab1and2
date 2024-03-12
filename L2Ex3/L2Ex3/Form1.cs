namespace L2Ex3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public float getNr1()
        {
            return float.Parse(number1.Text);
        }
        public float getNr2()
        {
            return float.Parse(number2.Text);
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            float nr1 = getNr1();
            float nr2 = getNr2();
            float res = nr1 - nr2;
            result.Text = res.ToString();

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            float nr1 = getNr1();
            float nr2 = getNr2();
            float res = nr1 + nr2;
            result.Text = res.ToString();
        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            float nr1 = getNr1();
            float nr2 = getNr2();
            float res = nr1 / nr2;
            result.Text = res.ToString();

        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            float nr1 = getNr1();
            float nr2 = getNr2();
            float res = nr1 * nr2;
            result.Text = res.ToString();

        }
    }
}
