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
    public partial class Form4child1 : Form
    {
        public Form4child1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string CompName = textBox1.Text.ToString();
            string amt = textBox2.Text.ToString();
            string purpose = textBox3.Text.ToString();
            if (CompName != "" && amt != "" && purpose != "") {
                string msg = "the proposal has been on delivered" + CompName + amt + purpose;
                MessageBox.Show(msg);
                new Form4().Show();
                this.Hide();
            }
            else
            {
                string msg = "can be empty input";
                MessageBox.Show(msg);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string msg = "successfully reported";
            MessageBox.Show(msg);
            new Form4().Show();
            this.Hide();
        }
    }
}
