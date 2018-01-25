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
    public partial class DeleteGuest : Form
    {
        Show_Guest s;
        public DeleteGuest()
        {
            InitializeComponent();
        }
        public DeleteGuest(Show_Guest s)
        {
            InitializeComponent();
            this.s = s;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            BloodDataContext D = new BloodDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=F:\C# projects\finalProject\Blood Donation\Blood.mdf;Integrated Security=True;Connect Timeout=30");

            //RequestInfo j = D.RequestInfos.SingleOrDefault(x => x.DonorId == Convert.ToInt32(textBox1.Text));

            var y = from a in D.RequestInfos
                    where a.Gid == Convert.ToInt32(textBox1.Text)
                    select a;
            if (y.Any())
            {
                foreach (var a in y)
                {
                    D.RequestInfos.DeleteOnSubmit(a);
                }

                GuestInfo i = D.GuestInfos.SingleOrDefault(t => t.Gid == Convert.ToInt32(textBox1.Text));

                D.GuestInfos.DeleteOnSubmit(i);
                D.SubmitChanges();
                s.showde();
            }
            else
            {
                MessageBox.Show("Guest Id Invalid");
            }
        }

        private void DeleteGuest_Load(object sender, EventArgs e)
        {

        }

        private void DeleteGuest_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Admin s = new Admin();
            s.Show();
            this.Hide();
        }
    }
}
