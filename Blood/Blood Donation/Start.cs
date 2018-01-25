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
    public partial class Start : MetroFramework.Forms.MetroForm
    {
        public Start()
        {
            InitializeComponent();
        }
        private void metroButton3_Click(object sender, EventArgs e)
        {
            BloodDataContext D = new BloodDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=G:\Blood\Blood Donation\Blood.mdf;Integrated Security=True;Connect Timeout=30");

            string s = metroTextBox1.Text;
            if (metroTextBox1.Text != "" && metroTextBox2.Text != "")
            {
                if (s[0] == '$')
                {
                    try
                    {
                        var y = from b in D.DonorInfos
                                where b.UserID.Equals(metroTextBox1.Text)
                                select b;

                        if ((y.FirstOrDefault().Password == metroTextBox2.Text))
                        {
                            Admin admin = new Admin(this, metroTextBox1.Text);
                            admin.Show();
                            metroTextBox1.Clear();
                            metroTextBox2.Clear();
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
                                where a.UserID == metroTextBox1.Text
                                select a;
                        
                        if (x.FirstOrDefault().Password == metroTextBox2.Text)
                        {
                            Donor donor = new Donor(this, metroTextBox2.Text);
                            
                            donor.Show();
                            metroTextBox1.Clear();
                            metroTextBox2.Clear();
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

      
       
        private void metroButton1_Click(object sender, EventArgs e)
        {
            SignUp s = new SignUp();
            s.Show();
            this.Hide();
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            Visitor G = new Visitor();
            G.Show();
            this.Hide();
        }

        private void Start_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }


    }
}
