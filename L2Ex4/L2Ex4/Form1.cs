using System.Drawing;
namespace L2Ex4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listBox1.Items.Add("BMW");
            listBox1.Items.Add("Mercedes");
            listBox1.Items.Add("Audi");

        }



        private void pictureBox1_Click(object sender, EventArgs e) { }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int targetWidth = 128;
            int targetHeight = 128;

            Image originalBMW = Image.FromFile("BMW_Logo.png");
            Image originalAUDI = Image.FromFile("Audi.jpg");
            Image originalMERTEDES = Image.FromFile("Mert.png");

            Image bmw = ResizeImage(originalBMW, targetWidth, targetHeight);
            Image audi = ResizeImage(originalAUDI, targetWidth, targetHeight);
            Image mert = ResizeImage(originalMERTEDES, targetWidth, targetHeight);


            if (listBox1.SelectedItem.ToString() == "BMW")

                pictureBox1.Image = bmw;

            else if (listBox1.SelectedItem.ToString() == "Audi")
                pictureBox1.Image = audi;

            else if (listBox1.SelectedItem.ToString() == "Mercedes")
                pictureBox1.Image = mert;



        }


        static Image ResizeImage(Image originalImage, int targetWidth, int targetHeight)
        {
            Bitmap resizedBitmap = new Bitmap(targetWidth, targetHeight);
            using (Graphics g = Graphics.FromImage(resizedBitmap))
            {
                g.DrawImage(originalImage, 0, 0, targetWidth, targetHeight);
            }
            return resizedBitmap;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (regina.Checked == true)
            {
                MessageBox.Show("kingdom");
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (holongar.Checked == true)
            {
                MessageBox.Show("worker");
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (rege.Checked == true)
            {
                MessageBox.Show("Kingdom");
            }
        }

        private void holongar_CheckedChanged(object sender, EventArgs e)
        {
            if (salahor.Checked)
                MessageBox.Show("worker");
        }
    }
}
