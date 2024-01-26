namespace Final_Exam
{
    // FINAL EXAM_Fastfood
    // MEMBERS;
    // Jomari B. Apostadero
    // Rosemarie D. Ducay
    // Cathyrine  Menguito 
    // Shiela Trinidad Bola
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

            comboBox1.Items.Add("Coke.............₱ 50.25");
            comboBox1.Items.Add("Royal............₱ 50.50");
            comboBox1.Items.Add("Sprite...........₱ 50.75 ");
            comboBox1.Items.Add("Pineapple....₱ 60.00");
            comboBox1.SelectedIndex = 0;
            textBox1.Enabled = false;
            textBox3.Enabled = false;
            Mega_Clear();
        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            Picture_box2_Jolibe();
            textBox1_TextChanged(this, new EventArgs());
            textBox1.Clear();
        }
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.BackgroundImage = Properties.Resources.alohaburgor_removebg_preview;
            double aa = 135.00;
            if (radioButton2.Checked) aa = 135.00;
            else aa = -135.00;
            if (radioButton2.Checked)
            {
                radioButton3.Enabled = false;
                radioButton4.Enabled = false;
            }
            UpdateTextBox(aa);
        }
        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.BackgroundImage = Properties.Resources.Cheesey_yumbergur_removebg_preview__2_;
            double aa = 60.00;
            if (radioButton3.Checked) aa = 60.00;
            else aa = -60.00;
            if (radioButton3.Checked)
            {
                radioButton2.Enabled = false;
                radioButton4.Enabled = false;
            }
            UpdateTextBox(aa);
        }

        private void pictureBox1_Click(object sender, EventArgs e) { }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.BackgroundImage = Properties.Resources.yumburger_removebg_preview;
            double aa = 50.00;
            if (radioButton4.Checked) aa = 50.00;
            else aa = -50.00;
            if (radioButton4.Checked)
            {
                radioButton2.Enabled = false;
                radioButton3.Enabled = false;
            }
            UpdateTextBox(aa);
        }
        private void UpdateTextBox(double newValue)
        {
            double currentValue = 0.00;
            if (double.TryParse(textBox1.Text, out currentValue))
            {
                double result = currentValue + newValue;
                textBox1.Text = result.ToString();
            }
            else textBox1.Text = newValue.ToString();
        }
        private void textBox1_TextChanged(object sender, EventArgs e) { }
        private void textBox2_TextChanged(object sender, EventArgs e) { }
        private void label1_Click(object sender, EventArgs e) { }
        private void label2_Click(object sender, EventArgs e) { }
        public void button1_Click(object sender, EventArgs e)
        {
            double b, a;
            float c;
            a = Convert.ToDouble(textBox1.Text);
            b = Convert.ToDouble(textBox2.Text);
            c = ((float)(b - a));
            textBox3.Text = "₱ " + c.ToString();
        }
        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox2.BackgroundImage = Properties.Resources.image_removebg_preview__4_;
            double bb;
            if (checkBox3.Checked) bb = 90.50;
            else bb = -90.50;
            if (checkBox3.Checked == true)
            {
                checkBox2.Enabled = false;
                checkBox1.Enabled = false;
            }
            else
            {
                checkBox1.Enabled = true;
                checkBox2.Enabled = true;
            }
            if (checkBox3.Checked == false) Picture_box2_Jolibe();
            UpdateTextBox(bb);
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox2.BackgroundImage = Properties.Resources.image_removebg_preview__3_;
            double bb;
            if (checkBox1.Checked) bb = 75.50;
            else bb = -75.50;
            if (checkBox1.Checked == true)
            {
                checkBox2.Enabled = false;
                checkBox3.Enabled = false;
            }
            else
            {
                checkBox2.Enabled = true;
                checkBox3.Enabled = true;
            }
            if (checkBox1.Checked == false) Picture_box2_Jolibe();
            UpdateTextBox(bb);
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox2.BackgroundImage = Properties.Resources.image_removebg_preview__5_;
            double bb;
            if (checkBox2.Checked) bb = 95.05;
            else bb = -95.05;
            if (checkBox2.Checked == true)
            {
                checkBox3.Enabled = false;
                checkBox1.Enabled = false;
            }
            else
            {
                checkBox1.Enabled = true;
                checkBox3.Enabled = true;
            }
            if (checkBox2.Checked == false) Picture_box2_Jolibe();
            UpdateTextBox(bb);
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            double bb = 0.00;
            if (comboBox1.SelectedIndex == 1)
            {
                bb += 50.25;
                UpdateTextBox(bb);
                pictureBox3.BackgroundImage = Properties.Resources.image_removebg_preview__13_;
                comboBox1.Enabled = false;
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                bb += 50.50;
                pictureBox3.BackgroundImage = Properties.Resources.image_removebg_preview__11_;
                UpdateTextBox(bb);
                comboBox1.Enabled = false;
            }
            else if (comboBox1.SelectedIndex == 3)
            {
                bb += 50.75;
                pictureBox3.BackgroundImage = Properties.Resources.image_removebg_preview__12_;
                UpdateTextBox(bb);
                comboBox1.Enabled = false;
            }
            else if (comboBox1.SelectedIndex == 4)
            {
                bb += 60.00;
                pictureBox3.BackgroundImage = Properties.Resources.image_removebg_preview__10_1;
                UpdateTextBox(bb);
                comboBox1.Enabled = false;
            }
        }
        private void groupBox1_Enter(object sender, EventArgs e) { }
        private void pictureBox2_Click(object sender, EventArgs e) { }
        private void button2_Click(object sender, EventArgs e)
        {
            Mega_Clear();
            //Jolibee_Pic_Defualt
            Picture_box1_Jolibe();
            Picture_box2_Jolibe();
            Picture_box3_Jolibe();
            Picture_box4_Jolibe();
        }
        private void Mega_Clear()
        {

            //RADIOBUTTON_CLEAR
            radioButton4.Checked = false;
            radioButton3.Checked = false;
            radioButton2.Checked = false;
            //RADIOBUTTON_Enable_True
            radioButton4.Enabled = true;
            radioButton3.Enabled = true;
            radioButton2.Enabled = true;
            radioButton1_CheckedChanged(this, new EventArgs());
            //CHECKBOX_CLEAR
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            //ComboBox_CLEAR
            comboBox1.SelectedIndex = 0;
            comboBox1.Enabled = true;
            //ListBox_CLEAR
            listBox1.Enabled = true;
            //TextBox_CLEAR
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            double clearResetValue = 0;
            UpdateTextBox(clearResetValue);
        }
        private void Picture_box2_Jolibe()
        {
            pictureBox2.BackgroundImage = Properties.Resources.jollibee_png_jollibee_logo_png_200;
        }
        private void Picture_box1_Jolibe()
        {
            pictureBox1.BackgroundImage = Properties.Resources.jollibee_png_jollibee_logo_png_200;
        }
        private void Picture_box3_Jolibe()
        {
            pictureBox3.BackgroundImage = Properties.Resources.jollibee_png_jollibee_logo_png_200;
        }
        private void Picture_box4_Jolibe()
        {
            pictureBox4.BackgroundImage = Properties.Resources.jollibee_png_jollibee_logo_png_200;
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            double bb = 0.00;
            if (listBox1.SelectedIndex == 0)
            {
                bb += 35.00;
                listBox1.Enabled = false;
                pictureBox4.BackgroundImage = Properties.Resources.image_removebg_preview__15_;
                UpdateTextBox(bb);
            }
            if (listBox1.SelectedIndex == 1)
            {
                bb += 60.00;
                listBox1.Enabled = false;
                pictureBox4.BackgroundImage = Properties.Resources.image_removebg_preview__7_;
                UpdateTextBox(bb);
            }
            if (listBox1.SelectedIndex == 2)
            {
                bb += 40.00;
                listBox1.Enabled = false;
                pictureBox4.BackgroundImage = Properties.Resources.image_removebg_preview__16_;
                UpdateTextBox(bb);
            }
        }
    }
}