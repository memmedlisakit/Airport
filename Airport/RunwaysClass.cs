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
    public partial class RunwaysClass : Form
    {
        private AirportDatabaseEntities db = new AirportDatabaseEntities();
        private Runway selectedItem;

        public RunwaysClass()
        {
            InitializeComponent();
            this.fillDataRunway();
            this.dgwRunwayData.Columns[0].Visible = false;
        }

        private void btnRunwayBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 frm1 = new Form1();
            frm1.Show();
        }

        private void btnRunwayAdd_Click(object sender, EventArgs e)
        {
            string runwayName = this.txtRunwayName.Text;
            string status = this.cmbRunwayStatus.Text;
            if(runwayName != string.Empty && status != string.Empty)
            {
                int count = db.Runways.Where(r => r.Name.Trim() == runwayName).Count();
                if (count == 0)
                {
                    Runway rnwy = new Runway();
                    rnwy.Name = runwayName;
                    rnwy.Status = this.chechStatus(status);
                    db.Runways.Add(rnwy);
                    db.SaveChanges();
                    this.clearRunwayText();
                }
                else
                {
                    this.lblRunwayErrors.Text = "Artiq movcuddur.";
                }
            }
            else
            {
                this.lblRunwayErrors.Text = "Boshlugu doldurun !..";
            }
        }

        private void fillDataRunway()
        {
            dgwRunwayData.DataSource = db.Runways.Select(r => new
            {
                RunwayId = r.Id,
                Name = r.Name,
                Status = r.Status == 1 ? "Active" : "Passive"
            }).ToList();
        }

        private void clearRunwayText()
        {
            this.txtRunwayName.Clear();
            this.cmbRunwayStatus.Text = "";
            this.lblRunwayErrors.Text = "";
            this.fillDataRunway();
            this.btnRunwayDelete.Visible = false;
            this.btnRunwayUpdate.Visible = false;
            this.btnRunwayAdd.Visible = true;
        }

        private int chechStatus(string status)
        {
            if (status == "Active")
            {
                return 1;
            }
            return 0;
        }

        private void RunwaysClass_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void dgwRunwayData_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int id = Convert.ToInt32(dgwRunwayData.Rows[e.RowIndex].Cells[0].Value);
            this.selectedItem = db.Runways.Find(id);
            this.txtRunwayName.Text = this.selectedItem.Name;
            this.cmbRunwayStatus.Text = this.selectedItem.Status == 1 ? "Active" : "Passive";
            this.btnRunwayAdd.Visible = false;
            this.btnRunwayUpdate.Visible = true;
            this.btnRunwayDelete.Visible = true;
        }

        private void btnRunwayDelete_Click(object sender, EventArgs e)
        {
            db.Runways.Remove(this.selectedItem);
            db.SaveChanges();
            this.clearRunwayText();
        }

        private void btnRunwayUpdate_Click(object sender, EventArgs e)
        {
            string runwayName = this.txtRunwayName.Text;
            string status = this.cmbRunwayStatus.Text;
            if (runwayName != string.Empty && status != string.Empty)
            {
                int count = db.Runways.Where(r => r.Name == runwayName.Trim() && r.Id != this.selectedItem.Id).Count();
                if(count == 0)
                {
                    this.selectedItem.Name = runwayName;
                    this.selectedItem.Status = this.chechStatus(status);
                    db.SaveChanges();
                    this.clearRunwayText();
                }
                else
                {
                    this.lblRunwayErrors.Text = "Artiq movcuddur.";
                }
            }
            else
            {
                this.lblRunwayErrors.Text = "Boshlugu doldurun !..";
            }
        }
    }
}
