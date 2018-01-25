using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace first_class
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        bool enter = true;
        int y;

        

        private void button1_Click_1(object sender, EventArgs e)
        {
            text.Text="1";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            text.Text = "5";
        }

        private void button11_Click(object sender, EventArgs e)
        {

            if (enter == true)
            {
                text1.Text = Convert.ToString(text.Text);
                enter = false;
            }
            else
            {

                int x = Convert.ToInt32(text.Text);
                y = Convert.ToInt32(text1.Text);
                int z = x + y;
                text1.Text = Convert.ToString(z);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            text.Text = "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            text.Text = "3";
        }

        private void button146_Click(object sender, EventArgs e)
        {
            text.Text = "4";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            text.Text = "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            text.Text = "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            text.Text = "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            text.Text = "9";
        }

        private void text_TextChanged(object sender, EventArgs e)
        {

        }

        private void text1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            

                int x = Convert.ToInt32(text.Text);
                y = Convert.ToInt32(text1.Text);
                int z = x -y;
                text1.Text = Convert.ToString(z);
      
        }
    }
}
