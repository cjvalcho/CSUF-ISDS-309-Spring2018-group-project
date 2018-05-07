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
        Customer custRec;
        // Processing fee
        const double FEES = 4.99;

        //Accepts a CarRegistration object from Form 1 and sets the read-only text boxes.
        public Form2(Customer cust)
        {
            InitializeComponent();

            // Form Setup
            custRec = cust;
            UpdateFields();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (VerifyData())
            {
                WriteFile();
                DialogResult dialog = MessageBox.Show("Your reservation has been entered into the system", "Confirmation", MessageBoxButtons.OK);
                if (dialog == DialogResult.OK)
                {
                    Application.Exit();
                }
            }
        }

        // Populates the read-only entries on the form
        private void UpdateFields()
        {
            // Customer Inforamation
            tbFirstName.Text = custRec.strFirstName;
            tbLastName.Text = custRec.strLastName;
            tbEmail.Text = custRec.strEmail;
            tbPhoneNumber.Text = custRec.strPhoneNumber;
            tbAddress.Text = custRec.strAddress;
            tbCity.Text = custRec.strCity;
            tbState.Text = custRec.strState;
            tbZipcode.Text = custRec.strZipcode;
            tbDriverID.Text = custRec.strDriverID;

            // Car Information
            tbMake.Text = custRec.carRec.car.strMake;
            tbModel.Text = custRec.carRec.car.strModel;
            tbPickup.Text = custRec.carRec.dtStart.ToString("d");
            tbReturn.Text = custRec.carRec.dtReturn.ToString("d");
            tbRateTotal.Text = (custRec.carRec.car.dblRate * Convert.ToDouble(custRec.carRec.iDays)).ToString("C");
            tbFees.Text = FEES.ToString("C");
            tbTotalCost.Text = ((custRec.carRec.car.dblRate * Convert.ToDouble(custRec.carRec.iDays)) + FEES).ToString("C");
        }

        private bool VerifyData()
        {
            if (tbFirstName.TextLength == 0)
            {
                MessageBox.Show("Please enter a first name", "Error");
                return false;
            }
            if (tbLastName.TextLength == 0)
            {
                MessageBox.Show("Please enter a last name", "Error");
                return false;
            }
            if (tbEmail.TextLength == 0)
            {
                MessageBox.Show("Please enter an email address", "Error");
                return false;
            }
            if (tbPhoneNumber.TextLength == 0)
            {
                MessageBox.Show("Please enter a phone number", "Error");
                return false;
            }
            if (tbAddress.TextLength == 0)
            {
                MessageBox.Show("Please enter an address", "Error");
                return false;
            }
            if (tbCity.TextLength == 0)
            {
                MessageBox.Show("Please enter a city", "Error");
                return false;
            }
            if (tbState.TextLength == 0)
            {
                MessageBox.Show("Please enter a state", "Error");
                return false;
            }
            if (tbZipcode.TextLength == 0)
            {
                MessageBox.Show("Please enter a zipcode", "Error");
                return false;
            }
            if (tbDriverID.TextLength == 0)
            {
                MessageBox.Show("Please enter a driver's license", "Error");
                return false;
            }
            try
            {
                custRec.strFirstName = tbFirstName.Text;
                custRec.strLastName = tbLastName.Text;
                custRec.strEmail = tbEmail.Text;
                custRec.strPhoneNumber = tbPhoneNumber.Text;
                custRec.strAddress = tbAddress.Text;
                custRec.strCity = tbCity.Text;
                custRec.strState = tbState.Text;
                custRec.strZipcode = tbZipcode.Text;
                custRec.strDriverID = tbDriverID.Text;
                custRec.dtDOB = dtpDOB.Value;
            }
            catch (ArgumentException er)
            {
                MessageBox.Show(er.Message, "Error");
                return false;
            }
            return true;
        }

        private void WriteFile()
        {
            // Formatting
            const string FILENAME = "Test.txt";
            const string DELIM = ": ";
            const string HYPHEN = "-";
            const string COMMA = ", ";
            const string SPACE = " ";
            
            // Open File Stream
            FileStream outFile = new FileStream(FILENAME, FileMode.Append, FileAccess.Write);
            StreamWriter writer = new StreamWriter(outFile);

            // Write to file
            writer.WriteLine("-------------");
            writer.WriteLine("Name" + DELIM + custRec.strFirstName + SPACE + custRec.strLastName + COMMA + "Email" + DELIM + custRec.strEmail + COMMA + "Phone Number" + DELIM + custRec.strPhoneNumber + COMMA + "DriverID" + DELIM + custRec.strDriverID);
            writer.WriteLine("Address" + DELIM + custRec.strAddress + COMMA + "City" + DELIM + custRec.strCity + COMMA + "State" + DELIM + custRec.strState + COMMA + "Zip Code" + DELIM + custRec.strZipcode);
            writer.WriteLine("Vehicle" + DELIM + custRec.carRec.car.strMake + SPACE + custRec.carRec.car.strModel + COMMA + "Rate" + DELIM + (custRec.carRec.car.dblRate * Convert.ToDouble(custRec.carRec.iDays)).ToString("C"));
            writer.WriteLine("Rental Dates" + DELIM + custRec.carRec.dtStart.ToString("d") + HYPHEN + custRec.carRec.dtReturn.ToString("d") + COMMA + "Total Cost" + DELIM + ((custRec.carRec.car.dblRate * Convert.ToDouble(custRec.carRec.iDays)) + FEES).ToString("C"));
            writer.WriteLine("-------------");

            // Close File Stream
            writer.Close();
            outFile.Close();
        }
    }
}