namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void Form1_Load(object sender, EventArgs e)
        {

        }

        public void fontDialog1_Apply(object sender, EventArgs e)
        {

        }

        public void label1_Click(object sender, EventArgs e)
        {

        }

        public void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        public void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        public void pictureBox1_Click_2(object sender, EventArgs e)
        {

        }

        public void label5_Click(object sender, EventArgs e)
        {

        }

        public void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        public void button1_Click(object sender, EventArgs e)
        {
            new Form5().Show();
            this.Hide();
            /*
            if (txt_username.Text == "your_user_name" && txt_password.Text == "your_password")
            {
                new Form4().Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("your information is invalid, try again!");
                txt_username.Clear();
                txt_password.Clear();
                txt_username.Focus();
            }
            */
        }

        public void label6_Click(object sender, EventArgs e)
        {
            txt_username.Clear();
            txt_password.Clear();
            txt_username.Focus();
        }
    }
}