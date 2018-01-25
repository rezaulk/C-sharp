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
    public partial class ConfirmRequest : Form
    {
        Donor don;
        int Dono;
       Requests r;
        public ConfirmRequest()
        {
            InitializeComponent();
        }
        public ConfirmRequest(Requests r, Donor don,int Dono)
        {
            InitializeComponent();
            this.don = don;
            this.Dono = Dono;
            this.r=r;

          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BloodDataContext D = new BloodDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=F:\C# projects\finalProject\Blood Donation\Blood.mdf;Integrated Security=True;Connect Timeout=30");
            var x = from a in D.RequestInfos   
                  where a.Gid == Convert.ToInt32(textBox1.Text)
                         select a;
            x.First().Status = "Donated";

            var y = from a in D.DonorInfos
                    where a.DonorId == Dono 
                    select a;
            y.First().Status = "Donated";        
            MessageBox.Show("Confirm Request");
            D.SubmitChanges();
            this.Hide();
       
            don.show();       
        }

        private void Confirmrequest_Load(object sender, EventArgs e)
        {

        }

        private void Confirmrequest_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            don.Show();
            this.Hide();
        }
    }
}
