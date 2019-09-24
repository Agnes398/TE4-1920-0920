using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms0923
{
    public partial class Form1 : Form
    {
        //lista med favoriternas info 
        System.Collections.ArrayList Customers = new System.Collections.ArrayList();

        public Form1()
        {
            InitializeComponent();

        }

        private void Button1_Click(object sender, EventArgs e)
        {

            Customers.Add(new Customer() { Namn = textBox1.Text, efterNamn = textBox2.Text, email = textBox3.Text, telefonnummer = textBox4.Text });

        }

        private void Button2_Click(object sender, EventArgs e)
        {

            listBox1.Items.Clear();

            foreach(Customer c in Customers)
            {
                listBox1.Items.Add(c.Namn);
                listBox1.Items.Add(c.efterNamn);
                listBox1.Items.Add(c.email);
                listBox1.Items.Add(c.telefonnummer);
            }

        }
    }
}
