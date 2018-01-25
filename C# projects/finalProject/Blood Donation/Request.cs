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
    public partial class Request : Form
    {
        public Request()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BloodDataContext D = new BloodDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=F:\C# projects\finalProject\Blood Donation\Blood.mdf;Integrated Security=True;Connect Timeout=30");

            GuestInfo pr = new GuestInfo();
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "")
            {
                pr.GName = textBox2.Text;
                pr.GPhone = textBox3.Text;
                pr.GAddress = textBox4.Text;
                D.GuestInfos.InsertOnSubmit(pr);
                D.SubmitChanges();

                RequestInfo rq = new RequestInfo();
                rq.DonorId = Convert.ToInt32(textBox1.Text);
                rq.Gphone = textBox3.Text;

                var x = from a in D.GuestInfos
                        where a.GPhone.Equals(textBox3.Text)
                        select a;
                int str = x.First().Gid;

                rq.Gid = str;

                D.RequestInfos.InsertOnSubmit(rq);
                MessageBox.Show("Request Send");
                this.Hide();
                D.SubmitChanges();
            }
            else
            {
                MessageBox.Show("Please fill up all information");
            }
        }
       

        private void button2_Click(object sender, EventArgs e)
        {
            //visitor v = new visitor();
            //v.Show();
            this.Hide();
        }

        private void request_Load(object sender, EventArgs e)
        {

        }

        private void request_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
