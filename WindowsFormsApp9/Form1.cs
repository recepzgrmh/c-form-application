using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp9
{
    public partial class Form1 : Form
    {
        ListBox listbox1 = new ListBox();
        Label label1 = new Label();
        Label label2 = new Label();
        CheckBox checkBox1 = new CheckBox();
        CheckBox checkBox2 = new CheckBox();
        ComboBox comboBox1 = new ComboBox();
        Button button1 = new Button();
        Button button2 = new Button();
        TextBox textBox1 = new TextBox();
        TextBox textbox2 = new TextBox();
        public Form1()
        {
            listbox1.Location = new Point(151, 78);
            label1.Location = new Point(395, 78);
            textBox1.Location = new Point(457, 78);

            checkBox1.Location = new Point(457, 124);
            checkBox2.Location = new Point(575, 124);

            label2.Location = new Point(393, 163);
            comboBox1.Location = new Point(457, 163);



            button2.Location = new Point(457, 206);

            textbox2.Location = new Point(457, 256);

            button1.Location = new Point(151, 342);


            button1.Text = "Veri Ekle";
            button2.Text = "Veri Gör";

            label1.Text = "İsim Soyisim: ";
            checkBox1.Text = "KIZ";
            checkBox2.Text = "ERKEK";

            label2.Text = "Bölüm";

            comboBox1.Items.Add("Bilgisayar Bilimleri");
            comboBox1.Items.Add("İstatistik");
            comboBox1.Items.Add("Matematik");
            comboBox1.Items.Add("Kimya");
            comboBox1.Items.Add("Biyoloji");

            this.BackColor = Color.AliceBlue;

            button1.Size = new Size(125, 43);

            textBox1.Width = 198;
            textBox1.Height = 20;

            textbox2.Size = new Size(198, 20);
            comboBox1.Size = new Size(125,20);
            button2.Size = new Size(96,34);

            button1.Click += Button1_Click;
            button2.Click += Button2_Click;

            

           

            button1.BackColor = Color.White;
            button2.BackColor = Color.White;

            comboBox1.Size = new Size(125, 21);
            listbox1.Size = new Size(199,199);

            label1.Width = 35;
            label2.Width = 40;

            checkBox1.Checked = false;
            checkBox2.Checked = false;


            Controls.Add(listbox1);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(textbox2);
            Controls.Add(checkBox1);
            Controls.Add(checkBox2);
            Controls.Add(comboBox1);
            Controls.Add(button1);
            Controls.Add(button2);

            checkBox1.CheckedChanged += CheckBox1_CheckedChanged;
            checkBox2.CheckedChanged += CheckBox2_CheckedChanged;

            InitializeComponent();
        }

        private void CheckBox2_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox2.Checked)
            {
                checkBox1.Checked = false;
            }
        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                checkBox2.Checked = false;
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            string sex = string.Empty;

            if(checkBox1.Checked)
            {
                sex = checkBox1.Text;
            }
            else
            {
                sex = checkBox2.Text;
            }

            textbox2.Text = textBox1.Text + " - " + sex + " - " + comboBox1.SelectedItem;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            listbox1.Items.Add(textbox2.Text);
            textbox2.Text = string.Empty;
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            comboBox1.SelectedItem = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.Size = new Size(1024, 1024);

        }
    }
}
