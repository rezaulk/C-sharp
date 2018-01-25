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
    public partial class Admin : Form
    {
        Start ad;
        string s;
        public Admin()
        {
            InitializeComponent();
        }
        public Admin(Start ad,string s) 
        {
            InitializeComponent();
            this.ad = ad;
            this.s = s;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Start l = new Start();
            l.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Showdonorlist s=new Showdonorlist(this);
            s.Show();
            this.Hide();
        }
        public void show()
        {
            BloodDataContext D = new BloodDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\MD. REZA UL KARIM\Documents\finalProject\Blood Donation\Blood.mdf;Integrated Security=True;Connect Timeout=30");

            var x = from a in D.AdminInfos
                    where Adminid == a.AdminId
                    select a;

            label8.Text = x.First().Name;
            label3.Text = x.First().Username;
            label2.Text = Convert.ToString(x.First().AdminId);
            label5.Text = x.First().Phone;
        }
        int Adminid;
        private void Admin_Load(object sender, EventArgs e)
        {
            BloodDataContext D = new BloodDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=F:\C# projects\finalProject\Blood Donation\Blood.mdf;Integrated Security=True;Connect Timeout=30");
            var x = from a in D.AdminInfos
                    where a.Username.Equals(s)
                    select a;
            label8.Text = x.First().Name;
            label5.Text = x.First().Phone;
            label3.Text = x.First().Username;
           // label2.Text = x.First().AdminId; 
            label2.Text = Convert.ToString(x.First().AdminId);
            Adminid = x.First().AdminId;
            label9.Text = x.First().Password;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UpdateAdmin u = new UpdateAdmin(this, Convert.ToInt32(label2.Text)); 
            u.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DonationList D = new DonationList(this);
            D.Show();
            this.Hide();
        }

        private void Admin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Show_Guest s = new Show_Guest(this);
            s.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            AddAdmin a = new AddAdmin(this); 
            a.Show();
            this.Hide();

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            AdminList a = new AdminList(this);
            a.Show();
            this.Hide();

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
    }
}
