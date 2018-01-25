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
    public partial class AdminList : Form
    {
        Admin a;
        public AdminList()
        {
            InitializeComponent();
        }
        public AdminList(Admin a)
        {
            InitializeComponent();
            this.a = a;
        }


        private void AdminList_Load(object sender, EventArgs e)
        {
            BloodDataContext D = new BloodDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=F:\C# projects\finalProject\Blood Donation\Blood.mdf;Integrated Security=True;Connect Timeout=30");
            var x = (from a in D.AdminInfos

                     select new { a.AdminId,a.Name, a.Phone, a.Username,}).ToList();

            dataGridView1.DataSource = x;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            a.Show();
        }

        private void AdminList_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
