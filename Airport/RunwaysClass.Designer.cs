namespace Airport
{
    partial class RunwaysClass
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RunwaysClass));
            this.txtRunwayName = new System.Windows.Forms.TextBox();
            this.cmbRunwayStatus = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRunwayAdd = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnRunwayDelete = new System.Windows.Forms.Button();
            this.btnRunwayUpdate = new System.Windows.Forms.Button();
            this.btnRunwayBack = new System.Windows.Forms.Button();
            this.dgwRunwayData = new System.Windows.Forms.DataGridView();
            this.lblRunwayErrors = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgwRunwayData)).BeginInit();
            this.SuspendLayout();
            // 
            // txtRunwayName
            // 
            this.txtRunwayName.Location = new System.Drawing.Point(12, 118);
            this.txtRunwayName.Name = "txtRunwayName";
            this.txtRunwayName.Size = new System.Drawing.Size(100, 20);
            this.txtRunwayName.TabIndex = 2;
            // 
            // cmbRunwayStatus
            // 
            this.cmbRunwayStatus.FormattingEnabled = true;
            this.cmbRunwayStatus.Items.AddRange(new object[] {
            "Active",
            "Passive"});
            this.cmbRunwayStatus.Location = new System.Drawing.Point(12, 194);
            this.cmbRunwayStatus.Name = "cmbRunwayStatus";
            this.cmbRunwayStatus.Size = new System.Drawing.Size(99, 21);
            this.cmbRunwayStatus.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Runway name";
            // 
            // btnRunwayAdd
            // 
            this.btnRunwayAdd.Location = new System.Drawing.Point(12, 244);
            this.btnRunwayAdd.Name = "btnRunwayAdd";
            this.btnRunwayAdd.Size = new System.Drawing.Size(99, 23);
            this.btnRunwayAdd.TabIndex = 5;
            this.btnRunwayAdd.Text = "Add";
            this.btnRunwayAdd.UseVisualStyleBackColor = true;
            this.btnRunwayAdd.Click += new System.EventHandler(this.btnRunwayAdd_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Status";
            // 
            // btnRunwayDelete
            // 
            this.btnRunwayDelete.Location = new System.Drawing.Point(12, 244);
            this.btnRunwayDelete.Name = "btnRunwayDelete";
            this.btnRunwayDelete.Size = new System.Drawing.Size(99, 23);
            this.btnRunwayDelete.TabIndex = 7;
            this.btnRunwayDelete.Text = "Delete";
            this.btnRunwayDelete.UseVisualStyleBackColor = true;
            this.btnRunwayDelete.Visible = false;
            this.btnRunwayDelete.Click += new System.EventHandler(this.btnRunwayDelete_Click);
            // 
            // btnRunwayUpdate
            // 
            this.btnRunwayUpdate.Location = new System.Drawing.Point(12, 307);
            this.btnRunwayUpdate.Name = "btnRunwayUpdate";
            this.btnRunwayUpdate.Size = new System.Drawing.Size(99, 23);
            this.btnRunwayUpdate.TabIndex = 8;
            this.btnRunwayUpdate.Text = "Update";
            this.btnRunwayUpdate.UseVisualStyleBackColor = true;
            this.btnRunwayUpdate.Visible = false;
            this.btnRunwayUpdate.Click += new System.EventHandler(this.btnRunwayUpdate_Click);
            // 
            // btnRunwayBack
            // 
            this.btnRunwayBack.Location = new System.Drawing.Point(15, 39);
            this.btnRunwayBack.Name = "btnRunwayBack";
            this.btnRunwayBack.Size = new System.Drawing.Size(99, 23);
            this.btnRunwayBack.TabIndex = 9;
            this.btnRunwayBack.Text = "Page home";
            this.btnRunwayBack.UseVisualStyleBackColor = true;
            this.btnRunwayBack.Click += new System.EventHandler(this.btnRunwayBack_Click);
            // 
            // dgwRunwayData
            // 
            this.dgwRunwayData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwRunwayData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwRunwayData.Location = new System.Drawing.Point(161, 39);
            this.dgwRunwayData.Name = "dgwRunwayData";
            this.dgwRunwayData.Size = new System.Drawing.Size(481, 245);
            this.dgwRunwayData.TabIndex = 10;
            this.dgwRunwayData.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgwRunwayData_RowHeaderMouseDoubleClick);
            // 
            // lblRunwayErrors
            // 
            this.lblRunwayErrors.AutoSize = true;
            this.lblRunwayErrors.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRunwayErrors.ForeColor = System.Drawing.Color.DarkRed;
            this.lblRunwayErrors.Location = new System.Drawing.Point(12, 356);
            this.lblRunwayErrors.Name = "lblRunwayErrors";
            this.lblRunwayErrors.Size = new System.Drawing.Size(0, 25);
            this.lblRunwayErrors.TabIndex = 11;
            // 
            // RunwaysClass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 432);
            this.Controls.Add(this.lblRunwayErrors);
            this.Controls.Add(this.dgwRunwayData);
            this.Controls.Add(this.btnRunwayBack);
            this.Controls.Add(this.btnRunwayUpdate);
            this.Controls.Add(this.btnRunwayDelete);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnRunwayAdd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbRunwayStatus);
            this.Controls.Add(this.txtRunwayName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RunwaysClass";
            this.Text = "Runways";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.RunwaysClass_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dgwRunwayData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtRunwayName;
        private System.Windows.Forms.ComboBox cmbRunwayStatus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRunwayAdd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnRunwayDelete;
        private System.Windows.Forms.Button btnRunwayUpdate;
        private System.Windows.Forms.Button btnRunwayBack;
        private System.Windows.Forms.DataGridView dgwRunwayData;
        private System.Windows.Forms.Label lblRunwayErrors;
    }
}