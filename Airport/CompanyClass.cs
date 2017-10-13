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
    public partial class CompanyClass : Form
    {
            private AirportDatabaseEntities db = new AirportDatabaseEntities();
        Company selectedItem;
        public CompanyClass()
        {
            InitializeComponent();
            this.fillCmbCountryId();
            this.filldgwCompanyData();
            this.dgwCompanyData.Columns[0].Visible = false;
        }

        private void btnBackHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 frm1 = new Form1();
            frm1.Show();
        }

        private void fillCmbCountryId()
        {
            foreach(Country item in db.Countries.ToList())
            {
                cmbCountryId.Items.Add(item.Name.Trim());
            }
        }

        private void btnAddCompany_Click(object sender, EventArgs e)
        {
            string companyName = this.txtCompanyName.Text;
            string status = this.cmbCompanyStatus.Text;
            string country_id = this.cmbCountryId.Text;
            if (companyName != string.Empty && status != string.Empty && country_id != string.Empty)
            {
                int count = db.Companies.Where(c => c.Name.Trim() == companyName).Count();
                if (count == 0)
                {
                    Company cmpny = new Company();
                    cmpny.Name = companyName;
                    cmpny.Status = this.checkStatus(status);
                    cmpny.Country_id = this.getcountryIdByName(country_id);
                    db.Companies.Add(cmpny);
                    db.SaveChanges();
                    this.clearCompanyTxt();
                }
                else
                {
                    this.lblCompanyErrors.Text = "Artiq movcuddur !..";
                }
            }
            else
            {
                this.lblCompanyErrors.Text = "Boshlugu doldurun !..";
            }
        }

        private void clearCompanyTxt()
        {
            this.txtCompanyName.Clear();
            this.cmbCompanyStatus.Text = "";
            this.cmbCountryId.Text = "";
            this.filldgwCompanyData(); 
            this.btnAddCompany.Visible = true;
            this.btnDeleteCompany.Visible = false;
            this.btnUpdateCompany.Visible = false;

        }

        private int checkStatus( string prmStatus)
        {
            if (prmStatus == "Active")
            {
                return 1;
            }
            return 0;
        }

        private int getcountryIdByName(string prmName)
        {
            Country cntry = db.Countries.Where(c => c.Name == prmName).First();
            return cntry.Id;
        }

        private void filldgwCompanyData()
        {
            this.dgwCompanyData.DataSource = db.Companies.Select(c => new
            {
                Id = c.Id,
                Country_id = c.Country_id,
                Name = c.Name
            }).ToList();
        }
    }
}
