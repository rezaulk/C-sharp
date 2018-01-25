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
    public partial class Request : MetroFramework.Forms.MetroForm
    {
        int did;
        public Request(int x)
        {
            this.did = x;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BloodDataContext D = new BloodDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=G:\Blood\Blood Donation\Blood.mdf;Integrated Security=True;Connect Timeout=30");

            GuestInfo pr = new GuestInfo();
            if (textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "")
            {
                pr.GName = textBox2.Text;
                pr.GPhone = textBox3.Text;
                pr.GAddress = textBox4.Text;
                D.GuestInfos.InsertOnSubmit(pr);
                D.SubmitChanges();

                RequestInfo rq = new RequestInfo();
                rq.DonorId = did;
                rq.Gphone = textBox3.Text;

                var x = from a in D.GuestInfos
                        where a.GPhone.Equals(textBox3.Text)
                        select a;
                int str = x.First().Gid;

                rq.Gid = str;
               
                D.RequestInfos.InsertOnSubmit(rq);
                D.SubmitChanges();
               
                MessageBox.Show("Request Send");

                allrequest req = new allrequest();
                req.Donorid = did;
                req.Name = textBox2.Text;
                req.Phone = textBox3.Text;
                req.Address = textBox4.Text;

                var p = from a in D.RequestInfos
                        where a.Gphone.Equals(textBox3.Text)
                        select a;
           
                int stra = p.First().RequestId;
             
                req.requestid = stra;
                req.identity = "Guest";
               
                D.allrequests.InsertOnSubmit(req);
                D.SubmitChanges();
               
                this.Hide();    
            }
            else
            {
                MessageBox.Show("Please fill up all information");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //visitor v = new visitor();
            //v.Show();74
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