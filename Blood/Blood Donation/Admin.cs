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
    public partial class Admin : MetroFramework.Forms.MetroForm
    {
        Start ad;
        string s;
        public Admin()
        {
            InitializeComponent();
        }
        public Admin(Start ad,string s) 
        {
            InitializeComponent();
            this.ad = ad;
            this.s = s;
        }
        int Adminid;
        string Blood;
        private void Admin_Load(object sender, EventArgs e)
        {
            BloodDataContext D = new BloodDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=G:\Blood\Blood Donation\Blood.mdf;Integrated Security=True;Connect Timeout=30");
            var x = from a in D.DonorInfos
                    where a.UserID.Equals(s)
                    select a;
            Adminid = x.First().DonorId;
            Blood = x.First().BloodGroup;

            metroLabel10.Text= x.First().DName;
            metroLabel11.Text= x.First().DPhone;
            metroLabel13.Text = x.First().UserID; 
            metroLabel15.Text= Convert.ToString(x.First().DonorId);
            metroLabel17.Text= x.First().Password;
            metroLabel20.Text = x.First().Status;

            metroLabel25.Text = x.First().BloodGroup;
            metroLabel26.Text = x.First().DAddress;
           
            metroButton10.Hide();
            metroButton9.Hide();
            metroButton11.Hide();
            metroButton7.Hide();
           // metroButton1.Hide();

            //var w = (from a in D.allrequests
            //         where a.Status.Equals("Donated")
            //         select new { a.DonorInfo.DName, a.DonorInfo.DPhone, a.DonorInfo.DAddress, a.identity, a.Name, a.Phone, a.Address }).ToList();
            //metroGrid1.DataSource = w;
            show();
        }
        public void show()
        {
            BloodDataContext D = new BloodDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=G:\Blood\Blood Donation\Blood.mdf;Integrated Security=True;Connect Timeout=30");
            metroButton10.Show();
            metroButton9.Hide();
            metroButton11.Hide();

            var l = from a in D.DonorInfos
                    where a.identity.Equals("Donor")      ///show Donors
                    select a;
            metroGrid2.DataSource = l;

            var w = (from a in D.allrequests
                     where a.Status.Equals("Donated")
                     select new { a.DonorInfo.DName, a.DonorInfo.DPhone, a.DonorInfo.DAddress, a.identity, a.Name, a.Phone, a.Address }).ToList();
            metroGrid1.DataSource = w;

            metroGrid3.DataSource = D.GuestInfos;

            var k = (from a in D.RequestInfos
                     join b in D.GuestInfos on a.Gid equals b.Gid

                     where (a.DonorId == Adminid && a.Status.Equals("Donated"))

                     select new { a.GuestInfo.GName, a.GuestInfo.GPhone, a.GuestInfo.GAddress, a.Status }).ToList();    /// show  Guest (Donated)
            if (k.Any())
            {
                metroGrid6.DataSource = k;
                metroButton10.Show();
            }
            else
            {
                var t = (from a in D.DonorInfos
                         where a.BloodGroup.Equals(Blood) && (!a.DonorId.Equals(Adminid)) && (a.Status.Equals(null))       ///show Donors
                         select new { a.DonorId, a.DName, a.DAddress, a.Status }).ToList();
                metroGrid6.DataSource = t;
                metroButton10.Hide();
                metroButton9.Show();
                metroButton11.Hide();
            }

            metroButton7.Hide();
            var z = (from a in D.allrequests
                     where (a.Donorid == Adminid && (a.Status.Equals(null)))
                     select new { a.reqid, a.identity, a.Name, a.Phone, a.Address }).ToList();                             ///show requests
            if (z.Any())
            {
                metroButton7.Show();
                metroGrid5.DataSource = z;
            }
            else
            {
                metroButton7.Hide();
                metroGrid5.DataSource = z;
            }
            var h = (from a in D.DonorInfos
                     where a.UserID[0].Equals("$")                                                   ///show admins
                     select new { a.DonorId, a.DName, a.DAddress, a.Status }).ToList();
            metroGrid4.DataSource = h;
            
        }

        private void Admin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            BloodDataContext D = new BloodDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=G:\Blood\Blood Donation\Blood.mdf;Integrated Security=True;Connect Timeout=30");

            var x = from a in D.DonorInfos
                    where a.DonorId.Equals(Adminid)
                    select a;

            if (metroTextBox1.Text!="")
            {
                metroLabel10.Text = metroTextBox1.Text;
                x.First().DName = Convert.ToString(metroTextBox1.Text);
                metroTextBox1.Text = "";

            }
            if (metroTextBox3.Text != "")
            {
                string st = metroTextBox3.Text;
                if (st[0] == '$')
                {
                    x.First().UserID = metroTextBox3.Text;
                    metroLabel13.Text = metroTextBox3.Text;
                    metroTextBox3.Text = "";

                }
                else
                {
                    MessageBox.Show("Update user name with $");
                }
            }

            if (metroTextBox4.Text != "")
            {
                x.First().Password = metroTextBox4.Text;
                metroLabel17.Text= metroTextBox4.Text;
                metroTextBox4.Text = "";
            }

            if (metroTextBox2.Text != "")
            {
                x.First().DPhone = metroTextBox2.Text;
                metroLabel11.Text = metroTextBox2.Text;
                metroTextBox2.Text = ""; 

            }
            if (metroTextBox9.Text != "")
            {
                x.First().DAddress = metroTextBox9.Text;
                metroLabel26.Text = metroTextBox9.Text;
                metroTextBox9.Text = "";
            }

            D.SubmitChanges();
            MessageBox.Show("Successfully Update");
            show();
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            BloodDataContext D = new BloodDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=G:\Blood\Blood Donation\Blood.mdf;Integrated Security=True;Connect Timeout=30");
            string a = metroTextBox8.Text;
        
            DonorInfo pr = new DonorInfo();

            try
            {
                if (metroTextBox5.Text != "" && metroTextBox10.Text != "" && metroTextBox8.Text != "" && metroTextBox7.Text != "" && metroComboBox1.Text != "" && metroTextBox6.Text != ""&&metroComboBox2.Text!="")
                {
                    if (metroComboBox2.Text.Equals("Admin"))
                    {
                        if (metroTextBox7.Text[0].Equals("$"))
                        {
                   
                            pr.Password = metroTextBox8.Text;
                            pr.DName = metroTextBox5.Text;
                            pr.DAddress = metroTextBox10.Text;
                            pr.DPhone = metroTextBox6.Text;
                            pr.identity=metroComboBox2.Text;
                            pr.UserID = metroTextBox7.Text;
                            pr.BloodGroup = metroComboBox1.Text;

                            D.DonorInfos.InsertOnSubmit(pr);
                            D.SubmitChanges();

                            MessageBox.Show("Congratulation as Member in our Family");
                            Start l = new Start();
                            l.Show();
                            this.Hide(); 
                        
                        }
                          else
                          {
                              MessageBox.Show("Username start with $");
                          }
                      }
                      else if(metroComboBox2.Text.Equals("Donor"))
                      {
                          if (metroTextBox7.Text[0]!='$')
                          {
                              pr.Password = metroTextBox8.Text;
                              pr.DName = metroTextBox5.Text;
                              pr.DAddress = metroTextBox10.Text;
                              pr.DPhone = metroTextBox6.Text;
                              pr.identity = metroComboBox2.Text;
                              pr.UserID = metroTextBox7.Text;
                              pr.BloodGroup = metroComboBox1.Text;

                              D.DonorInfos.InsertOnSubmit(pr);
                              D.SubmitChanges();

                              MessageBox.Show("Congratulation as Member in our Family");
                              Start l = new Start();
                              l.Show();
                              this.Hide();
                          }
                          else
                          {
                              MessageBox.Show("Username start without $");
                          }
                      }     
                }
                else
                {
                    if (metroTextBox5.Text == "")
                    {
                        metroTextBox5.BackColor = Color.Red;
                    }
                    else
                    {
                        metroTextBox5.BackColor = Color.White;
                    }

                    if (metroTextBox8.Text == "")
                    {
                        metroTextBox8.BackColor = Color.Red;
                    }
                    else
                    {
                        metroTextBox8.BackColor = Color.White;
                    }

                    if (metroComboBox1.Text == "")
                    {
                        metroComboBox1.BackColor = Color.Red;
                    }
                    else
                    {
                        metroComboBox1.BackColor = Color.White;
                    }

                    if (metroTextBox10.Text == "")
                    {
                        metroTextBox10.BackColor = Color.Red;
                    }
                    else
                    {
                        metroTextBox10.BackColor = Color.White;
                    }
                    if (metroTextBox6.Text == "")
                    {
                        metroTextBox6.BackColor = Color.Red;
                    }
                    else
                    {
                        metroTextBox6.BackColor = Color.White;
                    }
                    if (metroTextBox7.Text == "")
                    {
                        metroTextBox7.BackColor = Color.Red;
                    }
                    else
                    {
                        metroTextBox7.BackColor = Color.White;
                    }

                    MessageBox.Show("Please fillup  Text box");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Please fillup all information");
            }
               
        }

        private void metroButton4_Click(object sender, EventArgs e)
        {
            Start l = new Start();
            l.Show();
            this.Hide();
        }

        private void metroButton6_Click(object sender, EventArgs e)
        {
            BloodDataContext D = new BloodDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=G:\Blood\Blood Donation\Blood.mdf;Integrated Security=True;Connect Timeout=30");
            int rowIndex = metroGrid3.CurrentCell.RowIndex;
           
            int did = Convert.ToInt32(metroGrid3.Rows[rowIndex].Cells[0].Value);

            MessageBox.Show(Convert.ToString(did));

            var z = from a in D.RequestInfos
                    where a.Gid == did
                    select a;
            int sam=z.First().RequestId;


            foreach (var a in z)
            {
                D.RequestInfos.DeleteOnSubmit(a);
            }
            D.SubmitChanges();
           
            var y = from b in D.GuestInfos
                    where b.Gid == did
                    select b;
           
            foreach (var b in y)
            {
                D.GuestInfos.DeleteOnSubmit(b);
            }

            var n = from b in D.allrequests
                    where b.requestid.Equals(sam)
                    select b;

            foreach (var b in n)
            {
                D.allrequests.DeleteOnSubmit(b);
            }


            metroGrid3.Rows.RemoveAt(rowIndex);
            D.SubmitChanges();
            metroGrid3.Update();
            show();

        }

        private void metroButton7_Click(object sender, EventArgs e)
        {
            BloodDataContext D = new BloodDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=G:\Blood\Blood Donation\Blood.mdf;Integrated Security=True;Connect Timeout=30");
            if (metroLabel20.Text.Equals(""))
            {
                int rowIndex = metroGrid5.CurrentCell.RowIndex;

                string did = Convert.ToString(metroGrid5.Rows[rowIndex].Cells[1].Value);
                string am = Convert.ToString(metroGrid5.Rows[rowIndex].Cells[3].Value);
                int id = Convert.ToInt32(metroGrid5.Rows[rowIndex].Cells[0].Value);

                if (did == "Guest")
                {
                    MessageBox.Show(am);
                    var x = from a in D.RequestInfos
                            where a.Gphone == am
                            select a;
                    x.First().Status = "Donated";
                    //MessageBox.Show("no");
                    var z = from a in D.allrequests
                            join b in D.RequestInfos on a.requestid equals b.RequestId
                            select a;
                    z.First().Status = "Donated";

                    MessageBox.Show("no");
                    var y = from a in D.DonorInfos
                            where a.DonorId == Adminid
                            select a;
                    y.First().Status = "Donated";
                    MessageBox.Show("Confirm Request");
                    metroLabel20.Text = "Donated";
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
                            where (a.reqid == id)
                            select a;

                    z.First().Status = "Donated";
                    D.SubmitChanges();

                    var y = from a in D.DonorInfos
                            where a.DonorId == Adminid
                            select a;
                    y.First().Status = "Donated";
                    MessageBox.Show("Confirm Request");
                    metroLabel20.Text = "Donated";
                    D.SubmitChanges();
                }
                show();
            }
            else
            {
                MessageBox.Show("Already Donated");
            }

        }

        private void metroButton8_Click(object sender, EventArgs e)
        {
            BloodDataContext D = new BloodDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=G:\Blood\Blood Donation\Blood.mdf;Integrated Security=True;Connect Timeout=30");

            var x = from a in D.DonorInfos
                    where a.DonorId.Equals(Adminid)
                    select a;
            x.First().Status = null;
            metroLabel20.Text = "";
            D.SubmitChanges();
        }

        private void metroGrid3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void metroButton10_Click(object sender, EventArgs e)
        {
            BloodDataContext D = new BloodDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=G:\Blood\Blood Donation\Blood.mdf;Integrated Security=True;Connect Timeout=30");
                metroButton10.Hide();
                metroButton9.Show();
                metroButton11.Show();
            var t = (from a in D.DonorInfos
                     where (a.BloodGroup.Equals(Blood) && a.Status.Equals(null) && (!a.DonorId.Equals(Adminid)))
                     select new { a.DonorId, a.DName, a.DPhone, a.DAddress }).ToList();
            metroGrid6.DataSource = t;
        }

        private void metroButton9_Click(object sender, EventArgs e)
        {
            BloodDataContext D = new BloodDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=G:\Blood\Blood Donation\Blood.mdf;Integrated Security=True;Connect Timeout=30");
            int rowIndex = metroGrid2.CurrentCell.RowIndex;

            int did = Convert.ToInt32(metroGrid6.Rows[rowIndex].Cells[0].Value);

            R rq = new R();
            rq.DonorId = did;
            rq.Did = Adminid;
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
                    where a.Did.Equals(Adminid)
                    select a;

            int stra = p.First().Rid;
            MessageBox.Show("2Request Send");

            req.Rid = stra;
            req.identity = "Donor";
            MessageBox.Show("1Request Send");

            D.allrequests.InsertOnSubmit(req);
            D.SubmitChanges();

            MessageBox.Show("Request Send");
            D.SubmitChanges();
        }

        private void metroButton11_Click(object sender, EventArgs e)
        {
            show();
        }

        private void metroButton5_Click(object sender, EventArgs e)
        {

        }

        private void metroButton12_Click(object sender, EventArgs e)
        {
            BloodDataContext D = new BloodDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=G:\Blood\Blood Donation\Blood.mdf;Integrated Security=True;Connect Timeout=30");
            int rowIndex = metroGrid2.CurrentCell.RowIndex;

            int did = Convert.ToInt32(metroGrid2.Rows[rowIndex].Cells[0].Value);

            var y = from a in D.DonorInfos
                    where a.DonorId == did
                    select a;

            foreach (var a in y)
            {
                D.DonorInfos.DeleteOnSubmit(a);
            }
            D.SubmitChanges();
            MessageBox.Show(Convert.ToString(did));
            var z = from a in D.RequestInfos
                    where a.DonorId == did
                    select a;

            foreach (var a in z)
            {
                D.RequestInfos.DeleteOnSubmit(a);
            }
            D.SubmitChanges();
            metroGrid2.Rows.RemoveAt(rowIndex);

            //int x=metroGrid2.

            //BloodDataContext D = new BloodDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=G:\finalProject\Blood Donation\Blood.mdf;Integrated Security=True;Connect Timeout=30");

            //var y = from a in D.RequestInfos
            //        where a.DonorId == Convert.ToInt32(textBox1.Text)
            //        select a;
            //foreach (var a in y)
            //{
            //    D.RequestInfos.DeleteOnSubmit(a);
            //}

            //DonorInfo i = D.DonorInfos.SingleOrDefault(t => t.DonorId == Convert.ToInt32(textBox1.Text));
            //D.DonorInfos.DeleteOnSubmit(i);
            //D.SubmitChanges();
            

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {

        }
    }
}
