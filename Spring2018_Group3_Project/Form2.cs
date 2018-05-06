using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Console;
using static System.Array;
using System.IO;

namespace Spring2018_Group3_Project
{
    public partial class Form2 : Form
    {
        // Form 2 variables
        CarRegistration carRec;
        Customer c1 = new Customer();

        //Accepts a CarRegistration object from Form 1 and sets the read-only text boxes.
        public Form2(CarRegistration car)
        {
            InitializeComponent();

            // Form Setup
            carRec = car;
            AddCarInfo();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            c1.dtDOB = dtpDOB.Value;
            MessageBox.Show("Your DOB is " + c1.dtDOB.ToString("D"));
            // This will need error checking, and will call a function that will write things to a file. If successful, it will popup with a message box that says "Complete"
  
            
            //Create file
            const string FILENAME = "Test.txt";
	        const string DELIM = ":";
            const string HYPHEN = "-";
            const string COMMA = " , ";
            const string SPACE = " ";
          


            Customer cust = new Customer();
            // Open File Stream
            FileStream outFile = new FileStream(FILENAME, FileMode.Append, FileAccess.Write);
			StreamWriter writer = new StreamWriter(outFile);

            writer.WriteLine("-------------");
            writer.WriteLine("Name" + DELIM + tbFirstName.Text + SPACE + tbLastName.Text + COMMA + "Email" + DELIM + tbEmail.Text +COMMA+ "Phone Number" + DELIM + tbPhoneNumber.Text + COMMA + "DriverID" + DELIM + tbDriverID.Text);
            writer.WriteLine("Address" + DELIM + tbAddress.Text + COMMA + "City" + DELIM + tbCity.Text + COMMA + "State" + DELIM + tbState.Text + COMMA + "Zip Code" + DELIM + tbZipcode.Text);
            writer.WriteLine("Vehicle" + DELIM + tbMake.Text + SPACE + tbModel.Text + COMMA + "Rate" + DELIM + tbTotalCost.Text);
            writer.WriteLine("Rental Dates" + DELIM + tbPickup.Text + HYPHEN + tbReturn.Text + COMMA + "Total Cost" + tbRateTotal.Text);
            writer.WriteLine("-------------");

            // Close File Stream
            writer.Close();
			outFile.Close();

            

        }

        // Populates the read-only entries on the form
        private void AddCarInfo()
        {
            const double FEES = 4.99;
            tbMake.Text = carRec.car.strMake;
            tbModel.Text = carRec.car.strModel;
            tbPickup.Text = carRec.dtStart.ToString("d");
            tbReturn.Text = carRec.dtReturn.ToString("d");
            tbRateTotal.Text = (carRec.car.dblRate * Convert.ToDouble(carRec.iDays)).ToString("C");
            tbFees.Text = FEES.ToString("C");
            tbTotalCost.Text = ((carRec.car.dblRate * Convert.ToDouble(carRec.iDays)) + FEES).ToString("C");
        }

        private void tbAddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbDriverID_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbReturn_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbPickup_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbTotalCost_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbFirstName_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}


