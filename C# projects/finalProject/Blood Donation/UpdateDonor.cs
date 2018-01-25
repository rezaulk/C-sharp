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
    public partial class UpdateDonor : Form
    {
        int d;
        Donor donor;
        public UpdateDonor()
        {
            InitializeComponent();
        }
        public UpdateDonor(Donor Dono,int d)
        {
            InitializeComponent();
            this.d = d;
            this.donor = Dono;
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

            var x = from a in D.DonorInfos
                    where a.DonorId == d
                    select a;
            if (donornam.Text != "")
            {

               // var a = x.First().Name;
                //donornam.Text = a;
                x.First().Name = donornam.Text;

            }
            if (add.Text != "")
            {
                x.First().Address = add.Text;
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
            //Donor c = new Donor();
            donor.Show();
            donor.show();
            this.Hide();
           
           
            
        }
        public void show()
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Donor c = new Donor();
            donor.Show();
            this.Hide();
        }

        private void update_Load(object sender, EventArgs e)
        {

        }

        private void update_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
