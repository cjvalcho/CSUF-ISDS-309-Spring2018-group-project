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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();

            string test1 = Convert.ToString(Class1.PickDate);
            textBox10.Text = test1;

            string test2 = Convert.ToString(Class1.DropDate);
            textBox11.Text = test2;

            string test3 = Convert.ToString(Class1.BirthDate);
            textBox8.Text = test3;

            textBox1.Text = Class1.strFName;
            textBox2.Text = Class1.strLName;
            textBox3.Text = Class1.strEmail;
            textBox4.Text = Class1.strAddress;
            textBox5.Text = Class1.strCity;
            textBox6.Text = Class1.strState;
            textBox7.Text = Class1.strDriver;
            textBox13.Text = Class1.strNumberofDays;
            


        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {
           

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
