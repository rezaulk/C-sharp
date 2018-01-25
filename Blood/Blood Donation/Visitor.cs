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
    public partial class Visitor : MetroFramework.Forms.MetroForm
    {
        public Visitor()
        {
            InitializeComponent();
        }
        public void show()
        {
            metroComboBox2.Items.Clear();
            BloodDataContext D = new BloodDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=G:\Blood\Blood Donation\Blood.mdf;Integrated Security=True;Connect Timeout=30");

                var x = from a in D.DonorInfos
                        where a.BloodGroup.Equals(metroComboBox1.SelectedItem.ToString())
                        select a.DAddress;
                foreach (var c in x)
                {
                    if (!metroComboBox2.Items.Contains(c))
                    {

                        metroComboBox2.Items.Add(c);
                    }
                }
        }
        
        public void Ashow()
        {

            BloodDataContext D = new BloodDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=G:\Blood\Blood Donation\Blood.mdf;Integrated Security=True;Connect Timeout=30");
           
            var x = from a in D.DonorInfos
                        select a.BloodGroup;
                foreach (var c in x)
                {
                    if (!metroComboBox1.Items.Contains(c))
                    {

                        metroComboBox1.Items.Add(c);
                    }
                }
        }

        private void visitor_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Visitor_Load(object sender, EventArgs e)
        {
            metroButton3.Hide();
            Ashow();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            BloodDataContext D = new BloodDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=G:\Blood\Blood Donation\Blood.mdf;Integrated Security=True;Connect Timeout=30");


            var x = (from a in D.DonorInfos
                     where (a.BloodGroup == metroComboBox1.Text && a.DAddress == metroComboBox2.Text && a.Status.Equals(null))
                     select new { a.DonorId, a.DName, a.DPhone, a.DAddress, a.BloodGroup }).ToList();

            if (x.Any())
            {
                metroButton3.Show();
                metroGrid1.DataSource = x;
               
            }
            else
            {
                MessageBox.Show("Data not found");
            }
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            Start l = new Start();
            l.Show();
            this.Hide();
        }

        private void metroComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            show();
        }
       
        private void metroButton3_Click(object sender, EventArgs e)
        {
            BloodDataContext D = new BloodDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=G:\Blood\Blood Donation\Blood.mdf;Integrated Security=True;Connect Timeout=30");
            int rowIndex = metroGrid1.CurrentCell.RowIndex;

            int did = Convert.ToInt32(metroGrid1.Rows[rowIndex].Cells[0].Value);
            Request r = new Request(did);
            r.Show();
        }
    }
}
