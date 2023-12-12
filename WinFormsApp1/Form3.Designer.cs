namespace WinFormsApp1
{
    partial class Form3
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
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            panel5 = new Panel();
            label5 = new Label();
            label6 = new Label();
            button1 = new Button();
            label7 = new Label();
            linkLabel2 = new LinkLabel();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Script MT Bold", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ImageAlign = ContentAlignment.TopLeft;
            label1.Location = new Point(324, 7);
            label1.Name = "label1";
            label1.Size = new Size(65, 38);
            label1.TabIndex = 2;
            label1.Text = "HO";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("PMingLiU-ExtB", 48F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(-2, 86);
            label2.Name = "label2";
            label2.Size = new Size(131, 64);
            label2.TabIndex = 3;
            label2.Text = "HI !";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("PMingLiU-ExtB", 48F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(-2, 146);
            label3.Name = "label3";
            label3.Size = new Size(239, 64);
            label3.TabIndex = 4;
            label3.Text = "Stranger";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.LightGray;
            label4.Font = new Font("PMingLiU-ExtB", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.DimGray;
            label4.Location = new Point(20, 214);
            label4.Name = "label4";
            label4.Size = new Size(179, 16);
            label4.TabIndex = 5;
            label4.Text = "Let's Create an Account";
            // 
            // panel1
            // 
            panel1.BackColor = Color.DimGray;
            panel1.Location = new Point(20, 284);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(365, 1);
            panel1.TabIndex = 8;
            // 
            // panel2
            // 
            panel2.BackColor = Color.DimGray;
            panel2.Location = new Point(20, 314);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(365, 1);
            panel2.TabIndex = 9;
            // 
            // panel3
            // 
            panel3.BackColor = Color.DimGray;
            panel3.Location = new Point(20, 350);
            panel3.Margin = new Padding(3, 2, 3, 2);
            panel3.Name = "panel3";
            panel3.Size = new Size(365, 1);
            panel3.TabIndex = 10;
            // 
            // panel4
            // 
            panel4.BackColor = Color.DimGray;
            panel4.Location = new Point(20, 383);
            panel4.Margin = new Padding(3, 2, 3, 2);
            panel4.Name = "panel4";
            panel4.Size = new Size(365, 1);
            panel4.TabIndex = 11;
            // 
            // panel5
            // 
            panel5.BackColor = Color.DimGray;
            panel5.Location = new Point(20, 424);
            panel5.Margin = new Padding(3, 2, 3, 2);
            panel5.Name = "panel5";
            panel5.Size = new Size(365, 1);
            panel5.TabIndex = 12;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.LightGray;
            label5.Font = new Font("PMingLiU-ExtB", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.DimGray;
            label5.Location = new Point(20, 386);
            label5.Name = "label5";
            label5.Size = new Size(211, 16);
            label5.TabIndex = 13;
            label5.Text = "Contain at least 6 characters";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.LightGray;
            label6.Font = new Font("PMingLiU-ExtB", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.DimGray;
            label6.Location = new Point(20, 428);
            label6.Name = "label6";
            label6.Size = new Size(211, 16);
            label6.TabIndex = 14;
            label6.Text = "Contain at least 6 characters";
            // 
            // button1
            // 
            button1.BackColor = Color.Black;
            button1.BackgroundImageLayout = ImageLayout.None;
            button1.Font = new Font("Rockwell", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ButtonFace;
            button1.Location = new Point(10, 492);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(383, 38);
            button1.TabIndex = 15;
            button1.Text = "Forgot Password";
            button1.UseVisualStyleBackColor = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Rockwell", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label7.ForeColor = Color.DimGray;
            label7.Location = new Point(40, 564);
            label7.Name = "label7";
            label7.Size = new Size(149, 20);
            label7.TabIndex = 16;
            label7.Text = "Have an Account ?";
            // 
            // linkLabel2
            // 
            linkLabel2.AutoSize = true;
            linkLabel2.Font = new Font("Rockwell", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            linkLabel2.LinkColor = Color.Black;
            linkLabel2.Location = new Point(228, 559);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(79, 28);
            linkLabel2.TabIndex = 17;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "Log In";
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            ClientSize = new Size(404, 562);
            Controls.Add(linkLabel2);
            Controls.Add(label7);
            Controls.Add(button1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form3";
            Text = "Form3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
        private Label label5;
        private Label label6;
        private Button button1;
        private Label label7;
        private LinkLabel linkLabel2;
    }
}