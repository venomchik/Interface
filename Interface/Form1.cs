using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interface
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show(textBox1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = Clipboard.GetText();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

      

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(textBox1.Text);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = "Enter a message here";
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                
                button1.Enabled = true;
                button2.Enabled = true;
                button6.Enabled = true;
                button7.Enabled = true;
                button3.Enabled = true;
                textBox1.Enabled = true;
            }
            else
            {
                
                button1.Enabled = false;
                button2.Enabled = false;
                button6.Enabled = false;
                button7.Enabled = false;
                button3.Enabled = false;
                textBox1.Enabled = false;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox3.Checked==true)
            {
                label1.Visible = true;
                button1.Visible = true;
                button2.Visible = true;
                button6.Visible = true;
                button7.Visible = true;
                button3.Visible = true;
                textBox1.Visible = true;
            }
            else
            {
                label1.Visible = false;
                button1.Visible = false;
                button2.Visible = false;
                button6.Visible = false;
                button7.Visible = false;
                button3.Visible = false;
                textBox1.Visible = false;
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked == true)
            {
                label2.Visible = true;
                button4.Visible = true;
                comboBox1.Visible = true;
            }
            else
            {
                label2.Visible = false;
                button4.Visible = false;
                comboBox1.Visible = false;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked == true)
            {
                
                button4.Enabled = true;
                comboBox1.Enabled = true;
            }
            else
            {
                
                button4.Enabled = false;
                comboBox1.Enabled = false;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true) { MessageBox.Show("EnableMessageActions----active"); }
            if (checkBox2.Checked == true) { MessageBox.Show("EnableProgramActions----active"); }
            if (checkBox3.Checked == true) { MessageBox.Show("ShowMessageActions----active"); }
            if (checkBox4.Checked == true) { MessageBox.Show("ShowProgramActions----active"); }

            if (checkBox1.Checked == false) { MessageBox.Show("EnableMessageActions----notactive"); }
            if (checkBox2.Checked == false) { MessageBox.Show("EnableProgramActions----notactive"); }
            if (checkBox3.Checked == false) { MessageBox.Show("ShowMessageActions----notactive"); }
            if (checkBox4.Checked == false) { MessageBox.Show("ShowProgramActions----notactive"); }

        }
    }
}
