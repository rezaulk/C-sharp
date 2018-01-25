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
    public partial class ConfirmDelete : Form
    {
        Showdonorlist ada;
        public ConfirmDelete()
        {
            InitializeComponent();
        }

        public ConfirmDelete(Showdonorlist a)
        {
            this.ada = a;
            InitializeComponent();
        }
      
        private void button1_Click(object sender, EventArgs e)
        {
            BloodDataContext D = new BloodDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=F:\C# projects\finalProject\Blood Donation\Blood.mdf;Integrated Security=True;Connect Timeout=30");

            //RequestInfo j = D.RequestInfos.SingleOrDefault(x => x.DonorId == Convert.ToInt32(textBox1.Text));

            var y = from a in D.RequestInfos
                where a.DonorId == Convert.ToInt32(textBox1.Text) 
               select a;
            foreach (var a in y)
            {
                D.RequestInfos.DeleteOnSubmit(a);
            }
         
            DonorInfo i = D.DonorInfos.SingleOrDefault(t => t.DonorId == Convert.ToInt32(textBox1.Text));

            D.DonorInfos.DeleteOnSubmit(i);

            D.SubmitChanges();

            ada.showd();
     
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void confirmdelete_Load(object sender, EventArgs e)
        {

        }

        private void confirmdelete_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}