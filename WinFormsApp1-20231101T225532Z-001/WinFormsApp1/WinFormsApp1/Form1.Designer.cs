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
            components = new System.ComponentModel.Container();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            button18 = new Button();
            button12 = new Button();
            button10 = new Button();
            button9 = new Button();
            button8 = new Button();
            button7 = new Button();
            button6 = new Button();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            label1 = new Label();
            textBox1 = new TextBox();
            contextMenuStrip1 = new ContextMenuStrip(components);
            button11 = new Button();
            textBox2 = new TextBox();
            button13 = new Button();
            button14 = new Button();
            button15 = new Button();
            button16 = new Button();
            button17 = new Button();
            button19 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.vending_machine;
            pictureBox1.Location = new Point(37, -2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(908, 735);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(button18);
            panel1.Controls.Add(button12);
            panel1.Controls.Add(button10);
            panel1.Controls.Add(button9);
            panel1.Controls.Add(button8);
            panel1.Controls.Add(button7);
            panel1.Controls.Add(button6);
            panel1.Controls.Add(button5);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Location = new Point(777, 351);
            panel1.Name = "panel1";
            panel1.Size = new Size(108, 162);
            panel1.TabIndex = 1;
            panel1.Paint += panel1_Paint;
            // 
            // button18
            // 
            button18.BackColor = Color.Red;
            button18.Location = new Point(3, 136);
            button18.Name = "button18";
            button18.Size = new Size(28, 23);
            button18.TabIndex = 14;
            button18.UseVisualStyleBackColor = false;
            button18.Click += button18_Click;
            // 
            // button12
            // 
            button12.BackColor = Color.Lime;
            button12.Location = new Point(70, 136);
            button12.Name = "button12";
            button12.Size = new Size(27, 23);
            button12.TabIndex = 9;
            button12.UseVisualStyleBackColor = false;
            button12.Click += button12_Click;
            // 
            // button10
            // 
            button10.Location = new Point(37, 106);
            button10.Name = "button10";
            button10.Size = new Size(27, 27);
            button10.TabIndex = 9;
            button10.Text = "0";
            button10.UseVisualStyleBackColor = true;
            button10.Click += button10_Click;
            // 
            // button9
            // 
            button9.Location = new Point(70, 73);
            button9.Name = "button9";
            button9.Size = new Size(27, 27);
            button9.TabIndex = 8;
            button9.Text = "9";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click;
            // 
            // button8
            // 
            button8.Location = new Point(37, 73);
            button8.Name = "button8";
            button8.Size = new Size(27, 27);
            button8.TabIndex = 7;
            button8.Text = "8";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // button7
            // 
            button7.Location = new Point(4, 73);
            button7.Name = "button7";
            button7.Size = new Size(27, 27);
            button7.TabIndex = 6;
            button7.Text = "7";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button6
            // 
            button6.Location = new Point(70, 40);
            button6.Name = "button6";
            button6.Size = new Size(27, 27);
            button6.TabIndex = 5;
            button6.Text = "6";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button5
            // 
            button5.Location = new Point(37, 40);
            button5.Name = "button5";
            button5.Size = new Size(27, 27);
            button5.TabIndex = 4;
            button5.Text = "5";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button4
            // 
            button4.Location = new Point(4, 40);
            button4.Name = "button4";
            button4.Size = new Size(27, 27);
            button4.TabIndex = 3;
            button4.Text = "4";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.Location = new Point(70, 7);
            button3.Name = "button3";
            button3.Size = new Size(27, 27);
            button3.TabIndex = 2;
            button3.Text = "3";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Location = new Point(37, 7);
            button2.Name = "button2";
            button2.Size = new Size(27, 27);
            button2.TabIndex = 1;
            button2.Text = "2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(4, 7);
            button1.Name = "button1";
            button1.Size = new Size(27, 27);
            button1.TabIndex = 0;
            button1.Text = "1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("MS PGothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(784, 516);
            label1.MaximumSize = new Size(100, 100);
            label1.Name = "label1";
            label1.Size = new Size(0, 21);
            label1.TabIndex = 2;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(790, 532);
            textBox1.MaxLength = 3;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(76, 34);
            textBox1.TabIndex = 3;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // button11
            // 
            button11.BackgroundImage = Properties.Resources.coin;
            button11.BackgroundImageLayout = ImageLayout.Zoom;
            button11.Location = new Point(37, 739);
            button11.Name = "button11";
            button11.Size = new Size(121, 108);
            button11.TabIndex = 7;
            button11.UseVisualStyleBackColor = true;
            button11.Click += button11_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(790, 584);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(76, 60);
            textBox2.TabIndex = 8;
            textBox2.TextChanged += textBox2_TextChanged_1;
            // 
            // button13
            // 
            button13.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            button13.BackgroundImage = Properties.Resources.pound;
            button13.BackgroundImageLayout = ImageLayout.Zoom;
            button13.Location = new Point(164, 739);
            button13.Name = "button13";
            button13.Size = new Size(121, 108);
            button13.TabIndex = 9;
            button13.UseVisualStyleBackColor = true;
            button13.Click += button13_Click;
            // 
            // button14
            // 
            button14.BackgroundImage = Properties.Resources._50;
            button14.BackgroundImageLayout = ImageLayout.Zoom;
            button14.Location = new Point(291, 739);
            button14.Name = "button14";
            button14.Size = new Size(121, 108);
            button14.TabIndex = 10;
            button14.UseVisualStyleBackColor = true;
            button14.Click += button14_Click;
            // 
            // button15
            // 
            button15.BackgroundImage = Properties.Resources._20p;
            button15.BackgroundImageLayout = ImageLayout.Zoom;
            button15.Location = new Point(418, 739);
            button15.Name = "button15";
            button15.Size = new Size(121, 108);
            button15.TabIndex = 11;
            button15.UseVisualStyleBackColor = true;
            button15.Click += button15_Click;
            // 
            // button16
            // 
            button16.BackgroundImage = Properties.Resources._10p;
            button16.BackgroundImageLayout = ImageLayout.Zoom;
            button16.Location = new Point(545, 739);
            button16.Name = "button16";
            button16.Size = new Size(121, 108);
            button16.TabIndex = 12;
            button16.UseVisualStyleBackColor = true;
            button16.Click += button16_Click;
            // 
            // button17
            // 
            button17.BackgroundImage = Properties.Resources._5p;
            button17.BackgroundImageLayout = ImageLayout.Zoom;
            button17.Location = new Point(672, 739);
            button17.Name = "button17";
            button17.Size = new Size(121, 108);
            button17.TabIndex = 13;
            button17.UseVisualStyleBackColor = true;
            button17.Click += button17_Click;
            // 
            // button19
            // 
            button19.BackColor = Color.Cyan;
            button19.Location = new Point(872, 584);
            button19.Name = "button19";
            button19.Size = new Size(20, 23);
            button19.TabIndex = 15;
            button19.UseVisualStyleBackColor = false;
            button19.Click += button19_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1039, 847);
            Controls.Add(button19);
            Controls.Add(button17);
            Controls.Add(button16);
            Controls.Add(button15);
            Controls.Add(button14);
            Controls.Add(button13);
            Controls.Add(textBox2);
            Controls.Add(button11);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Panel panel1;
        private Button button1;
        private Label label1;
        private Button button3;
        private Button button2;
        private Button button10;
        private Button button9;
        private Button button8;
        private Button button7;
        private Button button6;
        private Button button5;
        private Button button4;
        private TextBox textBox1;
        private Label label2;
        private ContextMenuStrip contextMenuStrip1;
        private Button button11;
        private TextBox textBox2;
        private Button button12;
        private Button button13;
        private Button button14;
        private Button button15;
        private Button button16;
        private Button button17;
        private Button button18;
        private Button button19;
    }
}