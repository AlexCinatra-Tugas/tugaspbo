namespace WinFormsApp1
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            panel1 = new Panel();
            button1 = new Button();
            label6 = new Label();
            linkLabel2 = new LinkLabel();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Script MT Bold", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ImageAlign = ContentAlignment.TopLeft;
            label1.Location = new Point(316, 15);
            label1.Name = "label1";
            label1.Size = new Size(65, 38);
            label1.TabIndex = 1;
            label1.Text = "HO";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("PMingLiU-ExtB", 48F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(3, 104);
            label2.Name = "label2";
            label2.Size = new Size(219, 64);
            label2.TabIndex = 2;
            label2.Text = "Oh,no !";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("PMingLiU-ExtB", 48F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(10, 171);
            label3.Name = "label3";
            label3.Size = new Size(232, 64);
            label3.TabIndex = 3;
            label3.Text = "I Forgot";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.LightGray;
            label4.Font = new Font("PMingLiU-ExtB", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label4.ForeColor = Color.DimGray;
            label4.Location = new Point(10, 239);
            label4.Name = "label4";
            label4.Size = new Size(349, 16);
            label4.TabIndex = 4;
            label4.Text = "Enter your email,phone, or username and we'll ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.LightGray;
            label5.Font = new Font("PMingLiU-ExtB", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label5.ForeColor = Color.DimGray;
            label5.Location = new Point(10, 254);
            label5.Name = "label5";
            label5.Size = new Size(312, 16);
            label5.TabIndex = 5;
            label5.Text = "send you a link to change a new password";
            // 
            // panel1
            // 
            panel1.BackColor = Color.DimGray;
            panel1.Location = new Point(10, 383);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(365, 1);
            panel1.TabIndex = 7;
            // 
            // button1
            // 
            button1.BackColor = Color.Black;
            button1.BackgroundImageLayout = ImageLayout.None;
            button1.Font = new Font("Rockwell", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ButtonFace;
            button1.Location = new Point(3, 404);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(383, 38);
            button1.TabIndex = 11;
            button1.Text = "Forgot Password";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Rockwell", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label6.ForeColor = Color.DimGray;
            label6.Location = new Point(10, 536);
            label6.Name = "label6";
            label6.Size = new Size(195, 20);
            label6.TabIndex = 15;
            label6.Text = "Don't have an account ? ";
            // 
            // linkLabel2
            // 
            linkLabel2.AutoSize = true;
            linkLabel2.Font = new Font("Rockwell", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            linkLabel2.LinkColor = Color.Black;
            linkLabel2.Location = new Point(262, 530);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(91, 28);
            linkLabel2.TabIndex = 16;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "Sign Up";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            ClientSize = new Size(404, 570);
            Controls.Add(linkLabel2);
            Controls.Add(label6);
            Controls.Add(button1);
            Controls.Add(panel1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Panel panel1;
        private Button button1;
        private Label label6;
        public LinkLabel linkLabel2;
    }
}