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
    public partial class Donor : Form
    {
        Start s;
        string id;
        int m;
        public Donor()
        {
            InitializeComponent();
        }
        public Donor(Start s,string id)
        {
            InitializeComponent();
            this.s = s;
            this.id = id;
        }

        private void label10_Click(object sender, EventArgs e)
        {
            
        }

        private void Donor_Load(object sender, EventArgs e)
        {
            BloodDataContext D = new BloodDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=F:\C# projects\finalProject\Blood Donation\Blood.mdf;Integrated Security=True;Connect Timeout=30");

            var x = from a in D.DonorInfos
                    where id == a.Password
                    select a;

            label10.Text = x.First().Name; 
            label9.Text = Convert.ToString(x.First().DonorId);
            label8.Text = x.First().BloodGroup;
            label7.Text = x.First().Address;
            label6.Text = x.First().Phone;
            this.m = Convert.ToInt32(x.First().DonorId);
            label11.Text = x.First().UserID;
            label13.Text = x.First().Status;
           
        }
        public void show()
        {
            BloodDataContext D = new BloodDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\MD. REZA UL KARIM\Documents\finalProject\Blood Donation\Blood.mdf;Integrated Security=True;Connect Timeout=30");

            var x = from a in D.DonorInfos
                    where id == a.Password
                    select a;

            label10.Text = x.First().Name;
            label9.Text = Convert.ToString(x.First().DonorId);
            label8.Text = x.First().BloodGroup;
            label7.Text = x.First().Address;
            this.m = Convert.ToInt32(x.First().DonorId);
            label6.Text = x.First().Phone;
            label13.Text = x.First().Status;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UpdateDonor u = new UpdateDonor(this, Convert.ToInt32(label9.Text));
            u.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            if (label13.Text.Equals(""))
            {
                Requests r = new Requests(this, m);
                this.Hide();
                r.Show();
            }
            else
            {
                MessageBox.Show("Already Donated ");
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            s.Show();
        }

        private void Donor_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            BloodDataContext D = new BloodDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\MD. REZA UL KARIM\Documents\finalProject\Blood Donation\Blood.mdf;Integrated Security=True;Connect Timeout=30");

            var x = from a in D.DonorInfos
                    where a.Password.Equals(id)
                    select a;
            x.First().Status = null;
            label13.Text ="";
            D.SubmitChanges();

            show();
        }
    }
}
