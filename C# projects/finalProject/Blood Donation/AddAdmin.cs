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
    public partial class AddAdmin : Form   
    {
        Admin a;

        public AddAdmin(Admin a)
        {
            InitializeComponent();
            this.a = a;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BloodDataContext D = new BloodDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=F:\C# projects\finalProject\Blood Donation\Blood.mdf;Integrated Security=True;Connect Timeout=30");

            AdminInfo pr = new AdminInfo();
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "")
            {

                pr.Password = textBox4.Text;
                pr.Name = textBox2.Text;
                pr.Phone = textBox1.Text;
                pr.Username = textBox3.Text;


                D.AdminInfos.InsertOnSubmit(pr);

                D.SubmitChanges();

                MessageBox.Show("New Admin Added");

                a.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Fill up all information");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            a.Show();
            this.Hide();

        }

        private void AddAdmin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void AddAdmin_Load(object sender, EventArgs e)
        {

        }

    }
}
