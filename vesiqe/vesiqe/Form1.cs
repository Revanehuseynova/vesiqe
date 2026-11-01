namespace vesiqe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            progressBar1.Visible = false;
            progressBar1.Minimum = 0;
            progressBar1.Maximum = 100;
            progressBar1.Value = 0;
            timer1.Interval = 100; // Timer sürəti üçün təhlükəsizlik əlavəsi
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "PNG Files (*.png)|*.png";
            if (open.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(open.FileName);
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Bütün TextBox-ları təmizləmək üçün
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is TextBox)
                {
                    ctrl.Text = string.Empty;
                }
            }
            foreach (Control container in this.Controls)
            {
                if (container is GroupBox || container is Panel)
                {
                    foreach (Control subCtrl in container.Controls)
                    {
                        if (subCtrl is TextBox)
                        {
                            subCtrl.Text = string.Empty;
                        }
                    }
                }
            }

            pictureBox1.Image = null;
            progressBar1.Visible = false;
            progressBar1.Value = 0;
        }

        // TextChanged əmrləri (sağa yazılan solda görünür)
        private void textBox1_TextChanged(object sender, EventArgs e) { label1.Text = textBox1.Text; }
        private void textBox2_TextChanged(object sender, EventArgs e) { label2.Text = textBox2.Text; }
        private void textBox3_TextChanged(object sender, EventArgs e) { label3.Text = textBox3.Text; }
        private void textBox4_TextChanged(object sender, EventArgs e) { label4.Text = textBox4.Text; }
        private void textBox5_TextChanged(object sender, EventArgs e) { label5.Text = textBox5.Text; }
        private void textBox6_TextChanged(object sender, EventArgs e) { label6.Text = textBox6.Text; }
        private void textBox7_TextChanged(object sender, EventArgs e) { label7.Text = textBox7.Text; }
        private void textBox8_TextChanged(object sender, EventArgs e) { label8.Text = textBox8.Text; }
        private void textBox9_TextChanged(object sender, EventArgs e) { label9.Text = textBox9.Text; }
        private void textBox10_TextChanged(object sender, EventArgs e) { label10.Text = textBox10.Text; }
        private void textBox11_TextChanged(object sender, EventArgs e) { label11.Text = textBox11.Text; }
        private void textBox12_TextChanged(object sender, EventArgs e) { label12.Text = textBox12.Text; }

        private void button3_Click(object sender, EventArgs e)
        {
            // 1. Əvvəlcə xanalarda boşluq olub-olmadığını yoxlayırıq
            if (string.IsNullOrWhiteSpace(textBox1.Text) || string.IsNullOrWhiteSpace(textBox2.Text) ||
                string.IsNullOrWhiteSpace(textBox3.Text) || string.IsNullOrWhiteSpace(textBox4.Text) ||
                string.IsNullOrWhiteSpace(textBox5.Text) || string.IsNullOrWhiteSpace(textBox6.Text) ||
                string.IsNullOrWhiteSpace(textBox7.Text) || string.IsNullOrWhiteSpace(textBox8.Text) ||
                string.IsNullOrWhiteSpace(textBox9.Text) || string.IsNullOrWhiteSpace(textBox10.Text) ||
                string.IsNullOrWhiteSpace(textBox11.Text) || string.IsNullOrWhiteSpace(textBox12.Text))
            {
                // Əgər boş xana varsa: timer İŞLƏMİR, progressBar GÖRNÜMÜR
                progressBar1.Visible = false;
                progressBar1.Value = 0;
                MessageBox.Show("Məlumatlar tam daxil edilməyib", "Diqqət", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                // Əgər hər şey doldursulubsa: progressBar görünür, qiyməti sıfırlanır və timer işə düşür
                progressBar1.Visible = true;
                progressBar1.Value = 0;
                timer1.Start();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Value += 10;
            if (progressBar1.Value >= 100)
            {
                timer1.Stop();

                // Yalnız məlumatlar tam olanda timer bu hissəyə glib çıxır
                DialogResult d = MessageBox.Show("Yadda saxlandı", "Məlumat", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (d == DialogResult.OK)
                {
                    progressBar1.Visible = false;
                    progressBar1.Value = 0;
                }
            }
        }
    }
}