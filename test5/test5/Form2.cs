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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            
        }
 

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime dt1 = dateTimePicker1.Value;
            DateTime d2 = dateTimePicker2.Value;

            TimeSpan t = d2 - dt1;
            double dDays = t.TotalDays;
            int days = Convert.ToInt32(dDays);
            textBox1.Text = days.ToString();


  
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
         
               
            

        }

     

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
           
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            Form3 fm3 = new Form3();
            fm3.ShowDialog();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
