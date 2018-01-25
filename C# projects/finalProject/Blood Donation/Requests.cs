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
    public partial class Requests : Form
    {
        int s;
        Donor don;
        public Requests()
        {
            InitializeComponent();
        }
        public Requests(Donor don,int x)
        {
            this.s = x;
            this.don = don;
            InitializeComponent();
        }
        public void show()
        {
            BloodDataContext D = new BloodDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=F:\C# projects\finalProject\Blood Donation\Blood.mdf;Integrated Security=True;Connect Timeout=30");
            var x = (from a in D.RequestInfos
                     join b in D.GuestInfos on a.Gid equals b.Gid
                     where (a.DonorId == s && a.Status.Equals(null))

                     select new { a.GuestInfo.GName, a.GuestInfo.GPhone, a.GuestInfo.GAddress, a.GuestInfo.Gid }).ToList();

            dataGridView1.DataSource = x;
            D.SubmitChanges();
        }

        private void Requests_Load(object sender, EventArgs e)
        {
            BloodDataContext D = new BloodDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=F:\C# projects\finalProject\Blood Donation\Blood.mdf;Integrated Security=True;Connect Timeout=30");
            var x = (from a in D.RequestInfos
                     join b in D.GuestInfos on a.Gid equals b.Gid
                     where (a.DonorId == s && a.Status.Equals(null))

                     select new { a.GuestInfo.GName, a.GuestInfo.GPhone, a.GuestInfo.GAddress,a.GuestInfo.Gid}).ToList();

            dataGridView1.DataSource = x;
            D.SubmitChanges();
        }
        

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            don.Show();
           
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ConfirmRequest c = new ConfirmRequest(this,this.don,s);
            c.Show();

        }

        private void Requests_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
