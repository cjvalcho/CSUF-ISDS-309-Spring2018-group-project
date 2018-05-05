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
    public partial class Form1 : Form
    {
        // Form Global Variables
        const string FILENAME = "Database.txt";
        DataTable dt = new DataTable();
        CarDatabase carData;
        int iDays = 0;

        public Form1()
        {
            InitializeComponent();

            // Form Setup
            dgvAvailableCars.DataSource = dt;
            carData = CarDatabase.FileReader(FILENAME);
            AddCols();
        }

        // Upon selecting a type of vehicle, call Add Rows to populate the DataGridView
        private void btnFindAvailable_Click(object sender, EventArgs e)
        {
            // Local Variables
            DateTime dt1 = dtpStartDate.Value;
            DateTime dt2 = dtpEndDate.Value;

            // Calculation
            TimeSpan t = dt2 - dt1;

            // Assignment
            iDays = Convert.ToInt32(t.TotalDays) + 1;

            // Exception handling
            if (cbxTypes.SelectedItem != null && iDays != 0)
            {
                AddRows(cbxTypes.SelectedItem.ToString());
            }
            else
            {
                MessageBox.Show("You must select a vehicle type and enter a valid date range.", "Error");
            }
        }

        // Upon selecting a specific vehicle, call form2 and pass the vehicle information
        private void btnConfirmSelection_Click(object sender, EventArgs e)
        {
            // Local Variables
            int i = 0;
            int iCellCount = dgvAvailableCars.GetCellCount(DataGridViewElementStates.Selected);

            // Error checking
            if (iCellCount > 0)
            {
                if (dgvAvailableCars.AreAllCellsSelected(true))
                {
                    MessageBox.Show("All cells are selected", "Selected Cells");
                }
                else
                {
                    // Find corresponding entry in database that matches selection
                    while (carData.carList[i].strModel != dgvAvailableCars.SelectedCells[1].Value.ToString())
                    {
                        i++;
                    }
                    CarDatabase.Car carTemp = new CarDatabase.Car();

                    carTemp.strCategory = cbxTypes.SelectedItem.ToString();
                    carTemp.strMake = carData.carList[i].strMake;
                    carTemp.strModel = carData.carList[i].strModel;
                    carTemp.dblRate = carData.carList[i].dblRate;

                    Form2 frm2 = new Form2(carTemp, iDays);
                    frm2.ShowDialog();
                }
            }
        }

        // Global Class to store information between all forms
        public static class GlobalRecord
        {
            // Global Variables
            public static string gstrMake = "";
            public static string gstrModel = "";
            public static double gdblRate = 0;
            public static int giDays = 0;
            public static double gdblRateTotal = 0;
        }

        // Class that handles the car database
        public class CarDatabase
        {
            // CarDatabase Variables
            const int INVENTORY = 100; // Arbitrary size of array.
            public Car[] carList;

            // Car Subclass
            public class Car
            {
                // Car Variables
                public string strCategory { get; set; }
                public string strMake { get; set; }
                public string strModel { get; set; }
                public double dblRate { get; set; }
            }

            // Constructor
            public CarDatabase()
            {
                carList = new Car[INVENTORY];
            }

            // Opens and reads from a provided file, populates a carList, and then closes the file
            public static CarDatabase FileReader(string strFilename)
            {
                // Method Variables
                int i = 0; // Array Index
                const char DELIM = ';';
                string strRecordIn;
                string[] strFields;
                CarDatabase carTempData = new CarDatabase();

                // Opens the file and File Stream
                FileStream inFile = new FileStream(strFilename, FileMode.Open, FileAccess.Read);
                StreamReader reader = new StreamReader(inFile);

                // Process
                strRecordIn = reader.ReadLine();

                // Loop
                while (strRecordIn != null)
                {
                    // Declares a new object and populates an array with information from the file
                    Car carTemp = new Car();
                    strFields = strRecordIn.Split(DELIM);

                    // Assigns the information stored in the temporary array into the temp object
                    carTemp.strCategory = strFields[0];
                    carTemp.strMake = strFields[1];
                    carTemp.strModel = strFields[2];
                    carTemp.dblRate = Convert.ToDouble(strFields[3]);

                    // Assigns the temporary object to the carData's list at index i
                    carTempData.carList[i] = carTemp;
                    i++; // Increments index

                    // Reads a new line
                    strRecordIn = reader.ReadLine();
                }

                // Closes the File
                reader.Close();
                inFile.Close();

                return carTempData;
            }
        }

        // Populates the column headers in the datagridview. May not be necessary.
        private void AddCols()
        {
            dt.Columns.Add("Make", typeof(string));
            dt.Columns.Add("Model", typeof(string));
            dt.Columns.Add("Rate (Day)", typeof(string));
            dt.Columns.Add("Rate Total", typeof(string));
        }

        // Populates the rows in the datagridview based on the user's selection
        private void AddRows(string strSearch)
        {
            dt.Rows.Clear();
            for (int i = 0; i < carData.carList.Length; i++)
            {
                if (carData.carList[i] == null)
                {
                    break;
                }
                else if (carData.carList[i].strCategory == strSearch)
                {
                    dt.Rows.Add(carData.carList[i].strMake, carData.carList[i].strModel, carData.carList[i].dblRate.ToString("C"), (carData.carList[i].dblRate * Convert.ToDouble(iDays)).ToString("C"));
                }
            }
            dgvAvailableCars.Refresh();
        }
    }
}
