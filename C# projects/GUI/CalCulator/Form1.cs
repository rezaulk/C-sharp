using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalCulator
{
    public partial class Form1 : Form
    {
        private Size formOriginalSize;
        private Rectangle textbox2Originalrect;
        private Rectangle textbox1Originalrect;
        private Rectangle button1Originalrect;
        private Rectangle button2Originalrect;
        private Rectangle button3Originalrect;
        private Rectangle button4Originalrect;
        private Rectangle button5Originalrect;
        private Rectangle button6Originalrect;
        private Rectangle button7Originalrect;
        private Rectangle button8Originalrect;
        private Rectangle button9Originalrect;
        private Rectangle button0Originalrect;
        private Rectangle buttonpmOriginalrect;
        private Rectangle button1dotOriginalrect;
        private Rectangle buttoncOriginalrect;
        //private Rectangle buttoncOriginalrect;

        private Rectangle buttonplusOriginalrect;
        private Rectangle buttonminOriginalrect;
        private Rectangle buttonmulOriginalrect;
        private Rectangle buttondivOriginalrect;


        public Form1()
        {
            InitializeComponent();
        }
        public string number = "", word = "";
        public int current = 0, y = 0;
        int start = 0;
        bool plus, minus, mult, div;
        bool enterchar = false;


        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void button0_Click(object sender, EventArgs e)
        {
            number = number + "0";
            textBox1.Text = number;
            enterchar = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            number = number + "1";
            textBox1.Text = number;
            enterchar = true;
            //button1.
        }
        private void button2_Click(object sender, EventArgs e)
        {
            number = number + "2";
            textBox1.Text = number;
            enterchar = true;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            number = number + "3";
            textBox1.Text = number;
            enterchar = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            number = number + "4";
            textBox1.Text = number;
            enterchar = true;
        }
        private void button5_Click(object sender, EventArgs e)
        {
            number = number + "5";
            textBox1.Text = number;
            enterchar = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            number = number + "6";
            textBox1.Text = number;
            enterchar = true;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            number = number + "7";
            textBox1.Text = number;
            enterchar = true;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            number = number + "8";
            textBox1.Text = number;
            enterchar = true;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            number = number + "9";
            textBox1.Text = number;
            enterchar = true;
        }

        public void setresult(int s)
        {
            if (plus == true)
            {
                current = current + s;
                plus = false;
            }
            else if (minus == true)
            {
                current = current - s;
                minus = false;
            }
            else if (mult == true)
            {
                current = current * s;
                mult = false;
            }
            else if (div == true)
            {
                current = current / s;
                div = false;
            }
        }

        private void buttonplus_Click(object sender, EventArgs e)
        {
            if (enterchar == true)
            {
                int x = Convert.ToInt32(number);
                if (minus == true)
                {

                    current = current - Convert.ToInt32(number);
                    minus = false;
                }
                else if (y == 0)
                {
                    current = x;
                }
                else
                {
                    setresult(x);
                }

                number = number + "+";
                word = word + number;
                textBox2.Text = word;
                number = "";
                y++;

                start = 1;
  
                plus = true;
                enterchar = false;

                textBox1.Text = Convert.ToString(current);
            }


        }

        private void buttonmin_Click(object sender, EventArgs e)
        {
            if (enterchar == true)
            {
                int x = Convert.ToInt32(number);
                bool check = false;
                if (start == 0)
                {
                    number = number + "-";
                    word = word + number;
                    textBox2.Text = number;
                    current = x;
                    minus = true;
                    start = 1;

                    textBox1.Text = Convert.ToString(number);
                    number = "";
                    minus = true;
                    
                }
                else
                {
                    number = number + "-";
                    word = word + number;
                    textBox2.Text = word;
                    number = "";
                    setresult(x);
                    textBox1.Text = Convert.ToString(current);
                    minus = true;

                }
                enterchar = false;
            }
        }
        private void buttonmul_Click(object sender, EventArgs e)
        {
            if (enterchar == true)
            {
                y++;
                if (plus == true)
                {
                    int x = Convert.ToInt32(number);
                    number = number + "*";
                    word = word + number;
                    textBox2.Text = word;
                    number = "";

                    current = current * x;
                    textBox1.Text = Convert.ToString(current);
                }
                else if (y == 1)
                {
                    int x = Convert.ToInt32(number);
                    current = x;
                }
                else
                {
                    int x = Convert.ToInt32(number);
                    number = number + "*";
                    word = word + number;
                    textBox2.Text = word;
                    number = "";
                    setresult(x);
                    textBox1.Text = Convert.ToString(current);
                }

                //minus = false;
            }

        }

        private void buttonc_Click_1(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            number = "";
            word = "";
            current = 0;
            minus = false;
            start = 0;
            enterchar = false;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //formOriginalSize = this.Size;

            //textbox1Originalrect = new Rectangle(textBox1.Location.X, textBox1.Location.Y, textBox1.Width, textBox1.Height);
            //textbox2Originalrect = new Rectangle(textBox2.Location.X, textBox2.Location.Y, textBox2.Width, textBox2.Height);

            //button0Originalrect = new Rectangle(button0.Location.X, button0.Location.Y, button0.Width, button0.Height);
            //button1Originalrect = new Rectangle(button1.Location.X, button1.Location.Y, button1.Width, button1.Height);
            //button2Originalrect = new Rectangle(button2.Location.X, button2.Location.Y, button2.Width, button2.Height);
            //button3Originalrect = new Rectangle(button3.Location.X, button3.Location.Y, button3.Width, button3.Height);
            //button4Originalrect = new Rectangle(button4.Location.X, button4.Location.Y, button4.Width, button4.Height);
            //button5Originalrect = new Rectangle(button5.Location.X, button5.Location.Y, button5.Width, button5.Height);
            //button6Originalrect = new Rectangle(button6.Location.X, button6.Location.Y, button6.Width, button6.Height);
            //button7Originalrect = new Rectangle(button7.Location.X, button7.Location.Y, button7.Width, button7.Height);
            //button8Originalrect = new Rectangle(button8.Location.X, button8.Location.Y, button8.Width, button8.Height);
            //button9Originalrect = new Rectangle(button9.Location.X, button9.Location.Y, button9.Width, button9.Height);

            ////buttoncOriginalrect = new Rectangle(buttonc.Location.X, buttonc.Location.Y, buttonc.Width, buttonc.Height);
            //buttoncOriginalrect = new Rectangle(buttonc.Location.X, buttonc.Location.Y, buttonc.Width, buttonc.Height);
            //buttonplusOriginalrect = new Rectangle(buttonplus.Location.X, buttonplus.Location.Y, buttonplus.Width, buttonplus.Height);
            //buttonminOriginalrect = new Rectangle(buttonmin.Location.X, buttonmin.Location.Y, buttonmin.Width, buttonmin.Height);
            //buttonmulOriginalrect = new Rectangle(buttonmul.Location.X, buttonmul.Location.Y, buttonmul.Width, buttonmul.Height);
            //buttondivOriginalrect = new Rectangle(buttondiv.Location.X, buttondiv.Location.Y, buttondiv.Width, buttondiv.Height);



        }
        private void resizeChildrenControls()
        {
            //resizeControl(textbox1Originalrect, textBox1);
            //resizeControl(textbox2Originalrect, textBox2);
            //resizeControl(button0Originalrect, button0);
            //resizeControl(button1Originalrect, button1);
            //resizeControl(button2Originalrect, button2);
            //resizeControl(button3Originalrect, button3);
            //resizeControl(button4Originalrect, button4);
            //resizeControl(button5Originalrect, button5);
            //resizeControl(button6Originalrect, button6);
            //resizeControl(button7Originalrect, button7);
            //resizeControl(button8Originalrect, button8);
            //resizeControl(button9Originalrect, button9);
            //resizeControl(buttoncOriginalrect, buttonc);

            //resizeControl(buttonplusOriginalrect, buttonplus);
            //resizeControl(buttonminOriginalrect, buttonmin);
            //resizeControl(buttonmulOriginalrect, buttonmul);
            //resizeControl(buttondivOriginalrect, buttondiv);

        }
        private void resizeControl(Rectangle originalControlRect, Control control)
        {
            //float xRatio = (float)(this.Width) / (float)(formOriginalSize.Width);
            //float yRatio = (float)(this.Height) / (float)(formOriginalSize.Height);

            //int newX = (int)(originalControlRect.X * xRatio);
            //int newY = (int)(originalControlRect.Y * yRatio);
            //int newWidth = (int)(originalControlRect.Width * xRatio);
            //int newHeight = (int)(originalControlRect.Height * yRatio);

            //control.Location = new Point(newX, newY);
            //control.Size = new Size(newWidth, newHeight);
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            //resizeChildrenControls();
        }



        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {

        }



    }
}
