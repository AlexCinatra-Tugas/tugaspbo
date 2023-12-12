using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void titleApp_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            new Form5child1().Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string CompName = getcompname.Text.ToString();
            string CompYear = getyear.Text.ToString();
            string amt = getamount.Text.ToString();

            if (CompName != "" && CompYear != "" && amt != "")
            {
                compname.Text = CompName;
                year.Text = CompYear;
                amount.Text = amt;

                getamount.Clear();
                getyear.Clear();
                getcompname.Clear();

                string msg = "data telah diubah";

                MessageBox.Show(msg);
            } else
            {
                string msg = "cannot be empty input";

                MessageBox.Show(msg);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
