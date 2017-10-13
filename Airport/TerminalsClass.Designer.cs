namespace Airport
{
    partial class TerminalsClass
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
            this.txtTerminalName = new System.Windows.Forms.TextBox();
            this.cmbTerminalStatus = new System.Windows.Forms.ComboBox();
            this.btnAddTerminal = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDeleteTerminal = new System.Windows.Forms.Button();
            this.btnUpdateTerminal = new System.Windows.Forms.Button();
            this.lblErrorsTerminal = new System.Windows.Forms.Label();
            this.btnHomeBack = new System.Windows.Forms.Button();
            this.dgwTerminalData = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgwTerminalData)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Terminal name";
            // 
            // txtTerminalName
            // 
            this.txtTerminalName.Location = new System.Drawing.Point(13, 119);
            this.txtTerminalName.Name = "txtTerminalName";
            this.txtTerminalName.Size = new System.Drawing.Size(97, 20);
            this.txtTerminalName.TabIndex = 1;
            // 
            // cmbTerminalStatus
            // 
            this.cmbTerminalStatus.FormattingEnabled = true;
            this.cmbTerminalStatus.Items.AddRange(new object[] {
            "Active",
            "Passive"});
            this.cmbTerminalStatus.Location = new System.Drawing.Point(13, 211);
            this.cmbTerminalStatus.Name = "cmbTerminalStatus";
            this.cmbTerminalStatus.Size = new System.Drawing.Size(97, 21);
            this.cmbTerminalStatus.TabIndex = 2;
            // 
            // btnAddTerminal
            // 
            this.btnAddTerminal.Location = new System.Drawing.Point(13, 282);
            this.btnAddTerminal.Name = "btnAddTerminal";
            this.btnAddTerminal.Size = new System.Drawing.Size(97, 23);
            this.btnAddTerminal.TabIndex = 3;
            this.btnAddTerminal.Text = "Add terminal";
            this.btnAddTerminal.UseVisualStyleBackColor = true;
            this.btnAddTerminal.Click += new System.EventHandler(this.btnAddTerminal_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Status";
            // 
            // btnDeleteTerminal
            // 
            this.btnDeleteTerminal.Location = new System.Drawing.Point(13, 282);
            this.btnDeleteTerminal.Name = "btnDeleteTerminal";
            this.btnDeleteTerminal.Size = new System.Drawing.Size(97, 23);
            this.btnDeleteTerminal.TabIndex = 5;
            this.btnDeleteTerminal.Text = "Delete";
            this.btnDeleteTerminal.UseVisualStyleBackColor = true;
            this.btnDeleteTerminal.Visible = false;
            this.btnDeleteTerminal.Click += new System.EventHandler(this.btnDeleteTerminal_Click);
            // 
            // btnUpdateTerminal
            // 
            this.btnUpdateTerminal.Location = new System.Drawing.Point(12, 346);
            this.btnUpdateTerminal.Name = "btnUpdateTerminal";
            this.btnUpdateTerminal.Size = new System.Drawing.Size(97, 23);
            this.btnUpdateTerminal.TabIndex = 6;
            this.btnUpdateTerminal.Text = "Update";
            this.btnUpdateTerminal.UseVisualStyleBackColor = true;
            this.btnUpdateTerminal.Visible = false;
            this.btnUpdateTerminal.Click += new System.EventHandler(this.btnUpdateTerminal_Click);
            // 
            // lblErrorsTerminal
            // 
            this.lblErrorsTerminal.AutoSize = true;
            this.lblErrorsTerminal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorsTerminal.ForeColor = System.Drawing.Color.DarkRed;
            this.lblErrorsTerminal.Location = new System.Drawing.Point(13, 411);
            this.lblErrorsTerminal.Name = "lblErrorsTerminal";
            this.lblErrorsTerminal.Size = new System.Drawing.Size(0, 25);
            this.lblErrorsTerminal.TabIndex = 7;
            // 
            // btnHomeBack
            // 
            this.btnHomeBack.Location = new System.Drawing.Point(13, 25);
            this.btnHomeBack.Name = "btnHomeBack";
            this.btnHomeBack.Size = new System.Drawing.Size(97, 23);
            this.btnHomeBack.TabIndex = 8;
            this.btnHomeBack.Text = "Page home";
            this.btnHomeBack.UseVisualStyleBackColor = true;
            this.btnHomeBack.Click += new System.EventHandler(this.btnHomeBack_Click);
            // 
            // dgwTerminalData
            // 
            this.dgwTerminalData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwTerminalData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwTerminalData.Location = new System.Drawing.Point(166, 25);
            this.dgwTerminalData.Name = "dgwTerminalData";
            this.dgwTerminalData.Size = new System.Drawing.Size(611, 344);
            this.dgwTerminalData.TabIndex = 9;
            this.dgwTerminalData.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgwTerminalData_RowHeaderMouseDoubleClick);
            // 
            // TerminalsClass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 475);
            this.Controls.Add(this.dgwTerminalData);
            this.Controls.Add(this.btnHomeBack);
            this.Controls.Add(this.lblErrorsTerminal);
            this.Controls.Add(this.btnUpdateTerminal);
            this.Controls.Add(this.btnDeleteTerminal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAddTerminal);
            this.Controls.Add(this.cmbTerminalStatus);
            this.Controls.Add(this.txtTerminalName);
            this.Controls.Add(this.label1);
            this.Name = "TerminalsClass";
            this.Text = "Terminal";
            ((System.ComponentModel.ISupportInitialize)(this.dgwTerminalData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTerminalName;
        private System.Windows.Forms.ComboBox cmbTerminalStatus;
        private System.Windows.Forms.Button btnAddTerminal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDeleteTerminal;
        private System.Windows.Forms.Button btnUpdateTerminal;
        private System.Windows.Forms.Label lblErrorsTerminal;
        private System.Windows.Forms.Button btnHomeBack;
        private System.Windows.Forms.DataGridView dgwTerminalData;
    }
}