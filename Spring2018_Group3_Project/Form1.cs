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
	public partial class Form1 : Form
	{
		DataTable dt = new DataTable();
		public Form1()
		{
			InitializeComponent();
			AddCols();
			AddRows();
			WriteRows();
		}

		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void cmbBxCarTypes_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void btnFindAvail_Click(object sender, EventArgs e)
		{
			if (cmbBxCarTypes.SelectedItem != null)
			{
				MessageBox.Show("You selected " + cmbBxCarTypes.SelectedItem.ToString());
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

		private void WriteRows()
		{
			foreach (DataRow row in dt.Rows)
			{
				dtGrdVwAvailCars.Rows.Add(row[0], row[1], row[2], row[3]);
			}
			
		}
	}
}
