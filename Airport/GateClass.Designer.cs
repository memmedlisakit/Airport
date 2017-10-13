namespace Airport
{
    partial class GateClass
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GateClass));
            this.btnPageHome = new System.Windows.Forms.Button();
            this.txtGateName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbGateStatus = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnGateAdd = new System.Windows.Forms.Button();
            this.lblGateErrors = new System.Windows.Forms.Label();
            this.dgwGateData = new System.Windows.Forms.DataGridView();
            this.btnGateDelete = new System.Windows.Forms.Button();
            this.btnGateUpdate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgwGateData)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPageHome
            // 
            this.btnPageHome.Location = new System.Drawing.Point(12, 36);
            this.btnPageHome.Name = "btnPageHome";
            this.btnPageHome.Size = new System.Drawing.Size(103, 23);
            this.btnPageHome.TabIndex = 2;
            this.btnPageHome.Text = "Page home";
            this.btnPageHome.UseVisualStyleBackColor = true;
            this.btnPageHome.Click += new System.EventHandler(this.btnPageHome_Click);
            // 
            // txtGateName
            // 
            this.txtGateName.Location = new System.Drawing.Point(15, 123);
            this.txtGateName.Name = "txtGateName";
            this.txtGateName.Size = new System.Drawing.Size(100, 20);
            this.txtGateName.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AccessibleDescription = "";
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Gate name";
            // 
            // cmbGateStatus
            // 
            this.cmbGateStatus.FormattingEnabled = true;
            this.cmbGateStatus.Items.AddRange(new object[] {
            "Active",
            "Passive"});
            this.cmbGateStatus.Location = new System.Drawing.Point(15, 199);
            this.cmbGateStatus.Name = "cmbGateStatus";
            this.cmbGateStatus.Size = new System.Drawing.Size(100, 21);
            this.cmbGateStatus.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AccessibleDescription = "";
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Status";
            // 
            // btnGateAdd
            // 
            this.btnGateAdd.Location = new System.Drawing.Point(15, 275);
            this.btnGateAdd.Name = "btnGateAdd";
            this.btnGateAdd.Size = new System.Drawing.Size(100, 23);
            this.btnGateAdd.TabIndex = 7;
            this.btnGateAdd.Text = "Add gate";
            this.btnGateAdd.UseVisualStyleBackColor = true;
            this.btnGateAdd.Click += new System.EventHandler(this.btnGateAdd_Click);
            // 
            // lblGateErrors
            // 
            this.lblGateErrors.AccessibleDescription = "";
            this.lblGateErrors.AutoSize = true;
            this.lblGateErrors.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGateErrors.ForeColor = System.Drawing.Color.Red;
            this.lblGateErrors.Location = new System.Drawing.Point(7, 334);
            this.lblGateErrors.Name = "lblGateErrors";
            this.lblGateErrors.Size = new System.Drawing.Size(0, 25);
            this.lblGateErrors.TabIndex = 8;
            // 
            // dgwGateData
            // 
            this.dgwGateData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwGateData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwGateData.Location = new System.Drawing.Point(155, 36);
            this.dgwGateData.Name = "dgwGateData";
            this.dgwGateData.Size = new System.Drawing.Size(454, 262);
            this.dgwGateData.TabIndex = 9;
            this.dgwGateData.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgwGateData_RowHeaderMouseDoubleClick);
            // 
            // btnGateDelete
            // 
            this.btnGateDelete.Location = new System.Drawing.Point(12, 275);
            this.btnGateDelete.Name = "btnGateDelete";
            this.btnGateDelete.Size = new System.Drawing.Size(103, 23);
            this.btnGateDelete.TabIndex = 10;
            this.btnGateDelete.Text = "Delete";
            this.btnGateDelete.UseVisualStyleBackColor = true;
            this.btnGateDelete.Visible = false;
            this.btnGateDelete.Click += new System.EventHandler(this.btnGateDelete_Click);
            // 
            // btnGateUpdate
            // 
            this.btnGateUpdate.Location = new System.Drawing.Point(12, 359);
            this.btnGateUpdate.Name = "btnGateUpdate";
            this.btnGateUpdate.Size = new System.Drawing.Size(103, 23);
            this.btnGateUpdate.TabIndex = 11;
            this.btnGateUpdate.Text = "Update";
            this.btnGateUpdate.UseVisualStyleBackColor = true;
            this.btnGateUpdate.Visible = false;
            this.btnGateUpdate.Click += new System.EventHandler(this.btnGateUpdate_Click);
            // 
            // GateClass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 461);
            this.Controls.Add(this.btnGateUpdate);
            this.Controls.Add(this.btnGateDelete);
            this.Controls.Add(this.dgwGateData);
            this.Controls.Add(this.lblGateErrors);
            this.Controls.Add(this.btnGateAdd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbGateStatus);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtGateName);
            this.Controls.Add(this.btnPageHome);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GateClass";
            this.Text = "Gate";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.GateClass_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dgwGateData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnPageHome;
        private System.Windows.Forms.TextBox txtGateName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbGateStatus;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnGateAdd;
        private System.Windows.Forms.Label lblGateErrors;
        private System.Windows.Forms.DataGridView dgwGateData;
        private System.Windows.Forms.Button btnGateDelete;
        private System.Windows.Forms.Button btnGateUpdate;
    }
}