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
        CarRegistration carRec = new CarRegistration();

        public Form1()
        {
            InitializeComponent();
            
            // Ensure that file exists
            try
            {
                carData = CarDatabase.FileReader(FILENAME);
            }
            catch(FileNotFoundException er)
            {
                MessageBox.Show(er.Message, "Error");
            }

            // Initialize Datagridview
            dgvAvailableCars.DataSource = dt;
            AddCols();

            // Setup Event Handlers
            dtpStartDate.ValueChanged += new EventHandler(dtp_cbx_ValueChanged);
            dtpEndDate.ValueChanged += new EventHandler(dtp_cbx_ValueChanged);
            cbxTypes.SelectedValueChanged += new EventHandler(dtp_cbx_ValueChanged);
        }

        // Automatically fills the datagrid upon selecting a vehicle and/or setting a date range
        private void dtp_cbx_ValueChanged(Object sender, EventArgs e)
        {
            // Assignment
            carRec.dtStart = dtpStartDate.Value;
            carRec.dtReturn = dtpEndDate.Value;

            // Exception handling
            try
            {
                carRec.dayConvert();
                AddRows(cbxTypes.SelectedItem.ToString());
            }
            catch(NullReferenceException)
            {
                MessageBox.Show("You must select a type of vehicle.", "Error");
                return;
            }
            catch (NegativeDateException er)
            {
                MessageBox.Show(er.Message, "Error");
                return;
            }
        }

        // Upon selecting a specific vehicle, call form2 and pass the vehicle information
        private void btnConfirmSelection_Click(object sender, EventArgs e)
        {
            // Local Variables
            int iCellCount = dgvAvailableCars.GetCellCount(DataGridViewElementStates.Selected);

            // Ensure that only a single row is selected
            if (iCellCount > 0)
            {
                if (dgvAvailableCars.AreAllCellsSelected(true))
                {
                    MessageBox.Show("All cells are selected", "Selected Cells");
                }
                else
                {
                    // Find corresponding entry in database that matches selection and set it to a temporary Car
                    carRec.car = carData.Find(dgvAvailableCars.SelectedCells[1].Value.ToString(), cbxTypes.SelectedItem.ToString());
                    try
                    {
                        // Double check if the date range is valid before passing to the next form
                        carRec.dayConvert();
                    }
                    catch (NegativeDateException er)
                    {
                        MessageBox.Show(er.Message, "Error");
                        return;
                    }
                    // Pass the CarRegistration object to new form, and initiate new form.
                    Form2 frm2 = new Form2(carRec);
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
                    dt.Rows.Add(carData.carList[i].strMake, carData.carList[i].strModel, carData.carList[i].dblRate.ToString("C"), (carData.carList[i].dblRate * Convert.ToDouble(carRec.iDays)).ToString("C"));
                }
            }
            dgvAvailableCars.Refresh();
        }
    }

    //Exception
    public class NegativeDateException : Exception
    {
        private static string msg = "You must enter a valid date range.";
        public NegativeDateException() : base(msg)
        { }
    }
}