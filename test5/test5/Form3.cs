using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test5
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Class1.strFName = textBox1.Text;
            Class1.strLName = textBox2.Text;
            Class1.strEmail = textBox3.Text;
            Class1.strAddress = textBox4.Text;
            Class1.strCity = textBox5.Text;
            Class1.strState = textBox6.Text;
            Class1.strDriver = textBox7.Text;

            DateTime dt1 = dateTimePicker1.Value;
            Class1.BirthDate = dt1;

            Form4 fm4 = new Form4();
            fm4.ShowDialog();

            


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
