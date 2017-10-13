namespace Airport
{
    partial class CountryClass
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CountryClass));
            this.label1 = new System.Windows.Forms.Label();
            this.btnCountryAdd = new System.Windows.Forms.Button();
            this.txtCountryName = new System.Windows.Forms.TextBox();
            this.lblCoutryErrors = new System.Windows.Forms.Label();
            this.btnDeleteCountry = new System.Windows.Forms.Button();
            this.btnUpdateCountry = new System.Windows.Forms.Button();
            this.btnBackHome = new System.Windows.Forms.Button();
            this.dgwCountrData = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgwCountrData)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Country name";
            // 
            // btnCountryAdd
            // 
            this.btnCountryAdd.Location = new System.Drawing.Point(15, 191);
            this.btnCountryAdd.Name = "btnCountryAdd";
            this.btnCountryAdd.Size = new System.Drawing.Size(100, 23);
            this.btnCountryAdd.TabIndex = 1;
            this.btnCountryAdd.Text = "Add country";
            this.btnCountryAdd.UseVisualStyleBackColor = true;
            this.btnCountryAdd.Click += new System.EventHandler(this.btnCountryAdd_Click);
            // 
            // txtCountryName
            // 
            this.txtCountryName.Location = new System.Drawing.Point(15, 109);
            this.txtCountryName.Name = "txtCountryName";
            this.txtCountryName.Size = new System.Drawing.Size(100, 20);
            this.txtCountryName.TabIndex = 2;
            // 
            // lblCoutryErrors
            // 
            this.lblCoutryErrors.AutoSize = true;
            this.lblCoutryErrors.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCoutryErrors.ForeColor = System.Drawing.Color.DarkRed;
            this.lblCoutryErrors.Location = new System.Drawing.Point(12, 346);
            this.lblCoutryErrors.Name = "lblCoutryErrors";
            this.lblCoutryErrors.Size = new System.Drawing.Size(0, 25);
            this.lblCoutryErrors.TabIndex = 3;
            // 
            // btnDeleteCountry
            // 
            this.btnDeleteCountry.Location = new System.Drawing.Point(15, 191);
            this.btnDeleteCountry.Name = "btnDeleteCountry";
            this.btnDeleteCountry.Size = new System.Drawing.Size(100, 23);
            this.btnDeleteCountry.TabIndex = 4;
            this.btnDeleteCountry.Text = "Delete";
            this.btnDeleteCountry.UseVisualStyleBackColor = true;
            this.btnDeleteCountry.Visible = false;
            this.btnDeleteCountry.Click += new System.EventHandler(this.btnDeleteCountry_Click);
            // 
            // btnUpdateCountry
            // 
            this.btnUpdateCountry.Location = new System.Drawing.Point(17, 287);
            this.btnUpdateCountry.Name = "btnUpdateCountry";
            this.btnUpdateCountry.Size = new System.Drawing.Size(100, 23);
            this.btnUpdateCountry.TabIndex = 5;
            this.btnUpdateCountry.Text = "Update";
            this.btnUpdateCountry.UseVisualStyleBackColor = true;
            this.btnUpdateCountry.Visible = false;
            this.btnUpdateCountry.Click += new System.EventHandler(this.btnUpdateCountry_Click);
            // 
            // btnBackHome
            // 
            this.btnBackHome.Location = new System.Drawing.Point(15, 24);
            this.btnBackHome.Name = "btnBackHome";
            this.btnBackHome.Size = new System.Drawing.Size(100, 23);
            this.btnBackHome.TabIndex = 6;
            this.btnBackHome.Text = "Page home";
            this.btnBackHome.UseVisualStyleBackColor = true;
            this.btnBackHome.Click += new System.EventHandler(this.btnBackHome_Click);
            // 
            // dgwCountrData
            // 
            this.dgwCountrData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwCountrData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwCountrData.Location = new System.Drawing.Point(161, 24);
            this.dgwCountrData.Name = "dgwCountrData";
            this.dgwCountrData.Size = new System.Drawing.Size(630, 286);
            this.dgwCountrData.TabIndex = 7;
            this.dgwCountrData.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgwCountrData_RowHeaderMouseDoubleClick);
            // 
            // CountryClass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 419);
            this.Controls.Add(this.dgwCountrData);
            this.Controls.Add(this.btnBackHome);
            this.Controls.Add(this.btnUpdateCountry);
            this.Controls.Add(this.btnDeleteCountry);
            this.Controls.Add(this.lblCoutryErrors);
            this.Controls.Add(this.txtCountryName);
            this.Controls.Add(this.btnCountryAdd);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CountryClass";
            this.Text = "Country";
            ((System.ComponentModel.ISupportInitialize)(this.dgwCountrData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCountryAdd;
        private System.Windows.Forms.TextBox txtCountryName;
        private System.Windows.Forms.Label lblCoutryErrors;
        private System.Windows.Forms.Button btnDeleteCountry;
        private System.Windows.Forms.Button btnUpdateCountry;
        private System.Windows.Forms.Button btnBackHome;
        private System.Windows.Forms.DataGridView dgwCountrData;
    }
}