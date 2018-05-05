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
        // Form 1 Variables
        const string FILENAME = "Database.txt";
        DataTable dt = new DataTable();
        CarDatabase carData;
        int iDays = 0;
        DateTime dtStartDate;
        DateTime dtEndDate;

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
            dtStartDate = dtpStartDate.Value;
            dtEndDate = dtpEndDate.Value;

            // Calculation
            TimeSpan t = dtEndDate - dtStartDate;

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
                    // Find corresponding entry in database that matches selection and set it to a temporary Car
                    Car carTemp = carData.Find(dgvAvailableCars.SelectedCells[1].Value.ToString(), cbxTypes.SelectedItem.ToString());

                    // Create temporary CarRegistration object
                    CarRegistration carRecTemp = new CarRegistration(carTemp, iDays, dtStartDate, dtEndDate);

                    // Pass temporary CarRegistration object to new form, and initiate new form.
                    Form2 frm2 = new Form2(carRecTemp);
                    frm2.ShowDialog();
                }
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