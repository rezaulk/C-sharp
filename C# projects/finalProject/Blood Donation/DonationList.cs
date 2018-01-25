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
    public partial class DonationList : Form
    {
        Admin a;
        public DonationList()
        {
            InitializeComponent();
        }
        public DonationList(Admin a)
        {
            InitializeComponent();
            this.a = a;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DonationList_Load(object sender, EventArgs e)
        {
            BloodDataContext D = new BloodDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=F:\C# projects\finalProject\Blood Donation\Blood.mdf;Integrated Security=True;Connect Timeout=30");
            var x = (from a in D.RequestInfos join b in D.GuestInfos  on a.Gid equals b.Gid join c in D.DonorInfos on a.DonorId equals c.DonorId 
               
                     
           select new {a.DonorInfo.Name,a.DonorInfo.Phone,a.DonorInfo.Address, a.GuestInfo.GName,a.GuestInfo.GPhone,a.GuestInfo.GAddress,a.Status}).ToList();

            dataGridView1.DataSource = x;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            a.Show();
            this.Hide(); 
        }

        private void DonationList_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
