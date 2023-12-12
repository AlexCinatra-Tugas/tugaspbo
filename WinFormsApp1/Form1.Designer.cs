namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            panel1 = new Panel();
            panel2 = new Panel();
            checkBox1 = new CheckBox();
            button1 = new Button();
            linkLabel1 = new LinkLabel();
            label5 = new Label();
            linkLabel2 = new LinkLabel();
            txt_username = new TextBox();
            txt_password = new TextBox();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Script MT Bold", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ImageAlign = ContentAlignment.TopLeft;
            label1.Location = new Point(364, 9);
            label1.Name = "label1";
            label1.Size = new Size(65, 38);
            label1.TabIndex = 0;
            label1.Text = "HO";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("PMingLiU-ExtB", 48F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(12, 77);
            label2.Name = "label2";
            label2.Size = new Size(127, 64);
            label2.TabIndex = 1;
            label2.Text = "HI !";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("PMingLiU-ExtB", 48F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label3.Location = new Point(-2, 157);
            label3.Name = "label3";
            label3.Size = new Size(266, 64);
            label3.TabIndex = 2;
            label3.Text = "Welcome";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.LightGray;
            label4.Font = new Font("PMingLiU-ExtB", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.DimGray;
            label4.Location = new Point(24, 237);
            label4.Name = "label4";
            label4.Size = new Size(337, 16);
            label4.TabIndex = 3;
            label4.Text = "I'm waiting for you , please enter your details";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(23, 290);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(41, 39);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(23, 374);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(41, 35);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.DimGray;
            panel1.Location = new Point(23, 335);
            panel1.Name = "panel1";
            panel1.Size = new Size(417, 1);
            panel1.TabIndex = 6;
            // 
            // panel2
            // 
            panel2.BackColor = Color.DimGray;
            panel2.Location = new Point(23, 415);
            panel2.Name = "panel2";
            panel2.Size = new Size(417, 1);
            panel2.TabIndex = 7;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.BackColor = Color.LightGray;
            checkBox1.Font = new Font("Rockwell", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            checkBox1.ForeColor = Color.Gray;
            checkBox1.Location = new Point(23, 465);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(148, 24);
            checkBox1.TabIndex = 8;
            checkBox1.Text = "Remember Me ";
            checkBox1.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.Black;
            button1.BackgroundImageLayout = ImageLayout.None;
            button1.ForeColor = SystemColors.ButtonFace;
            button1.Location = new Point(11, 535);
            button1.Name = "button1";
            button1.Size = new Size(438, 50);
            button1.TabIndex = 10;
            button1.Text = "Log ln";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Rockwell", 12F, FontStyle.Bold, GraphicsUnit.Point);
            linkLabel1.LinkBehavior = LinkBehavior.NeverUnderline;
            linkLabel1.LinkColor = Color.Gray;
            linkLabel1.Location = new Point(260, 465);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(152, 19);
            linkLabel1.TabIndex = 13;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Forgot Password ?";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Rockwell", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label5.ForeColor = Color.DimGray;
            label5.Location = new Point(24, 761);
            label5.Name = "label5";
            label5.Size = new Size(195, 20);
            label5.TabIndex = 14;
            label5.Text = "Don't have an account ? ";
            label5.Click += label5_Click;
            // 
            // linkLabel2
            // 
            linkLabel2.AutoSize = true;
            linkLabel2.LinkColor = Color.Black;
            linkLabel2.Location = new Point(281, 754);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(91, 28);
            linkLabel2.TabIndex = 15;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "Sign Up";
            // 
            // txt_username
            // 
            txt_username.BackColor = Color.LightGray;
            txt_username.BorderStyle = BorderStyle.None;
            txt_username.Location = new Point(70, 290);
            txt_username.Name = "txt_username";
            txt_username.Size = new Size(359, 26);
            txt_username.TabIndex = 16;
            txt_username.TextChanged += textBox1_TextChanged;
            // 
            // txt_password
            // 
            txt_password.BackColor = Color.LightGray;
            txt_password.BorderStyle = BorderStyle.None;
            txt_password.Location = new Point(70, 374);
            txt_password.Name = "txt_password";
            txt_password.Size = new Size(359, 26);
            txt_password.TabIndex = 17;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(11, 498);
            label6.Name = "label6";
            label6.Size = new Size(65, 28);
            label6.TabIndex = 18;
            label6.Text = "clear";
            label6.Click += label6_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            ClientSize = new Size(462, 621);
            Controls.Add(label6);
            Controls.Add(txt_password);
            Controls.Add(txt_username);
            Controls.Add(linkLabel2);
            Controls.Add(label5);
            Controls.Add(linkLabel1);
            Controls.Add(button1);
            Controls.Add(checkBox1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Rockwell", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            ForeColor = SystemColors.ActiveCaptionText;
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(6, 5, 6, 5);
            Name = "Form1";
            Text = "P1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Panel panel1;
        private Panel panel2;
        private CheckBox checkBox1;
        private Button button1;
        private LinkLabel linkLabel1;
        private Label label5;
        private LinkLabel linkLabel2;
        private TextBox txt_username;
        private TextBox txt_password;
        private Label label6;
    }
}