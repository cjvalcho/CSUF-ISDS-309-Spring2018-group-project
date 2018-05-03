namespace Spring2018_Group3_Project
{
	partial class Form1
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.cmbBxCarTypes = new System.Windows.Forms.ComboBox();
			this.btnFindAvail = new System.Windows.Forms.Button();
			this.dtGrdVwAvailCars = new System.Windows.Forms.DataGridView();
			this.label1 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dtGrdVwAvailCars)).BeginInit();
			this.SuspendLayout();
			// 
			// cmbBxCarTypes
			// 
			this.cmbBxCarTypes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbBxCarTypes.FormattingEnabled = true;
			this.cmbBxCarTypes.Items.AddRange(new object[] {
            "Sedan",
            "SUV",
            "Pickup Truck",
            "Van"});
			this.cmbBxCarTypes.Location = new System.Drawing.Point(12, 29);
			this.cmbBxCarTypes.Name = "cmbBxCarTypes";
			this.cmbBxCarTypes.Size = new System.Drawing.Size(121, 24);
			this.cmbBxCarTypes.TabIndex = 0;
			this.cmbBxCarTypes.SelectedIndexChanged += new System.EventHandler(this.cmbBxCarTypes_SelectedIndexChanged);
			// 
			// btnFindAvail
			// 
			this.btnFindAvail.Location = new System.Drawing.Point(15, 59);
			this.btnFindAvail.Name = "btnFindAvail";
			this.btnFindAvail.Size = new System.Drawing.Size(111, 23);
			this.btnFindAvail.TabIndex = 1;
			this.btnFindAvail.Text = "Find Available";
			this.btnFindAvail.UseVisualStyleBackColor = true;
			this.btnFindAvail.Click += new System.EventHandler(this.btnFindAvail_Click);
			// 
			// dtGrdVwAvailCars
			// 
			this.dtGrdVwAvailCars.AllowUserToAddRows = false;
			this.dtGrdVwAvailCars.AllowUserToDeleteRows = false;
			this.dtGrdVwAvailCars.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dtGrdVwAvailCars.Location = new System.Drawing.Point(15, 88);
			this.dtGrdVwAvailCars.Name = "dtGrdVwAvailCars";
			this.dtGrdVwAvailCars.ReadOnly = true;
			this.dtGrdVwAvailCars.RowTemplate.Height = 24;
			this.dtGrdVwAvailCars.Size = new System.Drawing.Size(595, 213);
			this.dtGrdVwAvailCars.TabIndex = 2;
			this.dtGrdVwAvailCars.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(90, 17);
			this.label1.TabIndex = 3;
			this.label1.Text = "Vehicle Type";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(619, 485);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.dtGrdVwAvailCars);
			this.Controls.Add(this.btnFindAvail);
			this.Controls.Add(this.cmbBxCarTypes);
			this.Name = "Form1";
			this.Text = "Form1";
			((System.ComponentModel.ISupportInitialize)(this.dtGrdVwAvailCars)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ComboBox cmbBxCarTypes;
		private System.Windows.Forms.Button btnFindAvail;
		private System.Windows.Forms.DataGridView dtGrdVwAvailCars;
		private System.Windows.Forms.Label label1;
	}
}

