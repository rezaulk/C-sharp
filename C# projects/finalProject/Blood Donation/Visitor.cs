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
    public partial class Visitor : Form
    {
        public Visitor()
        {
            InitializeComponent();
        }
        public void show()
        {
            BloodDataContext D = new BloodDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=F:\C# projects\finalProject\Blood Donation\Blood.mdf;Integrated Security=True;Connect Timeout=30");


            comboBox2.Items.Clear();
                var x = from a in D.DonorInfos
                        where a.BloodGroup.Equals(comboBox1.SelectedItem.ToString())
                        select a.Address;
                foreach (var c in x)
                {
                    if (!comboBox2.Items.Contains(c))
                    {

                        comboBox2.Items.Add(c);
                    }
                }
            
          
        }
        public void Ashow()
        {
            BloodDataContext D = new BloodDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=F:\C# projects\finalProject\Blood Donation\Blood.mdf;Integrated Security=True;Connect Timeout=30");
           
            var x = from a in D.DonorInfos
                        select a.BloodGroup;
                foreach (var c in x)
                {
                    if (!comboBox1.Items.Contains(c))
                    {

                        comboBox1.Items.Add(c);
                    }
                }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BloodDataContext D = new BloodDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=F:\C# projects\finalProject\Blood Donation\Blood.mdf;Integrated Security=True;Connect Timeout=30");
      
            var x = (from a in D.DonorInfos
                     where (a.BloodGroup == comboBox1.Text && a.Address == comboBox2.Text&&a.Status.Equals(null))
                     select new { a.DonorId, a.Name, a.Phone, a.Address, a.BloodGroup }).ToList();

            if(x.Any())
            {
                dataGridView1.DataSource = x;
                Request r = new Request();
                r.Show();
            }
            else
            {
                MessageBox.Show("Data not found");
            }
          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Start l = new Start();
            l.Show();
            this.Hide();
        }

        private void visitor_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void comboBox2_DropDown(object sender, EventArgs e)
        {
           //show();
        }

        Dictionary<string, string[]> models = new Dictionary<string, string[]>();
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            show();
        }

    }
}
