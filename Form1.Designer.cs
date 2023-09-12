namespace Formative_assessment_07
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
            imageList1 = new ImageList(components);
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            textBox6 = new TextBox();
            textBox7 = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth8Bit;
            imageList1.ImageSize = new Size(16, 16);
            imageList1.TransparentColor = Color.Transparent;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(27, 65);
            textBox1.Margin = new Padding(1, 1, 1, 1);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(107, 23);
            textBox1.TabIndex = 0;
            textBox1.TextChanged += textBox1_TextChanged_1;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(27, 113);
            textBox2.Margin = new Padding(1, 1, 1, 1);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(107, 23);
            textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(27, 157);
            textBox3.Margin = new Padding(1, 1, 1, 1);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(107, 23);
            textBox3.TabIndex = 2;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(27, 201);
            textBox4.Margin = new Padding(1, 1, 1, 1);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(107, 23);
            textBox4.TabIndex = 3;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(27, 246);
            textBox5.Margin = new Padding(1, 1, 1, 1);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(107, 23);
            textBox5.TabIndex = 4;
            // 
            // button1
            // 
            button1.Location = new Point(268, 65);
            button1.Margin = new Padding(1, 1, 1, 1);
            button1.Name = "button1";
            button1.Size = new Size(79, 21);
            button1.TabIndex = 5;
            button1.Text = "Sum";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(268, 113);
            button2.Margin = new Padding(1, 1, 1, 1);
            button2.Name = "button2";
            button2.Size = new Size(79, 21);
            button2.TabIndex = 6;
            button2.Text = "Average";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(384, 67);
            textBox6.Margin = new Padding(1, 1, 1, 1);
            textBox6.Name = "textBox6";
            textBox6.ReadOnly = true;
            textBox6.Size = new Size(107, 23);
            textBox6.TabIndex = 7;
            textBox6.TextChanged += textBox6_TextChanged;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(384, 115);
            textBox7.Margin = new Padding(1, 1, 1, 1);
            textBox7.Name = "textBox7";
            textBox7.ReadOnly = true;
            textBox7.Size = new Size(107, 23);
            textBox7.TabIndex = 8;
            textBox7.TextChanged += textBox7_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 21);
            label1.Margin = new Padding(1, 0, 1, 0);
            label1.Name = "label1";
            label1.Size = new Size(145, 15);
            label1.TabIndex = 9;
            label1.Text = "Please enter five numbers:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(586, 312);
            Controls.Add(label1);
            Controls.Add(textBox7);
            Controls.Add(textBox6);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Margin = new Padding(1, 1, 1, 1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ImageList imageList1;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private Button button1;
        private Button button2;
        private TextBox textBox6;
        private TextBox textBox7;
        private Label label1;
    }
}