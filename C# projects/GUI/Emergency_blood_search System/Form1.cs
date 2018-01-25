using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Emergency_blood_search_System
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
         
            personDBDataContext pd = new PersonDBDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=G:\7th_semester\OOP2\MyLINQTest_version_1.0\MyLINQTest_version_1.0\MyLINQTest\Contact.mdf;Integrated Security=True;Connect Timeout=30");
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            
        }
    }
}
