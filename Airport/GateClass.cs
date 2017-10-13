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
    public partial class GateClass : Form
    {

        private AirportDatabaseEntities db = new AirportDatabaseEntities();
        private Gate selectedItem;

        public GateClass()
        {
            InitializeComponent();
            this.fillGatesData();
            this.dgwGateData.Columns[0].Visible = false;
        }

        private void fillGatesData()
        {
            dgwGateData.DataSource = db.Gates.Select(g => new
            {
                GateId = g.Id,
                Name = g.Name,
                Status = g.Status == 1 ? "Active" : "Passive"

            }).ToList();
        }

        private void btnPageHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 frm1 = new Form1();
            frm1.Show();
        }

        private void btnGateAdd_Click(object sender, EventArgs e)
        {
            string gateName = this.txtGateName.Text;
            string status = this.cmbGateStatus.Text;
            if (gateName != string.Empty && status != string.Empty)
            {
                int count = db.Gates.Where(g => g.Name.Trim() == gateName).Count();
                if (count == 0)
                {
                    Gate gts = new Gate();
                    gts.Name = gateName;
                    gts.Status = this.CheckStatus(status);
                    db.Gates.Add(gts);
                    db.SaveChanges();
                    this.ClearGateTxt();
                }
                else
                {
                    this.lblGateErrors.Text = "Artiq bu gate var !..";
                }
            }
            else
            {
                this.lblGateErrors.Text = "Butun melumatlari doldurun !..";
            }
        }

        private void ClearGateTxt()
        {
            this.txtGateName.Clear();
            this.cmbGateStatus.Text = "";
            this.lblGateErrors.Text = "";
            this.fillGatesData();
        }

        private int CheckStatus(string status)
        {
            if (status == "Active")
            {
                return 1;
            }
            return 0;
        }

        private void dgwGateData_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int id = Convert.ToInt32(dgwGateData.Rows[e.RowIndex].Cells[0].Value);
            this.selectedItem = db.Gates.Find(id);
            this.txtGateName.Text = this.selectedItem.Name;
            this.cmbGateStatus.Text = this.selectedItem.Status == 1 ? "Active" : "Passive";
            this.btnGateAdd.Visible = false;
            this.btnGateDelete.Visible = true;
            this.btnGateUpdate.Visible = true;
        }

        private void btnGateDelete_Click(object sender, EventArgs e)
        {
            db.Gates.Remove(this.selectedItem);
            db.SaveChanges();
            this.ClearGateTxt();
        }

        private void btnGateUpdate_Click(object sender, EventArgs e)
        {
            string gateName = this.txtGateName.Text;
            string status = this.cmbGateStatus.Text;
            if (status != string.Empty && gateName != string.Empty)
            {
                int count = db.Gates.Where(g => g.Name.Trim() == gateName && g.Id != this.selectedItem.Id).Count();
                if (count == 0)
                {
                    this.selectedItem.Name = gateName;
                    this.selectedItem.Status = this.CheckStatus(status);
                    db.SaveChanges();
                    this.ClearGateTxt();
                }
                else
                {
                    this.lblGateErrors.Text = "Artiq bu gate var !..";
                }
            }
            else
            {
                this.lblGateErrors.Text = "Butun melumatlari doldurun !..";
            }

        }

        private void GateClass_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        
    }
}
