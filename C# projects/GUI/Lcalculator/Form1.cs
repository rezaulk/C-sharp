using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lcalculator
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
      
        //private Rectangle button1dotOriginalrect;
        private Rectangle buttoncOriginalrect;
     

        private Rectangle buttonplusOriginalrect;
        private Rectangle buttonminOriginalrect;
        private Rectangle buttonmulOriginalrect;
        private Rectangle buttondivOriginalrect;

        private Rectangle buttonpmOriginalrect;
        private Rectangle buttonmpOriginalrect;
        private Rectangle buttonmmOriginalrect;
        private Rectangle buttonrootOriginalrect;
        private Rectangle buttonmcOriginalrect;
        private Rectangle buttonmrOriginalrect;
        private Rectangle buttonbOriginalrect;
        private Rectangle buttondotOriginalrect;
        private Rectangle buttoneqOriginalrect;




        double y = 0, result = 0, memory = 0;
        int taken_number = 0;
        string number = "";
        bool ax = false;
        bool bx = false;
        bool cx = false;
        bool dx = false;
        bool enter = false;
        int b = 0, has = 0, sd = 0, ans = 0, root = 0;
        int dot = 0;
        string operation;
        StringBuilder totalstring = new StringBuilder();


        public Form1()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            taken_number++;
            if (taken_number < 11)
            {
                number = number + "7";
                textBox1.Text = number;
                enter = true;
                ans = 0;

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            taken_number++;

            if (taken_number < 11)
            {
                number = number + "1";
                textBox1.Text = number;
                enter = true;
                ans = 0;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            taken_number++;
            if (taken_number < 11)
            {
                number = number + "2";
                textBox1.Text = number;
                enter = true;
                ans = 0;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            taken_number++;
            if (taken_number < 11)
            {
                number = number + "3";
                textBox1.Text = number;
                enter = true;
                ans = 0;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            taken_number++;
            if (taken_number < 11)
            {
                number = number + "4";
                textBox1.Text = number;
                enter = true;
                ans = 0;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            taken_number++;
            if (taken_number < 11)
            {
                number = number + "5";
                textBox1.Text = number;
                enter = true;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            taken_number++;
            if (taken_number < 11)
            {
                number = number + "6";
                textBox1.Text = number;
                enter = true;
                ans = 0;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            taken_number++;
            if (taken_number < 11)
            {
                number = number + "8";
                textBox1.Text = number;
                enter = true;
                ans = 0;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            taken_number++;
            if (taken_number < 11)
            {
                number = number + "9";
                textBox1.Text = number;
                enter = true;
                ans = 0;
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            number = number + "0";
            textBox1.Text = number;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (dot == 0)
            {
                number = number + ".";
                textBox1.Text = number;
                dot++;
            }
        }
        public void setresult(double s)
        {
            if (ax == true)
            {
                result = result + s;
                ax = false;
            }
            else if (bx == true)
            {
                result = result - s;
                bx = false;
            }
            else if (cx == true)
            {
                result = result * s;
                cx = false;
            }
            else if (dx == true)
            {
                result = result / s;
                dx = false;
            }
        }
        public void getresult()
        {
            double p = Convert.ToDouble(textBox1.Text);
           
            if (operation == "+")
                result = result + p;
            else if (operation == "-")
                result = result - p;
            else if (operation == "*")
                result = result * p;
            else if (operation == "/")
                result = result / p;
            else
            {
                if (bx == true)
                {
                    result = -p;
                    bx = false;
                }
                else
                {
                    result = p;
                }

            }
            String s = Convert.ToString(result);
            double de = Convert.ToDouble(s);
            textBox2.Text = (Convert.ToString(de));
            number = "";
            textBox1.Text = number;

            operation = "";
            y = 0;
            dot = 0;
            has = 915;

            ax = false;
            bx = false;
            cx = false;
            dx = false;
            enter = true;
            sd = 123;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            taken_number = 0;
            if (enter == true)
            {
                double x;
                dot = 0;
                y++;
                if (has == 915)
                {
                    x = result;
                    has = 0;
                }
                else
                {
                    x = Convert.ToDouble(textBox1.Text);
                }

                int cd = (int)x;
                double dc = (double)cd;
             
                textBox1.Text="";
                if (bx == true)
                {
                    result = result - x;
                    bx = false;
                }
                else if (y == 1)
                {
                    result = x;
                }
                else
                {
                    setresult(x);
                }

                cd = (int)result;
                dc = (double)cd;
                //if (result == dc)
                //{
                    //textBox2.Text=Convert.ToString(cd) + "+";
               // }
               // else
               // {
                    textBox2.Text=Convert.ToString(result) + "+";
               // }
                number = "";
                operation = "+";
                ax = true;
                y++;
                enter = false;
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
             taken_number=0;
             bx=true;
             y++;			 
		     if(enter==true)
			 {
				double x=0;	
				dot=0;
				
				number="";
				if(has==915)
				{
					x=result;
					has=0;
				}
				else
				{
					x=Convert.ToDouble(textBox1.Text);
				}
				int cd=(int)x;
				double dc=(double)cd;
              
				textBox1.Text="";
			    if(y==2)
				{
					 result=result-x;
				}
				else if(y==1)
				{
					result=x;
				}
				
				else
				{
					 setresult(x);
				}
				
				enter=false;
				
				operation="-";
				cd=(int)result;
				dc=(double)cd;
                //if (result == dc)
                //{
                //    textBox2.Text = Convert.ToString(cd) + "-";
                //}
                //else
                //{
					 textBox2.Text=Convert.ToString(result)+"-";
                //}
			
		}   
        }

        private void button17_Click(object sender, EventArgs e)
        {
            taken_number = 0;
            if (enter == true)
            {
                double x = 0;
                y++;
                number = "";
                if (has == 915)
                {
                    x = result;
                    has = 0;
                }
                else
                {
                    x = Convert.ToDouble(textBox1.Text);
                }

                int cd = (int)x;
                double dc = (double)cd;
                textBox1.Text="";
                if (bx == true)
                {
                    result = result - x;
                }
                else if (y == 1)
                {
                    result = x;
                }
                else
                {
                    setresult(x);
                }
                cx = true;
                operation = "*";
                enter = false;
                cd = (int)result;
                dc = (double)cd;
                //if (result == dc)
                //{
                //    textBox2.Text = Convert.ToString(cd) + "*";
                //}
                //else
                //{
                    textBox2.Text=Convert.ToString(result) + "*";
                //}
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            taken_number = 0;
            if (enter == true)
            {
                double x = 0;
                y++;
                number = "";
                if (has == 915)
                {
                    x = result;
                    has = 0;
                }
                else
                {
                    x = Convert.ToDouble(textBox1.Text);
                }
                textBox1.Text="";
                if (bx == true)
                {
                    result = result - x;
                    bx = false;
                }
                else if (y == 1)
                {
                    result = x;
                }
                else
                {
                    setresult(x);

                }
                dx = true;
                enter = false;
                operation = "/";
                int cd = (int)result;
                double  dc = (double)cd;
                //if (result == dc)
                //{
                //    textBox2.Text=Convert.ToString(cd) + "/";
                //}
                //else
                //{
                    textBox2.Text=Convert.ToString(result) + "/";
                //}
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (enter == true)
            {
                if (ans == 0)
                {
                    getresult();
                    ans = 1;
                }
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            double a1 =Convert.ToDouble(textBox1.Text);
            a1 = -a1;
            textBox1.Text=Convert.ToString(a1);
        }

        private void button24_Click(object sender, EventArgs e)
        {
            textBox1.Text="";
            textBox2.Text="";
            y = 0;
            dot = 0;
            taken_number = 0;
            result = 0;
            number = "";
            operation = "";
            has = 0;
            ax = false;
            bx = false;
            cx = false;
            dx = false;
            enter = false;
        }

        private void button23_Click(object sender, EventArgs e)
        {
            if(enter==true)
			     {
					    String str=textBox1.Text;
				        int length=str.Length;
				        //System.out.println(length);
						int s=number.Length;
						s=s-1;
						StringBuilder sb = new StringBuilder(number);
						//sb.deleteCharAt(s);
                        sb.Remove(s,1);

                        textBox1.Text = sb + "";
						
						number=sb+"";
                        taken_number--;
						if(length==2)
					    {
							s=number.Length;
							s=s-1;
							StringBuilder sd = new StringBuilder(number);
							//sd.deleteCharAt(s);
                            sd.Remove(s, 1);
							textBox1.Text=sd+"";
                           
						    number=sd+"";
						    enter=false;
						}
				}
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            
            memory = memory + Convert.ToDouble(textBox2.Text);
         
        }


        private void button19_Click(object sender, EventArgs e)
        {
            memory = memory - Convert.ToDouble(textBox1.Text);
        }

        private void button22_Click(object sender, EventArgs e)
        {
            textBox2.Text = Convert.ToString(memory);
        }

        private void button21_Click(object sender, EventArgs e)
        {
            memory = 0;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            taken_number = 0;
            if (enter == true)
            {
                double x;

               
                x = Convert.ToDouble(textBox1.Text);
                x = x * x;
               setresult(x);
               
               int  cd = (int)result;
               double dc = (double)cd;
                if (result == dc)
                {
                    textBox2.Text = Convert.ToString(cd) + "+";
                }
                else
                {
                    textBox2.Text = Convert.ToString(result) + "+";
                }
                number = "";
                textBox1.Text = "";
                
                //ax = true;
                y++;
                enter = false;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            formOriginalSize = this.Size;

            textbox1Originalrect = new Rectangle(textBox1.Location.X, textBox1.Location.Y, textBox1.Width, textBox1.Height);
            textbox2Originalrect = new Rectangle(textBox2.Location.X, textBox2.Location.Y, textBox2.Width, textBox2.Height);

            button0Originalrect = new Rectangle(button12.Location.X, button12.Location.Y, button12.Width, button12.Height);
            button1Originalrect = new Rectangle(button1.Location.X, button1.Location.Y, button1.Width, button1.Height);
            button2Originalrect = new Rectangle(button2.Location.X, button2.Location.Y, button2.Width, button2.Height);
            button3Originalrect = new Rectangle(button3.Location.X, button3.Location.Y, button3.Width, button3.Height);
            button4Originalrect = new Rectangle(button4.Location.X, button4.Location.Y, button4.Width, button4.Height);
            button5Originalrect = new Rectangle(button5.Location.X, button5.Location.Y, button5.Width, button5.Height);
            button6Originalrect = new Rectangle(button6.Location.X, button6.Location.Y, button6.Width, button6.Height);
            button7Originalrect = new Rectangle(button7.Location.X, button7.Location.Y, button7.Width, button7.Height);
            button8Originalrect = new Rectangle(button8.Location.X, button8.Location.Y, button8.Width, button8.Height);
            button9Originalrect = new Rectangle(button9.Location.X, button9.Location.Y, button9.Width, button9.Height);

            //buttoncOriginalrect = new Rectangle(buttonc.Location.X, buttonc.Location.Y, buttonc.Width, buttonc.Height);
            buttoncOriginalrect = new Rectangle(button24.Location.X, button24.Location.Y, button24.Width, button24.Height);
            buttonplusOriginalrect = new Rectangle(button15.Location.X, button15.Location.Y, button15.Width, button15.Height);
            buttonminOriginalrect = new Rectangle(button16.Location.X, button16.Location.Y, button16.Width, button16.Height);
            buttonmulOriginalrect = new Rectangle(button17.Location.X, button17.Location.Y, button17.Width, button17.Height);
            buttondivOriginalrect = new Rectangle(button10.Location.X, button10.Location.Y, button10.Width, button10.Height);

            buttonpmOriginalrect = new Rectangle(button13.Location.X, button13.Location.Y, button13.Width, button13.Height);
            buttonmpOriginalrect = new Rectangle(button20.Location.X, button20.Location.Y, button20.Width, button20.Height);
            buttonmmOriginalrect = new Rectangle(button19.Location.X, button19.Location.Y, button19.Width, button19.Height);
            buttonrootOriginalrect = new Rectangle(button18.Location.X, button18.Location.Y, button18.Width, button18.Height);
            buttonmcOriginalrect = new Rectangle(button21.Location.X, button21.Location.Y, button21.Width, button21.Height);

            buttonmrOriginalrect = new Rectangle(button22.Location.X, button22.Location.Y, button22.Width, button22.Height);
            buttonbOriginalrect = new Rectangle(button23.Location.X, button23.Location.Y, button23.Width, button23.Height);
            buttondotOriginalrect = new Rectangle(button11.Location.X, button11.Location.Y, button11.Width, button11.Height);
            buttoneqOriginalrect = new Rectangle(button14.Location.X, button14.Location.Y, button14.Width, button14.Height);


        }
        private void resizeChildrenControls()
        {
            resizeControl(textbox1Originalrect, textBox1);
            resizeControl(textbox2Originalrect, textBox2);
            resizeControl(button0Originalrect, button12);
            resizeControl(button1Originalrect, button1);
            resizeControl(button2Originalrect, button2);
            resizeControl(button3Originalrect, button3);
            resizeControl(button4Originalrect, button4);
            resizeControl(button5Originalrect, button5);
            resizeControl(button6Originalrect, button6);
            resizeControl(button7Originalrect, button7);
            resizeControl(button8Originalrect, button8);
            resizeControl(button9Originalrect, button9);
            resizeControl(buttoncOriginalrect, button24);
            resizeControl(buttonplusOriginalrect, button15);
            resizeControl(buttonminOriginalrect, button16);
            resizeControl(buttonmulOriginalrect, button17);
            resizeControl(buttondivOriginalrect, button10);
            resizeControl(buttonpmOriginalrect, button13);
            resizeControl(buttonmpOriginalrect, button20);
            resizeControl(buttonmmOriginalrect, button19);
            resizeControl(buttonrootOriginalrect, button18);
            resizeControl(buttonmcOriginalrect, button21);
            resizeControl(buttonmrOriginalrect, button22);
            resizeControl(buttonbOriginalrect, button23);
            resizeControl(buttondotOriginalrect, button11);
            resizeControl(buttoneqOriginalrect, button14);
            


        }
        private void resizeControl(Rectangle originalControlRect, Control control)
        {
            float xRatio = (float)(this.Width) / (float)(formOriginalSize.Width);
            float yRatio = (float)(this.Height) / (float)(formOriginalSize.Height);

            int newX = (int)(originalControlRect.X * xRatio);
            int newY = (int)(originalControlRect.Y * yRatio);
            int newWidth = (int)(originalControlRect.Width * xRatio);
            int newHeight = (int)(originalControlRect.Height * yRatio);

            control.Location = new Point(newX, newY);
            control.Size = new Size(newWidth, newHeight);
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            resizeChildrenControls();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
