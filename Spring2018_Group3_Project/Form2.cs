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
        const double FEES = 4.99;
        CarDatabase.Car carChoice = new CarDatabase.Car();
        Customer c1 = new Customer();
        
        int iDays = 0;

        public Form2(CarDatabase.Car car, int days)
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
