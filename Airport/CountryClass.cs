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
    public partial class CountryClass : Form
    {
        private AirportDatabaseEntities db = new AirportDatabaseEntities();
        Country selectedItem;

        public CountryClass()
        {
            InitializeComponent();
            this.fillCounrtyData();
        }

        private void btnBackHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 frm1 = new Form1();
            frm1.Show();
        }

        private void btnCountryAdd_Click(object sender, EventArgs e)
        {
            string countryName = this.txtCountryName.Text;
            if (countryName != string.Empty)
            {
                int count = db.Countries.Where(c => c.Name.Trim() == countryName).Count();
                if (count == 0)
                {
                    Country cntr = new Country();
                    cntr.Name = countryName;
                    db.Countries.Add(cntr);
                    db.SaveChanges();
                    this.clearCountrytext();
                }
                else
                {
                    this.lblCoutryErrors.Text = "Artiq movcuddur.";
                }
                
            }
            else
            {
                this.lblCoutryErrors.Text = "Boshlugu doldurun.";
            }
        }

        private void clearCountrytext()
        {
            this.txtCountryName.Clear();
            this.lblCoutryErrors.Text = "";
            this.fillCounrtyData();
            this.btnDeleteCountry.Visible = false;
            this.btnUpdateCountry.Visible = false;
            this.btnCountryAdd.Visible = true;
        }

        private void fillCounrtyData()
        {
            this.dgwCountrData.DataSource = db.Countries.Select(c => new
            {
                CountryId = c.Id,
                CountryName = c.Name
            }).ToList();
        }

        private void dgwCountrData_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int id = Convert.ToInt32(this.dgwCountrData.Rows[e.RowIndex].Cells[0].Value);
            this.selectedItem = db.Countries.Find(id);
            this.txtCountryName.Text = this.selectedItem.Name;
            this.btnCountryAdd.Visible = false;
            this.btnDeleteCountry.Visible = true;
            this.btnUpdateCountry.Visible = true;
        }

        private void btnDeleteCountry_Click(object sender, EventArgs e)
        {
            db.Countries.Remove(this.selectedItem);
            db.SaveChanges();
            this.clearCountrytext();
        }

        private void btnUpdateCountry_Click(object sender, EventArgs e)
        {
            string countryName = this.txtCountryName.Text;
            if (countryName != string.Empty)
            {
                int count = db.Countries.Where(c => c.Name == countryName).Count();
                if (count == 0)
                {
                    this.selectedItem.Name = countryName;
                    db.SaveChanges();
                    this.clearCountrytext();
                }
                else
                {
                    this.lblCoutryErrors.Text = "Artiq movcuddur !..";
                }
            }
            else
            {
                this.lblCoutryErrors.Text = "Boshlugu doldurun !..";
            }
        }
    }
}
