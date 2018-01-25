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
    public partial class Showdonorlist : Form
    {
        Admin a;
        public Showdonorlist()
        {
            InitializeComponent();
        }
        public Showdonorlist(Admin a)
        {
            InitializeComponent();
            this.a = a;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            a.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void showdonorlist_Load(object sender, EventArgs e)
        {
            BloodDataContext D = new BloodDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=F:\C# projects\finalProject\Blood Donation\Blood.mdf;Integrated Security=True;Connect Timeout=30");
            dataGridView1.DataSource = D.DonorInfos;
        }
        public void showd()
        {
            BloodDataContext D = new BloodDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=F:\C# projects\finalProject\Blood Donation\Blood.mdf;Integrated Security=True;Connect Timeout=30");
            dataGridView1.DataSource = D.DonorInfos;
        }

        private void button2_Click(object sender, EventArgs e)
        {
           // showdonorlist d = new showdonorlist();
            ConfirmDelete c = new ConfirmDelete(this);
            c.Show();

        }

        private void showdonorlist_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
