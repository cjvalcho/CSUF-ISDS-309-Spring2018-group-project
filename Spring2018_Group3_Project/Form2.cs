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

         
            // Fill arrays with values entered from appropriate TextBox
            char[] arrayFirstName = tbFirstName.Text.ToArray();
            char[] arrayLastName = tbLastName.Text.ToArray();
            char[] arrayCity = tbCity.Text.ToArray();
            char[] arrayState = tbState.Text.ToArray();
            char[] arrayPhoneNumber = tbPhoneNumber.Text.ToArray();
            char[] arrayZipcode = tbZipcode.Text.ToArray();
            char[] arrayDriverID = tbDriverID.Text.ToArray();



            if (tbFirstName.Text == "") // If TextBox first name is empty
            {
                MessageBox.Show("For FirstName please enter a value");
                return; // stop program from running
            }
            else
            {
                for (int i = 0; i < arrayFirstName.Length; i++) //loop to check if Textbox array has a number
                {
                    if (arrayFirstName[i] == '1' || arrayFirstName[i] == '2' || arrayFirstName[i] == '3' || arrayFirstName[i] == '4' || arrayFirstName[i] == '5' 
                        || arrayFirstName[i] == '6' || arrayFirstName[i] == '7' || arrayFirstName[i] == '8' || arrayFirstName[i] == '9' || arrayFirstName[i] == '0')
                    {
                        MessageBox.Show("For FirstName please do not enter any numbers"); // outputs if it finds a number
                        return;
                    }
                }
            }

            if (tbLastName.Text == "") // If TextBox Last name is empty
            {
                MessageBox.Show("For LastName please enter a value");
                return;
            }

            else
            {
                for (int i = 0; i < arrayLastName.Length; i++) //loop to check if Textbox array has a number
                {
                    if (arrayLastName[i] == '1' || arrayLastName[i] == '2' || arrayLastName[i] == '3' || arrayLastName[i] == '4' || arrayLastName[i] == '5' 
                        || arrayLastName[i] == '6' || arrayLastName[i] == '7' || arrayLastName[i] == '8' || arrayLastName[i] == '9' || arrayLastName[i] == '0')
                    {
                        MessageBox.Show("For LastName please do not enter any numbers"); // outputs if it finds a number
                        return;
                    }
                }
            }

            if (tbEmail.Text == "") // If TextBox email is empty
            {
                MessageBox.Show("For Email please enter a value");
                return; // stop program from running
            }

            if (tbAddress.Text == "") // If TextBox address is empty
            {
                MessageBox.Show("For Address please enter a value");
                return; // stop program from running
            }

            if (tbPhoneNumber.Text == "") // If TextBox PhoneNumber is empty
            {
                MessageBox.Show("For Phone Number please enter a value");
                return;
            }

            else
            {
                for (int i = 0; i < arrayPhoneNumber.Length; i++) //loop to check if Textbox array does not have a number
                {
                    if (!(arrayPhoneNumber[i] == '1' || arrayPhoneNumber[i] == '2' || arrayPhoneNumber[i] == '3' || arrayPhoneNumber[i] == '4' || arrayPhoneNumber[i] == '5'
                        || arrayPhoneNumber[i] == '6' || arrayPhoneNumber[i] == '7' || arrayPhoneNumber[i] == '8' || arrayPhoneNumber[i] == '9' || arrayPhoneNumber[i] == '-'
                        || arrayPhoneNumber[i] == '(' || arrayPhoneNumber[i] == ')' || arrayPhoneNumber[i] == ' '))
                    {
                        MessageBox.Show("For Phone Number please do not enter any letters"); // outputs if it finds a number
                        return;
                    }
                }
            }

            if (tbCity.Text == "") // If TextBox City is empty
            {
                MessageBox.Show("For City please enter a value");
                return;
            }

            else
            {
                for (int i = 0; i < arrayCity.Length; i++) //loop to check if Textbox array has a number
                {
                    if (arrayCity[i] == '1' || arrayCity[i] == '2' || arrayCity[i] == '3' || arrayCity[i] == '4' || arrayCity[i] == '5' 
                        || arrayCity[i] == '6' || arrayCity[i] == '7' || arrayCity[i] == '8' || arrayCity[i] == '9' || arrayCity[i] == '0')
                    {
                        MessageBox.Show("For City please do not enter any numbers"); // outputs if it finds a number
                        return;
                    }
                }
            }

            if (tbState.Text == "") // If TextBox State is empty
            {
                MessageBox.Show("For State please enter a value");
                return;
            }

            else
            {
                for (int i = 0; i < arrayState.Length; i++) //loop to check if Textbox array has a number
                {
                    if (arrayState[i] == '1' || arrayState[i] == '2' || arrayState[i] == '3' || arrayState[i] == '4' || arrayState[i] == '5' 
                        || arrayState[i] == '6' || arrayState[i] == '7' || arrayState[i] == '8' || arrayState[i] == '9' || arrayState[i] == '0')
                    {
                        MessageBox.Show("For State please do not enter any numbers"); // outputs if it finds a number
                        return;
                    }
                }
            }


            if (tbZipcode.Text == "") // If TextBox Zipcode is empty
            {
                MessageBox.Show("For Zipcode please enter a value");
                return;
            }

            else
            {
                for (int i = 0; i < arrayZipcode.Length; i++) //loop to check if Textbox array does not have a number
                {
                    if (!(arrayZipcode[i] == '1' || arrayZipcode[i] == '2' || arrayZipcode[i] == '3' || arrayZipcode[i] == '4' || arrayZipcode[i] == '5' 
                        || arrayZipcode[i] == '6' || arrayZipcode[i] == '7' || arrayZipcode[i] == '8' || arrayZipcode[i] == '9' || arrayZipcode[i] == '0'))
                    {
                        MessageBox.Show("For Zipcode please do not enter any letters"); // outputs if it finds a number
                        return;
                    }
                }
            }

            if (tbDriverID.Text == "") // If TextBox Driver License is empty
            {
                MessageBox.Show("For Driver License number please enter a value");
                return;
            }

         

            c1.dtDOB = dtpDOB.Value;
            int iAge = DateTime.Today.Year - dtpDOB.Value.Year; // Calculate user age


            //string strage = Convert.ToString(Age); // to see age
            //MessageBox.Show(strage);

            if (!(iAge >= 18))
            {
                MessageBox.Show("You are not 18 and are unable to drive a motorvehicle, according to US law"); // Display if user is underage
                return;
            }

            //MessageBox.Show("all values passed");   //to test if values passed

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
            writer.WriteLine("Name" + DELIM + tbFirstName.Text + SPACE + tbLastName.Text + COMMA + "Email" + DELIM + tbEmail.Text + COMMA + "Phone Number" + DELIM + tbPhoneNumber.Text + COMMA + "DriverID" + DELIM + tbDriverID.Text);
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

        private void tbFirstName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

