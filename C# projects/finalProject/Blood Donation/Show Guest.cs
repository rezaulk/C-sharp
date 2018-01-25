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
    public partial class Show_Guest : Form
    {
        Admin a;
        public Show_Guest()
        {
            InitializeComponent();
        }
        public Show_Guest(Admin a)
        {
            InitializeComponent();
            this.a = a;
        }


        private void Show_Guest_Load(object sender, EventArgs e)
        {
            BloodDataContext D = new BloodDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=F:\C# projects\finalProject\Blood Donation\Blood.mdf;Integrated Security=True;Connect Timeout=30");
            dataGridView1.DataSource = D.GuestInfos;
        }
        public void showde() 
        {
            BloodDataContext D = new BloodDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=F:\C# projects\finalProject\Blood Donation\Blood.mdf;Integrated Security=True;Connect Timeout=30");
            dataGridView1.DataSource = D.GuestInfos;
        }



        private void button1_Click(object sender, EventArgs e)
        {
            Admin a = new Admin();
            a.Show();
            this.Hide();
        }
        public void showd()
        {
            BloodDataContext D = new BloodDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=F:\C# projects\finalProject\Blood Donation\Blood.mdf;Integrated Security=True;Connect Timeout=30");
            dataGridView1.DataSource = D.DonorInfos;
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            BloodDataContext D = new BloodDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=F:\C# projects\finalProject\Blood Donation\Blood.mdf;Integrated Security=True;Connect Timeout=30");
            dataGridView1.DataSource = D.DonorInfos;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            DeleteGuest d = new DeleteGuest(this);
            d.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
         
            a.Show();
            this.Hide();
        }

        private void Show_Guest_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}

      