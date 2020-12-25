using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMBO_BOMBO_
{   
    public partial class Form1 : Form
    {   
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
          
            comboBox1.Items.Add(comboBox1.Text);
            comboBox2.Items.Add(comboBox2.Text);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                textBox1.Text += comboBox1.Text;
                comboBox3.Items.Add(textBox1.Text);
            }
            if (radioButton2.Checked)
            {
                textBox1.Text += Convert.ToString(Convert.ToDouble(comboBox1.Text) + Convert.ToDouble(comboBox2.Text));
                comboBox3.Items.Add(textBox1.Text);
            }
            if (radioButton3.Checked)
            {
                textBox1.Text += Convert.ToString(Convert.ToDouble(comboBox1.Text) * Convert.ToDouble(comboBox1.Text));
                comboBox3.Items.Add(textBox1.Text);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
