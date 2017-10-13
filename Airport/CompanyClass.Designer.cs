namespace Airport
{
    partial class CompanyClass
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnBackHome = new System.Windows.Forms.Button();
            this.txtCompanyName = new System.Windows.Forms.TextBox();
            this.cmbCompanyStatus = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAddCompany = new System.Windows.Forms.Button();
            this.lblCompanyErrors = new System.Windows.Forms.Label();
            this.btnDeleteCompany = new System.Windows.Forms.Button();
            this.btnUpdateCompany = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbCountryId = new System.Windows.Forms.ComboBox();
            this.dgwCompanyData = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgwCompanyData)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Company name";
            // 
            // btnBackHome
            // 
            this.btnBackHome.Location = new System.Drawing.Point(21, 28);
            this.btnBackHome.Name = "btnBackHome";
            this.btnBackHome.Size = new System.Drawing.Size(100, 23);
            this.btnBackHome.TabIndex = 1;
            this.btnBackHome.Text = "Page home";
            this.btnBackHome.UseVisualStyleBackColor = true;
            this.btnBackHome.Click += new System.EventHandler(this.btnBackHome_Click);
            // 
            // txtCompanyName
            // 
            this.txtCompanyName.Location = new System.Drawing.Point(21, 99);
            this.txtCompanyName.Name = "txtCompanyName";
            this.txtCompanyName.Size = new System.Drawing.Size(100, 20);
            this.txtCompanyName.TabIndex = 2;
            // 
            // cmbCompanyStatus
            // 
            this.cmbCompanyStatus.FormattingEnabled = true;
            this.cmbCompanyStatus.Items.AddRange(new object[] {
            "Active",
            "Passive"});
            this.cmbCompanyStatus.Location = new System.Drawing.Point(21, 157);
            this.cmbCompanyStatus.Name = "cmbCompanyStatus";
            this.cmbCompanyStatus.Size = new System.Drawing.Size(100, 21);
            this.cmbCompanyStatus.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Status";
            // 
            // btnAddCompany
            // 
            this.btnAddCompany.Location = new System.Drawing.Point(23, 314);
            this.btnAddCompany.Name = "btnAddCompany";
            this.btnAddCompany.Size = new System.Drawing.Size(100, 23);
            this.btnAddCompany.TabIndex = 5;
            this.btnAddCompany.Text = "Add company";
            this.btnAddCompany.UseVisualStyleBackColor = true;
            this.btnAddCompany.Click += new System.EventHandler(this.btnAddCompany_Click);
            // 
            // lblCompanyErrors
            // 
            this.lblCompanyErrors.AutoSize = true;
            this.lblCompanyErrors.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompanyErrors.ForeColor = System.Drawing.Color.DarkRed;
            this.lblCompanyErrors.Location = new System.Drawing.Point(18, 422);
            this.lblCompanyErrors.Name = "lblCompanyErrors";
            this.lblCompanyErrors.Size = new System.Drawing.Size(0, 25);
            this.lblCompanyErrors.TabIndex = 6;
            // 
            // btnDeleteCompany
            // 
            this.btnDeleteCompany.Location = new System.Drawing.Point(23, 314);
            this.btnDeleteCompany.Name = "btnDeleteCompany";
            this.btnDeleteCompany.Size = new System.Drawing.Size(100, 23);
            this.btnDeleteCompany.TabIndex = 7;
            this.btnDeleteCompany.Text = "Delete";
            this.btnDeleteCompany.UseVisualStyleBackColor = true;
            this.btnDeleteCompany.Visible = false;
            // 
            // btnUpdateCompany
            // 
            this.btnUpdateCompany.Location = new System.Drawing.Point(23, 391);
            this.btnUpdateCompany.Name = "btnUpdateCompany";
            this.btnUpdateCompany.Size = new System.Drawing.Size(100, 23);
            this.btnUpdateCompany.TabIndex = 8;
            this.btnUpdateCompany.Text = "Update";
            this.btnUpdateCompany.UseVisualStyleBackColor = true;
            this.btnUpdateCompany.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Country id";
            // 
            // cmbCountryId
            // 
            this.cmbCountryId.FormattingEnabled = true;
            this.cmbCountryId.Location = new System.Drawing.Point(21, 221);
            this.cmbCountryId.Name = "cmbCountryId";
            this.cmbCountryId.Size = new System.Drawing.Size(100, 21);
            this.cmbCountryId.TabIndex = 9;
            // 
            // dgwCompanyData
            // 
            this.dgwCompanyData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwCompanyData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwCompanyData.Location = new System.Drawing.Point(154, 28);
            this.dgwCompanyData.Name = "dgwCompanyData";
            this.dgwCompanyData.Size = new System.Drawing.Size(591, 386);
            this.dgwCompanyData.TabIndex = 11;
            // 
            // CompanyClass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 488);
            this.Controls.Add(this.dgwCompanyData);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbCountryId);
            this.Controls.Add(this.btnUpdateCompany);
            this.Controls.Add(this.btnDeleteCompany);
            this.Controls.Add(this.lblCompanyErrors);
            this.Controls.Add(this.btnAddCompany);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbCompanyStatus);
            this.Controls.Add(this.txtCompanyName);
            this.Controls.Add(this.btnBackHome);
            this.Controls.Add(this.label1);
            this.Name = "CompanyClass";
            this.Text = "Company";
            ((System.ComponentModel.ISupportInitialize)(this.dgwCompanyData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBackHome;
        private System.Windows.Forms.TextBox txtCompanyName;
        private System.Windows.Forms.ComboBox cmbCompanyStatus;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAddCompany;
        private System.Windows.Forms.Label lblCompanyErrors;
        private System.Windows.Forms.Button btnDeleteCompany;
        private System.Windows.Forms.Button btnUpdateCompany;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbCountryId;
        private System.Windows.Forms.DataGridView dgwCompanyData;
    }
}