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
    public partial class UpdateAdmin : Form
    {
        Admin ad;
        int s;
        public UpdateAdmin()
        {
            InitializeComponent();
        }
        public UpdateAdmin(Admin ad,int s)
        {
            InitializeComponent();
        this.ad=ad;
        this.s=s; 
        }

        private void UpdateAdmin_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            BloodDataContext D = new BloodDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=F:\C# projects\finalProject\Blood Donation\Blood.mdf;Integrated Security=True;Connect Timeout=30");
            //Information info = new Information();
            //Donor_Info pr = new Donor_Info
            //{
            //    Name = Convert.ToString(donornam.Text),
            //    Address = add.Text,
            //    Password = pass.Text,
            //    Phone = Convert.ToInt32(ph.Text),
            //};
            var x = from a in D.AdminInfos
                    where a.AdminId.Equals(s)
           
                   select a;

            string st=textBox1.Text;
            if (st[0] =='$')
            {
                if (donornam.Text != "")
                {
                    //var a = x.First().Name;
                    // donornam.Text =x.First().Name;
                    x.First().Name = donornam.Text;
                }
                if (textBox1.Text != "")
                {
                    x.First().Username = textBox1.Text;
                }

                if (pass.Text != "")
                {
                    x.First().Password = pass.Text;
                }
                if (ph.Text != "")
                {
                    x.First().Phone = ph.Text;
                }

                //D.Donor_Infos.InsertOnSubmit(pr);
                D.SubmitChanges();
                MessageBox.Show("Successfully Update");
                ad.Show();
                ad.show();
                this.Hide();
            }
            else if (s.Equals(null))
            {
                if (donornam.Text != "")
                {
                    //var a = x.First().Name;
                    // donornam.Text =x.First().Name;
                    x.First().Name = donornam.Text;
                }


                if (pass.Text != "")
                {
                    x.First().Password = pass.Text;
                }
                if (ph.Text != "")
                {
                    x.First().Phone = ph.Text;
                }
                D.SubmitChanges();
                MessageBox.Show("Successfully Update");
                ad.Show();
                ad.show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Update user name with $");
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Donor c = new Donor();
            ad.Show();
            this.Hide();
        }

        private void UpdateAdmin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
