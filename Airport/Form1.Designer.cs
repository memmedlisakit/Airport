namespace Airport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.seferlerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.melumatlarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.qapilarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uchushZolaqlariToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.terminallarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.shirketlerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.olklerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.olkelerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sheherlerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.seferlerToolStripMenuItem,
            this.melumatlarToolStripMenuItem,
            this.shirketlerToolStripMenuItem,
            this.olklerToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(634, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // seferlerToolStripMenuItem
            // 
            this.seferlerToolStripMenuItem.Name = "seferlerToolStripMenuItem";
            this.seferlerToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.seferlerToolStripMenuItem.Text = "Seferler";
            this.seferlerToolStripMenuItem.Click += new System.EventHandler(this.seferlerToolStripMenuItem_Click);
            // 
            // melumatlarToolStripMenuItem
            // 
            this.melumatlarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.qapilarToolStripMenuItem,
            this.uchushZolaqlariToolStripMenuItem,
            this.terminallarToolStripMenuItem});
            this.melumatlarToolStripMenuItem.Name = "melumatlarToolStripMenuItem";
            this.melumatlarToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.melumatlarToolStripMenuItem.Text = "Melumatlar";
            // 
            // qapilarToolStripMenuItem
            // 
            this.qapilarToolStripMenuItem.Name = "qapilarToolStripMenuItem";
            this.qapilarToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.qapilarToolStripMenuItem.Text = "Qapilar";
            this.qapilarToolStripMenuItem.Click += new System.EventHandler(this.qapilarToolStripMenuItem_Click);
            // 
            // uchushZolaqlariToolStripMenuItem
            // 
            this.uchushZolaqlariToolStripMenuItem.Name = "uchushZolaqlariToolStripMenuItem";
            this.uchushZolaqlariToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.uchushZolaqlariToolStripMenuItem.Text = "Uchush zolaqlari";
            this.uchushZolaqlariToolStripMenuItem.Click += new System.EventHandler(this.uchushZolaqlariToolStripMenuItem_Click);
            // 
            // terminallarToolStripMenuItem
            // 
            this.terminallarToolStripMenuItem.Name = "terminallarToolStripMenuItem";
            this.terminallarToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.terminallarToolStripMenuItem.Text = "Terminallar";
            this.terminallarToolStripMenuItem.Click += new System.EventHandler(this.terminallarToolStripMenuItem_Click);
            // 
            // shirketlerToolStripMenuItem
            // 
            this.shirketlerToolStripMenuItem.Name = "shirketlerToolStripMenuItem";
            this.shirketlerToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.shirketlerToolStripMenuItem.Text = "Shirketler";
            this.shirketlerToolStripMenuItem.Click += new System.EventHandler(this.shirketlerToolStripMenuItem_Click);
            // 
            // olklerToolStripMenuItem
            // 
            this.olklerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.olkelerToolStripMenuItem,
            this.sheherlerToolStripMenuItem});
            this.olklerToolStripMenuItem.Name = "olklerToolStripMenuItem";
            this.olklerToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.olklerToolStripMenuItem.Text = "Olkler";
            // 
            // olkelerToolStripMenuItem
            // 
            this.olkelerToolStripMenuItem.Name = "olkelerToolStripMenuItem";
            this.olkelerToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.olkelerToolStripMenuItem.Text = "Olkeler";
            this.olkelerToolStripMenuItem.Click += new System.EventHandler(this.olkelerToolStripMenuItem_Click);
            // 
            // sheherlerToolStripMenuItem
            // 
            this.sheherlerToolStripMenuItem.Name = "sheherlerToolStripMenuItem";
            this.sheherlerToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.sheherlerToolStripMenuItem.Text = "Sheherler";
            this.sheherlerToolStripMenuItem.Click += new System.EventHandler(this.sheherlerToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 375);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Airport Management";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem melumatlarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem qapilarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uchushZolaqlariToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem terminallarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem shirketlerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem olklerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem olkelerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sheherlerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem seferlerToolStripMenuItem;
    }
}

