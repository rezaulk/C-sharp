using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace loginform
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            personDataContext pdc = new personDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\MD. REZA UL KARIM\documents\visual studio 2012\Projects\GUI\loginform\Contact_Info.mdf;Integrated Security=True;Connect Timeout=30");
            dataGridView1.DataSource = pdc.Persons;
        }
        void GridViewUpadte()
        {
            
            personDataContext pdc = new personDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\MD. REZA UL KARIM\documents\visual studio 2012\Projects\GUI\loginform\Contact_Info.mdf;Integrated Security=True;Connect Timeout=30");
            dataGridView1.DataSource = pdc.Persons;
        }

        private void Insert_Click(object sender, EventArgs e)
        {
            personDataContext pdc = new personDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\MD. REZA UL KARIM\documents\visual studio 2012\Projects\GUI\loginform\Contact_Info.mdf;Integrated Security=True;Connect Timeout=30");
            Person p = new Person();
            p.Id = int.Parse(textBox1.Text);
            p.Name = textBox2.Text;
            p.Phone = textBox3.Text;

            //Person p=new Person
            //{
            //    Id = int.Parse(textBox1.Text);
            //    Name = textBox2.Text;
            //    Phone = textBox3.Text;
            //}

            pdc.Persons.InsertOnSubmit(p);
            pdc.SubmitChanges();
            GridViewUpadte();
        }

        private void Search_Click(object sender, EventArgs e)
        {
            personDataContext pdc = new personDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\MD. REZA UL KARIM\documents\visual studio 2012\Projects\GUI\loginform\Contact_Info.mdf;Integrated Security=True;Connect Timeout=30");
            var x = from a in pdc.Persons
                where a.Id==int.Parse(textBox1.Text)
                    select a;
            textBox2.Text= x.FirstOrDefault().Name;
            textBox3.Text=x.First().Phone;

            dataGridView1.DataSource=x.ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox2.Text = textBox3.Text = string.Empty;
            GridViewUpadte();
        }

        private void Update_Click(object sender, EventArgs e)
        {
            personDataContext pdc = new personDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\MD. REZA UL KARIM\documents\visual studio 2012\Projects\GUI\loginform\Contact_Info.mdf;Integrated Security=True;Connect Timeout=30");

            Person p = pdc.Persons.SingleOrDefault(x=>x.Id==int.Parse(textBox1.Text));//extension method lemda expresion
            p.Name = textBox2.Text;
            p.Phone = textBox3.Text;

            //LINQ
            //var x=from a in pdc.persons
            // where a.ID==(textbox1.text)
            //Select a;
            //x.First().Name = textBox2.Text;
            //x.First().Name = textBox2.Text;


           
            pdc.SubmitChanges();
            GridViewUpadte();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            personDataContext pdc = new personDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\MD. REZA UL KARIM\documents\visual studio 2012\Projects\GUI\loginform\Contact_Info.mdf;Integrated Security=True;Connect Timeout=30");

            Person p = pdc.Persons.SingleOrDefault(x => x.Id == int.Parse(textBox1.Text));
            pdc.Persons.DeleteOnSubmit(p);
            pdc.SubmitChanges();

            //var x=from a in pdc.Persons
            //      where a.Id==
            //      select a;

            //foreach(person p in x)
            //{
            //    pdc.Persons.DeleteOnSubmit(p);
            //}
        }

    }
}
