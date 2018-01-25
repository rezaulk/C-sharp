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
    public partial class Donor : MetroFramework.Forms.MetroForm
    {
        Start s;
        string id;
        int m;
        public Donor()
        {
            InitializeComponent();
        }
        public Donor(Start s,string id)
        {
            InitializeComponent();
            this.s = s;
            this.id = id;
        }

        private void Donor_Load(object sender, EventArgs e)
        {
            BloodDataContext D = new BloodDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=G:\Blood\Blood Donation\Blood.mdf;Integrated Security=True;Connect Timeout=30");

            var x = from a in D.DonorInfos
                    where id == a.Password
                    select a;

            metroLabel4.Text = x.First().DName;
            metroLabel5.Text = Convert.ToString(x.First().DonorId);
            metroLabel7.Text = x.First().BloodGroup;
            metroLabel9.Text = x.First().DAddress;
            metroLabel11.Text = x.First().DPhone;
            this.m = Convert.ToInt32(x.First().DonorId);
            metroLabel2.Text = x.First().Password;
            metroLabel15.Text = x.First().UserID;
            metroLabel13.Text = x.First().Status;

            dshow();

            D.SubmitChanges();
           
        }
        public void dshow()
        {
            BloodDataContext D = new BloodDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=G:\Blood\Blood Donation\Blood.mdf;Integrated Security=True;Connect Timeout=30");
            //var zi = (from a in D.RequestInfos
            //         join b in D.GuestInfos on a.Gid equals b.Gid
            //         where (a.DonorId == Convert.ToInt32(metroLabel5.Text) && a.Status.Equals(null))

            //          select new { a.GuestInfo.GName,a.GuestInfo.GPhone,a.GuestInfo.GAddress,a.DonorInfo.DonorId }).ToList();
            //foreach (var a in zi)
            //{
            //    D.allrequests.InsertAllOnSubmit(a); 
            //}

            metroButton5.Hide();
            metroButton4.Hide();
            metroButton6.Hide();
            var z = (from a in D.allrequests 
                     where (a.Donorid==m && (a.Status.Equals(null))&& a.Status.Equals(null))
                     select new {a.reqid,a.identity,a.Name,a.Phone,a.Address }).ToList();                             ///show requests
            if (z.Any())
            {
                metroButton3.Show();
                metroGrid1.DataSource = z;
            }
            else
            {
                metroButton3.Hide();
                metroGrid1.DataSource = z;
            }
            var y = (from a in D.RequestInfos
                     join b in D.GuestInfos on a.Gid equals b.Gid

                     where (a.DonorId == m && a.Status.Equals("Donated"))

                     select new { a.GuestInfo.GName, a.GuestInfo.GPhone, a.GuestInfo.GAddress, a.Status }).ToList();    /// show  Guest (Donated)
            if (y.Any())
            {
                metroGrid2.DataSource = y;
                metroButton5.Show();
            }
            else
            {
                metroButton4.Show();
              
                var t = (from a in D.DonorInfos 

                        where a.BloodGroup.Equals(metroLabel7.Text)&& (!a.DonorId.Equals(m))&&(a.Status.Equals(null))       ///show Donors
                        select new { a.DonorId, a.DName, a.DAddress, a.Status }).ToList();
                metroGrid2.DataSource = t;
            }
        }
   
        private void Donor_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            BloodDataContext D = new BloodDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=G:\Blood\Blood Donation\Blood.mdf;Integrated Security=True;Connect Timeout=30");

            var x = from a in D.DonorInfos
                    where a.Password.Equals(id)
                    select a;
            x.First().Status = null;
            metroLabel13.Text="";
            D.SubmitChanges();

       
        }

         private void metroButton1_Click(object sender, EventArgs e)
        {
            BloodDataContext D = new BloodDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=G:\Blood\Blood Donation\Blood.mdf;Integrated Security=True;Connect Timeout=30");
            //Information info = new Information();
            //Donor_Info pr = new Donor_Info
            //{
            //    Name = Convert.ToString(donornam.Text),
            //    Address = add.Text,
            //    Password = pass.Text,
            //    Phone = Convert.ToInt32(ph.Text),
            //};

            var x = from a in D.DonorInfos
                    where a.DonorId == m
                    select a;
            if (metroTextBox1.Text != "")
            {
                x.First().DName = metroTextBox1.Text;
                metroLabel14.Text = metroTextBox1.Text;
                metroTextBox1.Text = "";

            }
            if (metroTextBox2.Text != "")
            {
                x.First().DAddress = metroTextBox2.Text;
                metroLabel19.Text = metroTextBox2.Text;
                metroTextBox2.Text ="";
            }
            if (metroTextBox4.Text != "")
            {
                x.First().Password = metroTextBox4.Text;
                metroLabel2.Text = metroTextBox4.Text;
                metroTextBox4.Text = "";
            }
            if (metroTextBox3.Text != "")
            {
                x.First().DPhone = metroTextBox3.Text;
                metroLabel11.Text = metroTextBox3.Text;
                metroTextBox3.Text = "";

            }
            D.SubmitChanges();
            MessageBox.Show("Successfully Update");
        }

         private void metroButton2_Click(object sender, EventArgs e)
         {
             BloodDataContext D = new BloodDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=G:\Blood\Blood Donation\Blood.mdf;Integrated Security=True;Connect Timeout=30");

             var x = from a in D.DonorInfos
                     where a.Password.Equals(id)
                     select a;
             x.First().Status = null;
             metroLabel13.Text = "";
             D.SubmitChanges();
         }

         private void metroButton3_Click(object sender, EventArgs e)                         ////confirm request
         {
             if (metroLabel13.Text.Equals(""))
             {
                 BloodDataContext D = new BloodDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=G:\Blood\Blood Donation\Blood.mdf;Integrated Security=True;Connect Timeout=30");
                 int rowIndex = metroGrid1.CurrentCell.RowIndex;

                 string did = Convert.ToString(metroGrid1.Rows[rowIndex].Cells[1].Value);
                 string am = Convert.ToString(metroGrid1.Rows[rowIndex].Cells[3].Value);
                 int id = Convert.ToInt32(metroGrid1.Rows[rowIndex].Cells[0].Value);

                 if (did == "Guest")
                 {
                     var x = from a in D.RequestInfos
                             where a.Gphone == am
                             select a;
                     x.First().Status = "Donated";

                     var z = from a in D.allrequests
                             //,,join b in D.RequestInfos on a.requestid equals b.RequestId
                             where (a.reqid.Equals(id))
                             select a;
                     z.First().Status="Donate";

                     var y = from a in D.DonorInfos
                             where a.DonorId == m
                             select a;
                     y.First().Status = "Donated";
                     MessageBox.Show("Confirm Request");
                     metroLabel13.Text = "Donated";
                     D.SubmitChanges();
                 }
                 else
                 {
                     var x = from a in D.Rs
                             where a.Phone == am
                             select a;
             
                     x.First().Status = "Donated";

                     var z = from a in D.allrequests
                             join b in D.Rs on a.Rid equals b.Rid
                             where (a.reqid==id)
                             select a;
                     
                     z.First().Status = "Donated";
                     D.SubmitChanges();

                     var y = from a in D.DonorInfos 
                             where a.DonorId == m
                             select a;
                     y.First().Status = "Donated";
                     MessageBox.Show("Confirm Request");
                     metroLabel13.Text = "Donated";
                     D.SubmitChanges();
                 }

                 dshow();
             }
             else
             {
                 MessageBox.Show("Already Donated ");
             }
         }

         private void button3_Click(object sender, EventArgs e)
         {
             Start l = new Start();
             l.Show();
             this.Hide();
         }

         private void metroGrid2_CellContentClick(object sender, DataGridViewCellEventArgs e)
         {

         }

         private void panel1_Paint(object sender, PaintEventArgs e)
         {

         }

         private void metroButton4_Click(object sender, EventArgs e)                     ///send request donor to donor
         {
             BloodDataContext D = new BloodDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=G:\Blood\Blood Donation\Blood.mdf;Integrated Security=True;Connect Timeout=30");
             int rowIndex = metroGrid2.CurrentCell.RowIndex;

             int did = Convert.ToInt32(metroGrid2.Rows[rowIndex].Cells[0].Value);

             R rq = new R();
             rq.DonorId = did;
             rq.Did= m;
             rq.Phone = metroLabel11.Text;
             rq.Identity = "Donor";

             D.Rs.InsertOnSubmit(rq);
             D.SubmitChanges();

             allrequest req = new allrequest();
             req.Donorid = did;
             req.Name = metroLabel4.Text;
             req.Phone = metroLabel11.Text;
             req.Address = metroLabel9.Text;
             req.identity = "Donor";

             var p = from a in D.Rs
                     where a.Did.Equals(m)
                     select a;

             int stra = p.First().Rid;
                                                          
             req.Rid = stra;
             req.identity = "Donor";
          
             D.allrequests.InsertOnSubmit(req);
             D.SubmitChanges();

             //var x = from a in D.RequestInfos
             //        where a.Gid == did
             //        select a;
             //x.First().Status = "Donated";

             //var y = from a in D.DonorInfos
             //        where a.DonorId == m
             //        select a;
             //y.First().Status = "Donated";
             //D.RequestInfos.InsertOnSubmit(rq);
             MessageBox.Show("Request Send");
             D.SubmitChanges();
         }

         private void metroButton5_Click(object sender, EventArgs e)
         {
             BloodDataContext D = new BloodDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=G:\Blood\Blood Donation\Blood.mdf;Integrated Security=True;Connect Timeout=30");
             metroButton5.Hide();
             metroButton4.Show();
             metroButton6.Show();
             var t = (from a in D.DonorInfos
                     where (a.BloodGroup.Equals(metroLabel7.Text)&& a.Status.Equals(null)&& (!a.DonorId.Equals(m)))
                     select new { a.DonorId, a.DName, a.DPhone, a.DAddress }).ToList();
             metroGrid2.DataSource = t;
         }

         private void metroButton6_Click(object sender, EventArgs e)
         {
             dshow();
         }
    }
}
