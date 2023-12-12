namespace WinFormsApp1
{
    partial class Form4
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
            titleApp = new Label();
            button1 = new Button();
            label1 = new Label();
            checkedListBox1 = new CheckedListBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // titleApp
            // 
            titleApp.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            titleApp.AutoSize = true;
            titleApp.Font = new Font("PMingLiU-ExtB", 48F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            titleApp.Location = new Point(359, 27);
            titleApp.Name = "titleApp";
            titleApp.Size = new Size(239, 64);
            titleApp.TabIndex = 0;
            titleApp.Text = "HO App";
            titleApp.TextAlign = ContentAlignment.TopCenter;
            titleApp.Click += titleApp_Click;
            // 
            // button1
            // 
            button1.Font = new Font("PMingLiU-ExtB", 15F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            button1.Location = new Point(35, 142);
            button1.Name = "button1";
            button1.Size = new Size(117, 37);
            button1.TabIndex = 1;
            button1.Text = "action";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("PMingLiU-ExtB", 15F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(571, 150);
            label1.Name = "label1";
            label1.Size = new Size(147, 20);
            label1.TabIndex = 2;
            label1.Text = "Sponsorship List";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // checkedListBox1
            // 
            checkedListBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Items.AddRange(new object[] { "Item 1", "Item 2", "Item 3", "Item 4", "Item 5", "Item 6", "Item 7", "Item 8", "Item 9", "Item 10", "Item 11", "Item 12", "Item 13", "Item 14", "Item 15", "Item 16", "Item 17", "Item 18", "Item 19", "Item 20" });
            checkedListBox1.Location = new Point(571, 173);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(323, 316);
            checkedListBox1.TabIndex = 4;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.layla;
            pictureBox1.Location = new Point(35, 219);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(406, 270);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(931, 530);
            Controls.Add(pictureBox1);
            Controls.Add(checkedListBox1);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(titleApp);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Form4";
            Text = "Form4";
            Load += Form4_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label titleApp;
        private Button button1;
        private Label label1;
        private CheckedListBox checkedListBox1;
        private PictureBox pictureBox1;
    }
}