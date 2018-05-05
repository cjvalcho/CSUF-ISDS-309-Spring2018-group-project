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
            this.btnFindAvailable = new System.Windows.Forms.Button();
            this.btnConfirmSelection = new System.Windows.Forms.Button();
            this.cbxTypes = new System.Windows.Forms.ComboBox();
            this.dgvAvailableCars = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAvailableCars)).BeginInit();
            this.SuspendLayout();
            // 
            // btnFindAvailable
            // 
            this.btnFindAvailable.Location = new System.Drawing.Point(176, 104);
            this.btnFindAvailable.Name = "btnFindAvailable";
            this.btnFindAvailable.Size = new System.Drawing.Size(84, 23);
            this.btnFindAvailable.TabIndex = 0;
            this.btnFindAvailable.Text = "Find Available";
            this.btnFindAvailable.UseVisualStyleBackColor = true;
            this.btnFindAvailable.Click += new System.EventHandler(this.btnFindAvailable_Click);
            // 
            // btnConfirmSelection
            // 
            this.btnConfirmSelection.Location = new System.Drawing.Point(168, 256);
            this.btnConfirmSelection.Name = "btnConfirmSelection";
            this.btnConfirmSelection.Size = new System.Drawing.Size(98, 23);
            this.btnConfirmSelection.TabIndex = 1;
            this.btnConfirmSelection.Text = "Confirm Selection";
            this.btnConfirmSelection.UseVisualStyleBackColor = true;
            this.btnConfirmSelection.Click += new System.EventHandler(this.btnConfirmSelection_Click);
            // 
            // cbxTypes
            // 
            this.cbxTypes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTypes.FormattingEnabled = true;
            this.cbxTypes.Items.AddRange(new object[] {
            "Sedan",
            "SUV",
            "Truck",
            "Van"});
            this.cbxTypes.Location = new System.Drawing.Point(24, 40);
            this.cbxTypes.Name = "cbxTypes";
            this.cbxTypes.Size = new System.Drawing.Size(121, 21);
            this.cbxTypes.TabIndex = 2;
            // 
            // dgvAvailableCars
            // 
            this.dgvAvailableCars.AllowUserToAddRows = false;
            this.dgvAvailableCars.AllowUserToDeleteRows = false;
            this.dgvAvailableCars.AllowUserToResizeColumns = false;
            this.dgvAvailableCars.AllowUserToResizeRows = false;
            this.dgvAvailableCars.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvAvailableCars.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvAvailableCars.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvAvailableCars.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAvailableCars.GridColor = System.Drawing.Color.LightGray;
            this.dgvAvailableCars.Location = new System.Drawing.Point(16, 136);
            this.dgvAvailableCars.Name = "dgvAvailableCars";
            this.dgvAvailableCars.ReadOnly = true;
            this.dgvAvailableCars.RowHeadersVisible = false;
            this.dgvAvailableCars.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAvailableCars.Size = new System.Drawing.Size(408, 112);
            this.dgvAvailableCars.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Vehicle Type";
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Location = new System.Drawing.Point(232, 40);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(200, 20);
            this.dtpStartDate.TabIndex = 5;
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Location = new System.Drawing.Point(232, 72);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(200, 20);
            this.dtpEndDate.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(272, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Duration of Rental";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(160, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Start Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(160, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Return Date";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 283);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtpEndDate);
            this.Controls.Add(this.dtpStartDate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvAvailableCars);
            this.Controls.Add(this.cbxTypes);
            this.Controls.Add(this.btnConfirmSelection);
            this.Controls.Add(this.btnFindAvailable);
            this.Name = "Form1";
            this.Text = "Vehicle Information";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAvailableCars)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFindAvailable;
        private System.Windows.Forms.Button btnConfirmSelection;
        private System.Windows.Forms.ComboBox cbxTypes;
        private System.Windows.Forms.DataGridView dgvAvailableCars;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