// Writing to file example
/*
    // Variables    
    const string FILENAME = "Test.txt";
	const string DELIM = ",";
    // File Information
			if (File.Exists(FILENAME))
			{
				WriteLine("File exists");
				WriteLine("File was created " + File.GetCreationTime(FILENAME));
				WriteLine("File was last accessed " + File.GetLastAccessTime(FILENAME));
				WriteLine("File was last written to " + File.GetLastWriteTime(FILENAME));
			}
			else
			{
				WriteLine("File does not exist");
			}

			// Open File Stream
			FileStream outFile = new FileStream(FILENAME, FileMode.Append, FileAccess.Write);
			StreamWriter writer = new StreamWriter(outFile);

			// Process
			Write("Enter Employee Number or " + END + " to quit >> ");
			//Write("Enter Emploree Number of {0} to quit >> ", END);
			emp.iEmpNum = Convert.ToInt32(ReadLine());

			// Loop
			while (emp.iEmpNum != END)
			{
				Write("Enter Last Name >> ");
				emp.strName = ReadLine();
				Write("Enter Salary >> $");
				emp.dblSalary = Convert.ToDouble(ReadLine());

				// Write to file
				writer.WriteLine(emp.iEmpNum + DELIM + emp.strName + DELIM + emp.dblSalary);

				// Process
				Write("Enter Employee Number or " + END + " to quit >> ");
				emp.iEmpNum = Convert.ToInt32(ReadLine());
			}

			// Close File Stream
			writer.Close();
			outFile.Close();
*/
