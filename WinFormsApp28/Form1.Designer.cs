﻿namespace WinFormsApp28
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            History = new ListBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.Location = new Point(87, 265);
            button1.Name = "button1";
            button1.Size = new Size(96, 74);
            button1.TabIndex = 0;
            button1.Text = "Circle";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackgroundImage = Properties.Resources.download__4_;
            button2.Location = new Point(87, 124);
            button2.Name = "button2";
            button2.Size = new Size(96, 73);
            button2.TabIndex = 1;
            button2.Text = "Rectangle";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackgroundImage = (Image)resources.GetObject("button3.BackgroundImage");
            button3.Location = new Point(565, 169);
            button3.Name = "button3";
            button3.Size = new Size(96, 71);
            button3.TabIndex = 2;
            button3.Text = "Triangle";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackgroundImage = Properties.Resources.unnamed;
            button4.Location = new Point(677, 370);
            button4.Name = "button4";
            button4.Size = new Size(96, 58);
            button4.TabIndex = 3;
            button4.Text = "button4";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.WindowFrame;
            textBox1.ForeColor = SystemColors.MenuBar;
            textBox1.Location = new Point(69, 236);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(131, 23);
            textBox1.TabIndex = 4;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.BackColor = SystemColors.WindowFrame;
            textBox2.ForeColor = SystemColors.MenuBar;
            textBox2.Location = new Point(69, 95);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(131, 23);
            textBox2.TabIndex = 5;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // textBox3
            // 
            textBox3.BackColor = SystemColors.WindowFrame;
            textBox3.ForeColor = SystemColors.MenuBar;
            textBox3.Location = new Point(69, 35);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(131, 23);
            textBox3.TabIndex = 6;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // textBox4
            // 
            textBox4.BackColor = SystemColors.WindowFrame;
            textBox4.ForeColor = SystemColors.MenuBar;
            textBox4.Location = new Point(546, 140);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(131, 23);
            textBox4.TabIndex = 7;
            textBox4.TextChanged += textBox4_TextChanged;
            // 
            // textBox5
            // 
            textBox5.BackColor = SystemColors.WindowFrame;
            textBox5.ForeColor = SystemColors.MenuBar;
            textBox5.Location = new Point(546, 71);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(131, 23);
            textBox5.TabIndex = 8;
            textBox5.TextChanged += textBox5_TextChanged;
            // 
            // textBox6
            // 
            textBox6.BackColor = SystemColors.WindowFrame;
            textBox6.ForeColor = SystemColors.MenuBar;
            textBox6.Location = new Point(472, 404);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(172, 23);
            textBox6.TabIndex = 9;
            textBox6.TextChanged += textBox6_TextChanged;
            // 
            // History
            // 
            History.FormattingEnabled = true;
            History.ItemHeight = 15;
            History.Location = new Point(266, 61);
            History.Name = "History";
            History.Size = new Size(221, 259);
            History.TabIndex = 10;
            History.SelectedIndexChanged += History_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.GradientActiveCaption;
            label1.Location = new Point(69, 218);
            label1.Name = "label1";
            label1.Size = new Size(42, 15);
            label1.TabIndex = 11;
            label1.Text = "Raduis";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.GradientActiveCaption;
            label2.Location = new Point(69, 77);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 12;
            label2.Text = "Width";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.GradientActiveCaption;
            label3.Location = new Point(69, 17);
            label3.Name = "label3";
            label3.Size = new Size(44, 15);
            label3.TabIndex = 13;
            label3.Text = "Lenght";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.GradientActiveCaption;
            label4.Location = new Point(546, 53);
            label4.Name = "label4";
            label4.Size = new Size(44, 15);
            label4.TabIndex = 14;
            label4.Text = "Length";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.GradientActiveCaption;
            label5.Location = new Point(546, 122);
            label5.Name = "label5";
            label5.Size = new Size(43, 15);
            label5.TabIndex = 15;
            label5.Text = "Height";
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = SystemColors.GradientActiveCaption;
            label6.Location = new Point(472, 386);
            label6.Name = "label6";
            label6.Size = new Size(31, 15);
            label6.TabIndex = 16;
            label6.Text = "Area";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(800, 450);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(History);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private ListBox History;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
    }
}
