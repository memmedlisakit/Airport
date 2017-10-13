using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Airport.Models;

namespace Airport
{
    public partial class TerminalsClass : Form
    {
        private AirportDatabaseEntities db = new AirportDatabaseEntities();
        private Terminal selectedItem;

        public TerminalsClass()
        {
            InitializeComponent();
            this.fillTerminalData();
        }

        private void fillTerminalData()
        {
            dgwTerminalData.DataSource = db.Terminals.Select(t => new
            {
                TerminalId = t.Id,
                Terminal_Name = t.Name,
                Status = t.Status == 1 ? "Active" : "Passive"
            }).ToList();
        }

        private void btnHomeBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 frm1 = new Form1();
            frm1.Show();
        }

        private void btnAddTerminal_Click(object sender, EventArgs e)
        {
            string TerminalName = this.txtTerminalName.Text;
            string status = this.cmbTerminalStatus.Text;
            if(TerminalName!= string.Empty && status != string.Empty)
            {
                int count = db.Terminals.Where(t => t.Name.Trim() == TerminalName).Count();
                if (count == 0)
                {
                    Terminal trml = new Terminal();
                    trml.Name = TerminalName;
                    trml.Status = this.checkStatus(status);
                    db.Terminals.Add(trml);
                    db.SaveChanges();
                    this.clearTerminalText();                    
                }
                else
                {
                    this.lblErrorsTerminal.Text = "Artiq movcuddur.";
                }
            }
            else
            {
                this.lblErrorsTerminal.Text = "Boshlugu doldurun !..";
            }
        }

        private int checkStatus(string status)
        {
            if (status == "Active")
            {
                return 1;
            }
            return 0;
        }

        private void clearTerminalText()
        {
            this.txtTerminalName.Clear();
            this.cmbTerminalStatus.Text = "";
            this.lblErrorsTerminal.Text = "";
            this.fillTerminalData();
            this.btnAddTerminal.Visible = true;
            this.btnDeleteTerminal.Visible = false;
            this.btnUpdateTerminal.Visible = false;

        }

        private void btnDeleteTerminal_Click(object sender, EventArgs e)
        {
            db.Terminals.Remove(this.selectedItem);
            db.SaveChanges();
            this.clearTerminalText();
        }

        private void btnUpdateTerminal_Click(object sender, EventArgs e)
        {
            string terminalName = this.txtTerminalName.Text;
            string status = cmbTerminalStatus.Text;
            if (terminalName != string.Empty && status != string.Empty)
            {
                int count = db.Terminals.Where(t => t.Name.Trim() == terminalName && t.Id != this.selectedItem.Id).Count();
                if (count == 0)
                {
                    this.selectedItem.Name = terminalName;
                    this.selectedItem.Status = this.checkStatus(status);
                    db.SaveChanges();
                    this.clearTerminalText();    
                }
                else
                {
                    this.lblErrorsTerminal.Text = "Artiq movcuddur.";
                }
            }
            else
            {
                this.lblErrorsTerminal.Text = "Boshlugu doldurun !..";
            }
        }

        private void dgwTerminalData_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int id  = Convert.ToInt32(dgwTerminalData.Rows[e.RowIndex].Cells[0].Value);
            this.selectedItem = db.Terminals.Find(id);
            this.txtTerminalName.Text = this.selectedItem.Name;
            this.cmbTerminalStatus.Text = this.selectedItem.Status == 1 ? "Active" : "Passive";
            db.SaveChanges();
            this.btnAddTerminal.Visible = false;
            this.btnDeleteTerminal.Visible = true;
            this.btnUpdateTerminal.Visible = true;
        }

        private void TerminalsClass_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
