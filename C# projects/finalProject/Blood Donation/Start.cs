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
    public partial class Start : Form
    {
        public Start()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BloodDataContext D = new BloodDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=F:\C# projects\finalProject\Blood Donation\Blood.mdf;Integrated Security=True;Connect Timeout=30");
            
            string s = textBox1.Text;
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                if (s[0] == '$')
                {
                    try
                    {
                        var y = from b in D.AdminInfos
                                where b.Username.Equals(textBox1.Text)
                                select b;

                        if ((y.FirstOrDefault().Password == textBox2.Text))
                        {
                            Admin admin = new Admin(this, textBox1.Text);
                            admin.Show();
                            textBox1.Clear();
                            textBox2.Clear();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Wrong Password");
                        }

                    }
                    catch (NullReferenceException)
                    {
                        MessageBox.Show("Wrong Username");
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Fill your Username and Password");
                    }

                }
                else
                {
                    try
                    {

                        var x = from a in D.DonorInfos
                                where a.UserID == textBox1.Text
                                select a;
                        if (x.FirstOrDefault().Password == textBox2.Text)
                        {
                            Donor donor = new Donor(this, textBox2.Text);
                            donor.Show();
                            textBox1.Clear();
                            textBox2.Clear();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Wrong Password");
                        }
                    }
                    catch (NullReferenceException)
                    {
                        MessageBox.Show("Wrong UserId");
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Fill your Username and Password");
                    }
                }
            }
            else
            {
                MessageBox.Show("Fill your Username and Password");
            }

                
        }

        private void Start_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Visitor G = new Visitor();
            G.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SignUp s = new SignUp();
            s.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Start_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
