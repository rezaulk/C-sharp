using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Blood_Donation
{
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void Confirm_Click(object sender, EventArgs e)
        {
            BloodDataContext D = new BloodDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=F:\C# projects\finalProject\Blood Donation\Blood.mdf;Integrated Security=True;Connect Timeout=30");
            string a = Passwordbox.Text;
            string b = Confirmpasswordbox.Text;
            

            DonorInfo pr = new DonorInfo();

            try
            {

                if (Namebox.Text != ""&&Ad.Text != ""&&Passwordbox.Text!=""&&Confirmpasswordbox.Text!=""&&textBox1.Text!=""&&BloodGroup.Text!=""&&PhoneNo.Text!="")
                {
                     if (a == b)
                      {
                            pr.Password = Passwordbox.Text;
                            pr.Name = Namebox.Text;
                            pr.Address = Ad.Text;
                            pr.Phone=Ph.Text;
                            pr.UserID=textBox1.Text;
                            pr.BloodGroup=bgroup.Text;

                          D.DonorInfos.InsertOnSubmit(pr);
                   
                          D.SubmitChanges();

                          MessageBox.Show("Congratulation as Member in our Family");
                          Start l = new Start();
                          l.Show();
                          this.Hide();
                      }
                   
                     else
                    {
                        MessageBox.Show("Password not match");
                    }
                }
                else
                {
                   
                    if (Namebox.Text == "")
                    {
                        Namebox.BackColor = Color.Red;
                    }
                    else
                    {
                        Namebox.BackColor = Color.White;
                    }

                    if (Passwordbox.Text == "")
                    {
                        Passwordbox.BackColor = Color.Red;
                    }
                    else
                    {
                        Passwordbox.BackColor = Color.White;
                    }

                    if (bgroup.Text == "")
                    {
                        bgroup.BackColor = Color.Red;
                    }
                    else
                    {
                        bgroup.BackColor = Color.White;
                    }

                    if (Ad.Text == "")
                    {
                        Ad.BackColor = Color.Red;
                    }
                    else
                    {
                        Ad.BackColor = Color.White;
                    }

                    if (Confirmpasswordbox.Text == "")
                    {
                        Confirmpasswordbox.BackColor = Color.Red;
                    }
                    else
                    {
                        Confirmpasswordbox.BackColor = Color.White;
                    }

                    if (PhoneNo.Text == "")
                    {
                        PhoneNo.BackColor = Color.Red;
                    }
                    else
                    {
                        PhoneNo.BackColor = Color.White;
                    }
                    if (textBox1.Text == "")
                    {
                        textBox1.BackColor = Color.Red;
                    }
                    else
                    {
                        textBox1.BackColor = Color.White;
                    }

                    MessageBox.Show("Please fillup  markable box");
                }
            }
            catch(Exception)
            {
                MessageBox.Show("Please fillup all information");
            }
               
        }

        private void Back_Click(object sender, EventArgs e)
        {
            Start l = new Start();
            l.Show();
            this.Hide();
        }

        private void SignUp_Load(object sender, EventArgs e)
        {

        }

        private void SignUp_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
