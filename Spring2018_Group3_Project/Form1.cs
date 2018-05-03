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
		DataTable dt = new DataTable();
		CarDatabase carData;
		public Form1()
		{
			InitializeComponent();
			const string FILENAME = "Database.txt";
			carData = CarDatabase.FileReader(FILENAME);
			AddCols();
			AddRows();
			//WriteRows();
		}

		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			
		}

		private void cmbBxCarTypes_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void btnFindAvail_Click(object sender, EventArgs e)
		{

			//dtGrdVwAvailCars.DataSource = null;
			//dt.Clear();
			//WriteRows();
			//dt.Rows.Clear();
			//ResetRows();
			if (cmbBxCarTypes.SelectedItem != null)
			{
				//ReturnRows(cmbBxCarTypes.SelectedItem.ToString(), carData);
				//MessageBox.Show("You selected " + cmbBxCarTypes.SelectedItem.ToString());
				WriteRows();
			}
		}

		private void AddCols()
		{
			dt.Columns.Add("ID Code", typeof(int));
			dt.Columns.Add("Make", typeof(string));
			dt.Columns.Add("Model", typeof(string));
			dt.Columns.Add("Rate (Day)", typeof(double));
		}

		private void AddRows()
		{
			dt.Rows.Add(100, "Dodge", "Ram", 54.99);
			dt.Rows.Add(101, "Ford", "F150", 49.99);
			dt.Rows.Add(102, "Nissan", "Frontier", 59.99);
			dt.Rows.Add(103, "Toyota", "Tundra", 64.99);
		}

		private void ResetRows()
		{
			for (int i = dtGrdVwAvailCars.RowCount; i > 0; i--)
			{
				dt.Rows[i].Delete();
			}
		}

		private void WriteRows()
		{
			ResetRows();
			foreach (DataRow row in dt.Rows)
			{
				dtGrdVwAvailCars.Rows.Add(row[0], row[1], row[2], row[3]);
			}
			
		}

		public void ReturnRows(string strSearch, CarDatabase carDat)
		{
			for (int i = 0; i < carDat.carList.Length; i++)
			{
				if (carDat.carList[i] == null)
				{
					break;
				}
				else if (carDat.carList[i].strCatagory == strSearch)
				{
					dt.Rows.Add(carDat.carList[i].iID, carDat.carList[i].strMake, carDat.carList[i].strModel, carDat.carList[i].dblRate);
				}
			}
		}
	}
	public class Car
	{
		public string strCatagory { get; set; }
		public int iID { get; set; }
		public string strMake { get; set; }
		public string strModel { get; set; }
		public double dblRate { get; set; }
	}

	public class CarDatabase
	{
		// Catalog Variables
		const int INVENTORY = 100;
		public Car[] carList;

		// Constructors
		public CarDatabase()
		{
			carList = new Car[INVENTORY];
		}

		// Opens and reads from a file, then closes the file
		public static CarDatabase FileReader(string strFileName)
		{
			// Method Variables
			int i = 0;
			const char DELIM = ';';
			string strRecordIn;
			string[] strFields;
			CarDatabase carData = new CarDatabase();
			Car carTemp = new Car();

			// Open Read File Stream
			FileStream inFile = new FileStream(strFileName, FileMode.Open, FileAccess.Read);
			StreamReader reader = new StreamReader(inFile);

			// Process
			strRecordIn = reader.ReadLine();

			// Loop
			while (strRecordIn != null)
			{
				strFields = strRecordIn.Split(DELIM);

				carTemp.strCatagory = strFields[0];
				carTemp.iID = Convert.ToInt32(strFields[1]);
				carTemp.strMake = strFields[2];
				carTemp.strModel = strFields[3];
				carTemp.dblRate = Convert.ToDouble(strFields[4]);

				carData.carList[i] = carTemp;
				i++;

				// Read
				strRecordIn = reader.ReadLine();
			}

			// Close Files
			reader.Close();
			inFile.Close();

			return carData;
		}
	}
}