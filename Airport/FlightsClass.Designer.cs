namespace Airport
{
    partial class FlightsClass
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
            this.btnBack = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimeFlights = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.lblbErrors = new System.Windows.Forms.Label();
            this.cmbCities = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbCompanies = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbRunways = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbTerminals = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbGates = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnAddFlight = new System.Windows.Forms.Button();
            this.dgwFlightsData = new System.Windows.Forms.DataGridView();
            this.btnUpdate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgwFlightsData)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(12, 12);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(105, 23);
            this.btnBack.TabIndex = 0;
            this.btnBack.Text = "Back home";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Status";
            // 
            // cmbStatus
            // 
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Items.AddRange(new object[] {
            "Active",
            "Passive"});
            this.cmbStatus.Location = new System.Drawing.Point(12, 90);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(105, 21);
            this.cmbStatus.TabIndex = 3;
            // 
            // cmbType
            // 
            this.cmbType.FormattingEnabled = true;
            this.cmbType.Items.AddRange(new object[] {
            "Ucush",
            "Enish"});
            this.cmbType.Location = new System.Drawing.Point(15, 165);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(105, 21);
            this.cmbType.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Type";
            // 
            // dateTimeFlights
            // 
            this.dateTimeFlights.CustomFormat = "dd-MM-yyyy hh:mm tt";
            this.dateTimeFlights.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimeFlights.Location = new System.Drawing.Point(145, 91);
            this.dateTimeFlights.Name = "dateTimeFlights";
            this.dateTimeFlights.Size = new System.Drawing.Size(134, 20);
            this.dateTimeFlights.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(142, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Date and time";
            // 
            // lblbErrors
            // 
            this.lblbErrors.AutoSize = true;
            this.lblbErrors.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbErrors.ForeColor = System.Drawing.Color.DarkRed;
            this.lblbErrors.Location = new System.Drawing.Point(140, 435);
            this.lblbErrors.Name = "lblbErrors";
            this.lblbErrors.Size = new System.Drawing.Size(0, 25);
            this.lblbErrors.TabIndex = 8;
            // 
            // cmbCities
            // 
            this.cmbCities.FormattingEnabled = true;
            this.cmbCities.Location = new System.Drawing.Point(12, 246);
            this.cmbCities.Name = "cmbCities";
            this.cmbCities.Size = new System.Drawing.Size(105, 21);
            this.cmbCities.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 221);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Cities";
            // 
            // cmbCompanies
            // 
            this.cmbCompanies.FormattingEnabled = true;
            this.cmbCompanies.Location = new System.Drawing.Point(12, 308);
            this.cmbCompanies.Name = "cmbCompanies";
            this.cmbCompanies.Size = new System.Drawing.Size(105, 21);
            this.cmbCompanies.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 283);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Companies";
            // 
            // cmbRunways
            // 
            this.cmbRunways.FormattingEnabled = true;
            this.cmbRunways.Location = new System.Drawing.Point(550, 91);
            this.cmbRunways.Name = "cmbRunways";
            this.cmbRunways.Size = new System.Drawing.Size(105, 21);
            this.cmbRunways.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(550, 66);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Runways";
            // 
            // cmbTerminals
            // 
            this.cmbTerminals.FormattingEnabled = true;
            this.cmbTerminals.Location = new System.Drawing.Point(422, 91);
            this.cmbTerminals.Name = "cmbTerminals";
            this.cmbTerminals.Size = new System.Drawing.Size(105, 21);
            this.cmbTerminals.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(422, 66);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Terminals";
            // 
            // cmbGates
            // 
            this.cmbGates.FormattingEnabled = true;
            this.cmbGates.Location = new System.Drawing.Point(299, 91);
            this.cmbGates.Name = "cmbGates";
            this.cmbGates.Size = new System.Drawing.Size(105, 21);
            this.cmbGates.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(299, 66);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "Gates";
            // 
            // btnAddFlight
            // 
            this.btnAddFlight.Location = new System.Drawing.Point(12, 382);
            this.btnAddFlight.Name = "btnAddFlight";
            this.btnAddFlight.Size = new System.Drawing.Size(105, 23);
            this.btnAddFlight.TabIndex = 21;
            this.btnAddFlight.Text = "Add flight";
            this.btnAddFlight.UseVisualStyleBackColor = true;
            this.btnAddFlight.Click += new System.EventHandler(this.btnAddFlight_Click);
            // 
            // dgwFlightsData
            // 
            this.dgwFlightsData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwFlightsData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwFlightsData.Location = new System.Drawing.Point(145, 140);
            this.dgwFlightsData.Name = "dgwFlightsData";
            this.dgwFlightsData.Size = new System.Drawing.Size(751, 265);
            this.dgwFlightsData.TabIndex = 22;
            this.dgwFlightsData.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgwFlightsData_RowHeaderMouseDoubleClick);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(12, 382);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(105, 23);
            this.btnUpdate.TabIndex = 24;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Visible = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // FlightsClass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(908, 506);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.dgwFlightsData);
            this.Controls.Add(this.btnAddFlight);
            this.Controls.Add(this.cmbRunways);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cmbTerminals);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cmbGates);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cmbCompanies);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmbCities);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblbErrors);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateTimeFlights);
            this.Controls.Add(this.cmbType);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbStatus);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBack);
            this.Name = "FlightsClass";
            this.Text = "Flights";
            ((System.ComponentModel.ISupportInitialize)(this.dgwFlightsData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.ComboBox cmbType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimeFlights;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblbErrors;
        private System.Windows.Forms.ComboBox cmbCities;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbCompanies;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbRunways;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbTerminals;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbGates;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnAddFlight;
        private System.Windows.Forms.DataGridView dgwFlightsData;
        private System.Windows.Forms.Button btnUpdate;
    }
}