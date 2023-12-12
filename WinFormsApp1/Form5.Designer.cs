namespace WinFormsApp1
{
    partial class Form5
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
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            checkedListBox1 = new CheckedListBox();
            button2 = new Button();
            SuspendLayout();
            // 
            // titleApp
            // 
            titleApp.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            titleApp.AutoSize = true;
            titleApp.Font = new Font("PMingLiU-ExtB", 48F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            titleApp.Location = new Point(306, 24);
            titleApp.Name = "titleApp";
            titleApp.Size = new Size(239, 64);
            titleApp.TabIndex = 1;
            titleApp.Text = "HO App";
            titleApp.TextAlign = ContentAlignment.TopCenter;
            titleApp.Click += titleApp_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("PMingLiU-ExtB", 15F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(52, 112);
            label1.Name = "label1";
            label1.Size = new Size(145, 20);
            label1.TabIndex = 2;
            label1.Text = "About Company";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("PMingLiU-ExtB", 15F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(483, 193);
            label2.Name = "label2";
            label2.Size = new Size(0, 20);
            label2.TabIndex = 3;
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // button1
            // 
            button1.Font = new Font("PMingLiU-ExtB", 15F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            button1.Location = new Point(483, 112);
            button1.Name = "button1";
            button1.Size = new Size(86, 31);
            button1.TabIndex = 4;
            button1.Text = "Edit";
            button1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(52, 170);
            label3.Name = "label3";
            label3.Size = new Size(98, 21);
            label3.TabIndex = 5;
            label3.Text = "Comp Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(52, 204);
            label4.Name = "label4";
            label4.Size = new Size(132, 21);
            label4.TabIndex = 6;
            label4.Text = "Amount Provided";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(52, 246);
            label5.Name = "label5";
            label5.Size = new Size(40, 21);
            label5.TabIndex = 7;
            label5.Text = "Year";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(483, 172);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(203, 23);
            textBox1.TabIndex = 11;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(483, 206);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(203, 23);
            textBox2.TabIndex = 12;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(483, 248);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(203, 23);
            textBox3.TabIndex = 13;
            // 
            // checkedListBox1
            // 
            checkedListBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Items.AddRange(new object[] { "data 1", "data 2", "data 3", "data 4", "data 5", "data 6", "data 7", "data 8", "data 9", "data 10", "data 11", "data 12", "data 13", "data 14", "data 15", "data 16", "data 17", "data 18", "data 19", "data 20" });
            checkedListBox1.Location = new Point(52, 292);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(722, 196);
            checkedListBox1.TabIndex = 14;
            // 
            // button2
            // 
            button2.Font = new Font("PMingLiU-ExtB", 15F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            button2.Location = new Point(52, 500);
            button2.Name = "button2";
            button2.Size = new Size(86, 31);
            button2.TabIndex = 15;
            button2.Text = "Action";
            button2.UseVisualStyleBackColor = true;
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(799, 535);
            Controls.Add(button2);
            Controls.Add(checkedListBox1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(titleApp);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Form5";
            Text = "Form5";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label titleApp;
        private Label label1;
        private Label label2;
        private Button button1;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private CheckedListBox checkedListBox1;
        private Button button2;
    }
}