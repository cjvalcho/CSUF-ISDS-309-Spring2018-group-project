using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Spring2018_Group3_Project
{
    public partial class Form2 : Form
    {
        // Form 2 variables
        const double FEES = 4.99;
        Form1.CarDatabase.Car carChoice = new Form1.CarDatabase.Car();
        Customer c1 = new Customer();
        int iDays = 0;

        public Form2(Form1.CarDatabase.Car car, int days)
        {
            InitializeComponent();
            carChoice = car;
            iDays = days;
            AddCarInfo();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            c1.dtDOB = dtpDOB.Value;
            MessageBox.Show("Your DOB is " + c1.dtDOB.ToString());
            // This will need error checking, and will call a function that will write things to a file. If successful, it will popup with a message box that says "Complete"
        }

        public class Customer
        {
            // Customer Variables
            public string strFirstName { get; set; }
            public string strLastName { get; set; }
            public string strEmail { get; set; }
            public int iPhoneNumber { get; set; }
            public string strAddress { get; set; }
            public string strCity { get; set; }
            public string strState { get; set; }
            public int iZipcode { get; set; }
            public int iDriverID { get; set; }
            public DateTime dtDOB { get; set; }
        }

        // Populates the read-only entries on the form
        private void AddCarInfo()
        {
            tbMake.Text = carChoice.strMake;
            tbModel.Text = carChoice.strModel;
            tbPickup.Text = "Test";
            tbReturn.Text = "Test";
            tbRateTotal.Text = (carChoice.dblRate * Convert.ToDouble(iDays)).ToString("C");
            tbFees.Text = FEES.ToString("C");
            tbTotalCost.Text = ((carChoice.dblRate * Convert.ToDouble(iDays)) + FEES).ToString("C");
        }
    }
}