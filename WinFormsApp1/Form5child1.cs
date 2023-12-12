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
    public partial class Form5child1 : Form
    {
        public Form5child1()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            label4 = new Label();
            button2 = new Button();
            button3 = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(144, 24);
            label4.Name = "label4";
            label4.Size = new Size(218, 28);
            label4.TabIndex = 7;
            label4.Text = "Action For the Proposal";
            // 
            // button2
            // 
            button2.Font = new Font("PMingLiU-ExtB", 15F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            button2.Location = new Point(213, 95);
            button2.Name = "button2";
            button2.Size = new Size(86, 31);
            button2.TabIndex = 9;
            button2.Text = "Accept";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Font = new Font("PMingLiU-ExtB", 15F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            button3.Location = new Point(344, 95);
            button3.Name = "button3";
            button3.Size = new Size(86, 31);
            button3.TabIndex = 10;
            button3.Text = "report";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button1
            // 
            button1.Font = new Font("PMingLiU-ExtB", 15F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            button1.Location = new Point(72, 95);
            button1.Name = "button1";
            button1.Size = new Size(86, 31);
            button1.TabIndex = 8;
            button1.Text = "Decline";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form5child1
            // 
            ClientSize = new Size(494, 181);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label4);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Form5child1";
            ResumeLayout(false);
            PerformLayout();
        }

        private Label label4;
        private Button button2;
        private Button button1;
        private Button button3;

        private void button1_Click(object sender, EventArgs e)
        {
            new Form5().Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new Form5().Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new Form5().Show();
            this.Hide();
        }
    }
}
