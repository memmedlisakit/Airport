namespace Airport
{
    partial class CityClass
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CityClass));
            this.label1 = new System.Windows.Forms.Label();
            this.txtCityName = new System.Windows.Forms.TextBox();
            this.cmbCoutry_id = new System.Windows.Forms.ComboBox();
            this.btnAddCity = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBackHome = new System.Windows.Forms.Button();
            this.btnDeleteCity = new System.Windows.Forms.Button();
            this.btnUpdateCity = new System.Windows.Forms.Button();
            this.lblCityErrors = new System.Windows.Forms.Label();
            this.dgwCityData = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgwCityData)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "City name";
            // 
            // txtCityName
            // 
            this.txtCityName.Location = new System.Drawing.Point(21, 134);
            this.txtCityName.Name = "txtCityName";
            this.txtCityName.Size = new System.Drawing.Size(100, 20);
            this.txtCityName.TabIndex = 1;
            // 
            // cmbCoutry_id
            // 
            this.cmbCoutry_id.FormattingEnabled = true;
            this.cmbCoutry_id.Location = new System.Drawing.Point(21, 199);
            this.cmbCoutry_id.Name = "cmbCoutry_id";
            this.cmbCoutry_id.Size = new System.Drawing.Size(100, 21);
            this.cmbCoutry_id.TabIndex = 2;
            // 
            // btnAddCity
            // 
            this.btnAddCity.Location = new System.Drawing.Point(21, 251);
            this.btnAddCity.Name = "btnAddCity";
            this.btnAddCity.Size = new System.Drawing.Size(100, 23);
            this.btnAddCity.TabIndex = 3;
            this.btnAddCity.Text = "Add city";
            this.btnAddCity.UseVisualStyleBackColor = true;
            this.btnAddCity.Click += new System.EventHandler(this.btnAddCity_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Countr id";
            // 
            // btnBackHome
            // 
            this.btnBackHome.Location = new System.Drawing.Point(21, 29);
            this.btnBackHome.Name = "btnBackHome";
            this.btnBackHome.Size = new System.Drawing.Size(100, 23);
            this.btnBackHome.TabIndex = 5;
            this.btnBackHome.Text = "Page home";
            this.btnBackHome.UseVisualStyleBackColor = true;
            this.btnBackHome.Click += new System.EventHandler(this.btnBackHome_Click);
            // 
            // btnDeleteCity
            // 
            this.btnDeleteCity.Location = new System.Drawing.Point(21, 251);
            this.btnDeleteCity.Name = "btnDeleteCity";
            this.btnDeleteCity.Size = new System.Drawing.Size(100, 23);
            this.btnDeleteCity.TabIndex = 6;
            this.btnDeleteCity.Text = "Delete";
            this.btnDeleteCity.UseVisualStyleBackColor = true;
            this.btnDeleteCity.Visible = false;
            this.btnDeleteCity.Click += new System.EventHandler(this.btnDeleteCity_Click);
            // 
            // btnUpdateCity
            // 
            this.btnUpdateCity.Location = new System.Drawing.Point(21, 314);
            this.btnUpdateCity.Name = "btnUpdateCity";
            this.btnUpdateCity.Size = new System.Drawing.Size(100, 23);
            this.btnUpdateCity.TabIndex = 7;
            this.btnUpdateCity.Text = "Update";
            this.btnUpdateCity.UseVisualStyleBackColor = true;
            this.btnUpdateCity.Visible = false;
            this.btnUpdateCity.Click += new System.EventHandler(this.btnUpdateCity_Click);
            // 
            // lblCityErrors
            // 
            this.lblCityErrors.AutoSize = true;
            this.lblCityErrors.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCityErrors.ForeColor = System.Drawing.Color.DarkRed;
            this.lblCityErrors.Location = new System.Drawing.Point(18, 367);
            this.lblCityErrors.Name = "lblCityErrors";
            this.lblCityErrors.Size = new System.Drawing.Size(0, 25);
            this.lblCityErrors.TabIndex = 8;
            // 
            // dgwCityData
            // 
            this.dgwCityData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwCityData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwCityData.Location = new System.Drawing.Point(151, 29);
            this.dgwCityData.Name = "dgwCityData";
            this.dgwCityData.Size = new System.Drawing.Size(567, 308);
            this.dgwCityData.TabIndex = 9;
            this.dgwCityData.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgwCityData_RowHeaderMouseDoubleClick);
            // 
            // CityClass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 416);
            this.Controls.Add(this.dgwCityData);
            this.Controls.Add(this.lblCityErrors);
            this.Controls.Add(this.btnUpdateCity);
            this.Controls.Add(this.btnDeleteCity);
            this.Controls.Add(this.btnBackHome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAddCity);
            this.Controls.Add(this.cmbCoutry_id);
            this.Controls.Add(this.txtCityName);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CityClass";
            this.Text = "City";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CityClass_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dgwCityData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCityName;
        private System.Windows.Forms.ComboBox cmbCoutry_id;
        private System.Windows.Forms.Button btnAddCity;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnBackHome;
        private System.Windows.Forms.Button btnDeleteCity;
        private System.Windows.Forms.Button btnUpdateCity;
        private System.Windows.Forms.Label lblCityErrors;
        private System.Windows.Forms.DataGridView dgwCityData;
    }
}