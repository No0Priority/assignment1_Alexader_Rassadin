namespace assignment1_Alexader_Rassadin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            
            MessageBox.Show("Author: Alexander Rassadin");
            Thread.Sleep(1000);
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            label1.Text = "I AM FINE";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = !pictureBox1.Visible;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}