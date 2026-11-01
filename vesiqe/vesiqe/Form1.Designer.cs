namespace vesiqe
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
            groupBox1 = new GroupBox();
            button1 = new Button();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            groupBox2 = new GroupBox();
            textBox12 = new TextBox();
            textBox11 = new TextBox();
            textBox10 = new TextBox();
            textBox9 = new TextBox();
            textBox8 = new TextBox();
            textBox7 = new TextBox();
            textBox6 = new TextBox();
            textBox5 = new TextBox();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label13 = new Label();
            label12 = new Label();
            button2 = new Button();
            button3 = new Button();
            progressBar1 = new ProgressBar();
            timer1 = new System.Windows.Forms.Timer(components);
            groupBox1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(panel1);
            groupBox1.Location = new Point(12, 24);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(391, 451);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Şəxsiyyət vəsiqəsi";
            // 
            // button1
            // 
            button1.BackColor = Color.LightGray;
            button1.Location = new Point(19, 392);
            button1.Name = "button1";
            button1.Size = new Size(342, 47);
            button1.TabIndex = 1;
            button1.Text = "Şəkil yüklə...";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.AliceBlue;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(19, 37);
            panel1.Name = "panel1";
            panel1.Size = new Size(342, 326);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Image = Properties.Resources.Gemini_Generated_Image_tm8dzatm8dzatm8d;
            pictureBox1.Location = new Point(-20, -1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(366, 326);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 37);
            label1.Name = "label1";
            label1.Size = new Size(118, 20);
            label1.TabIndex = 0;
            label1.Text = "Seriya və nömrə:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 71);
            label2.Name = "label2";
            label2.Size = new Size(63, 20);
            label2.TabIndex = 1;
            label2.Text = "FİN kod:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(18, 105);
            label3.Name = "label3";
            label3.Size = new Size(53, 20);
            label3.TabIndex = 2;
            label3.Text = "Soyad:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(18, 139);
            label4.Name = "label4";
            label4.Size = new Size(31, 20);
            label4.TabIndex = 3;
            label4.Text = "Ad:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(18, 173);
            label5.Name = "label5";
            label5.Size = new Size(60, 20);
            label5.TabIndex = 4;
            label5.Text = "Ata adı:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(18, 209);
            label6.Name = "label6";
            label6.Size = new Size(39, 20);
            label6.TabIndex = 5;
            label6.Text = "Cins:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(17, 241);
            label7.Name = "label7";
            label7.Size = new Size(100, 20);
            label7.TabIndex = 6;
            label7.Text = "Doğum tarihi:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(18, 276);
            label8.Name = "label8";
            label8.Size = new Size(90, 20);
            label8.TabIndex = 7;
            label8.Text = "Doğum yeri:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(17, 308);
            label9.Name = "label9";
            label9.Size = new Size(99, 20);
            label9.TabIndex = 8;
            label9.Text = "Ailə vəziyyəti:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(16, 340);
            label10.Name = "label10";
            label10.Size = new Size(100, 20);
            label10.TabIndex = 9;
            label10.Text = "Verilmə tarihi:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(204, 319);
            label11.Name = "label11";
            label11.Size = new Size(0, 20);
            label11.TabIndex = 10;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(textBox12);
            groupBox2.Controls.Add(textBox11);
            groupBox2.Controls.Add(textBox10);
            groupBox2.Controls.Add(textBox9);
            groupBox2.Controls.Add(textBox8);
            groupBox2.Controls.Add(textBox7);
            groupBox2.Controls.Add(textBox6);
            groupBox2.Controls.Add(textBox5);
            groupBox2.Controls.Add(textBox4);
            groupBox2.Controls.Add(textBox3);
            groupBox2.Controls.Add(textBox2);
            groupBox2.Controls.Add(textBox1);
            groupBox2.Controls.Add(label13);
            groupBox2.Controls.Add(label12);
            groupBox2.Controls.Add(label11);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label1);
            groupBox2.Location = new Point(423, 24);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(391, 451);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Vəsiqə məlumatları";
            // 
            // textBox12
            // 
            textBox12.Location = new Point(156, 412);
            textBox12.Name = "textBox12";
            textBox12.Size = new Size(228, 27);
            textBox12.TabIndex = 24;
            // 
            // textBox11
            // 
            textBox11.Location = new Point(156, 377);
            textBox11.Name = "textBox11";
            textBox11.Size = new Size(228, 27);
            textBox11.TabIndex = 23;
            // 
            // textBox10
            // 
            textBox10.Location = new Point(156, 340);
            textBox10.Name = "textBox10";
            textBox10.Size = new Size(228, 27);
            textBox10.TabIndex = 22;
            // 
            // textBox9
            // 
            textBox9.Location = new Point(156, 305);
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(228, 27);
            textBox9.TabIndex = 21;
            // 
            // textBox8
            // 
            textBox8.Location = new Point(156, 269);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(228, 27);
            textBox8.TabIndex = 20;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(156, 234);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(228, 27);
            textBox7.TabIndex = 19;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(156, 202);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(228, 27);
            textBox6.TabIndex = 18;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(156, 166);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(228, 27);
            textBox5.TabIndex = 17;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(156, 132);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(228, 27);
            textBox4.TabIndex = 16;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(156, 96);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(228, 27);
            textBox3.TabIndex = 15;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(156, 63);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(228, 27);
            textBox2.TabIndex = 14;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(156, 30);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(228, 27);
            textBox1.TabIndex = 13;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(18, 412);
            label13.Name = "label13";
            label13.Size = new Size(92, 20);
            label13.TabIndex = 12;
            label13.Text = "Verən orqan:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(18, 377);
            label12.Name = "label12";
            label12.Size = new Size(77, 20);
            label12.TabIndex = 11;
            label12.Text = "Etibarlıdır:";
            // 
            // button2
            // 
            button2.BackColor = Color.LightGray;
            button2.Location = new Point(564, 491);
            button2.Name = "button2";
            button2.Size = new Size(120, 44);
            button2.TabIndex = 2;
            button2.Text = "Təmizlə";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.LightGray;
            button3.Location = new Point(690, 491);
            button3.Name = "button3";
            button3.Size = new Size(124, 44);
            button3.TabIndex = 3;
            button3.Text = "Yadda saxla";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(423, 491);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(125, 43);
            progressBar1.TabIndex = 4;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(826, 546);
            Controls.Add(progressBar1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Azərbaycan Şəxsiyyət Vəsiqəsi";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private GroupBox groupBox2;
        private Button button1;
        private Label label13;
        private Label label12;
        private TextBox textBox12;
        private TextBox textBox11;
        private TextBox textBox10;
        private TextBox textBox9;
        private TextBox textBox8;
        private TextBox textBox7;
        private TextBox textBox6;
        private TextBox textBox5;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Button button2;
        private Button button3;
        private ProgressBar progressBar1;
        private System.Windows.Forms.Timer timer1;
    }
}
