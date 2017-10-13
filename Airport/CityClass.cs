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
    public partial class CityClass : Form
    {

        private AirportDatabaseEntities db = new AirportDatabaseEntities();
        City selectedItem;

        public CityClass()
        {
            InitializeComponent();
            this.fillCmbCountryId();
            this.fillCityData();
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
                this.cmbCoutry_id.Items.Add(item.Name.Trim());
            }
        }

        private void clearCityText()
        {
            this.txtCityName.Clear();
            this.cmbCoutry_id.Text = "";
            this.lblCityErrors.Text = "";
            this.fillCityData();
        }

        private int getCountrIdByName(string prmName)
        {
            Country cntry = db.Countries.Where(c => c.Name == prmName).First();
            return cntry.Id;
        }

        private void btnAddCity_Click(object sender, EventArgs e)
        {
            string cityName = this.txtCityName.Text;
            string country_id = cmbCoutry_id.Text;
            if (cityName != string.Empty && country_id != string.Empty)
            {
                int count = db.Cities.Where(c => c.Name.Trim() == cityName).Count();
                if (count == 0)
                {
                    City cty = new City();
                    cty.Name = cityName;
                    cty.Country_id = getCountrIdByName(country_id);
                    db.Cities.Add(cty);
                    db.SaveChanges();
                    this.fillCityData();
                    this.clearCityText();
                }
                else
                {
                    this.lblCityErrors.Text = "Artiq movcuddur.";
                }               
            }
            else
            {
                this.lblCityErrors.Text = "Boshlugu doldurun !..";
            }
        }

        private void fillCityData()
        {
            dgwCityData.DataSource = db.Cities.Select(c => new
            {
                Id = c.Id,
                Country_id = c.Country_id,
                City_name = c.Name
            }).ToList();
        }

        private void dgwCityData_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int id = Convert.ToInt32(dgwCityData.Rows[e.RowIndex].Cells[0].Value);
            this.selectedItem = db.Cities.Find(id);
            this.txtCityName.Text = this.selectedItem.Name;
            this.cmbCoutry_id.Text = this.selectedItem.Country.Name;
            this.btnAddCity.Visible = false;
            this.btnDeleteCity.Visible = true;
            this.btnUpdateCity.Visible = true;
        }

        private void btnDeleteCity_Click(object sender, EventArgs e)
        {
            db.Cities.Remove(this.selectedItem);
            db.SaveChanges();
            this.clearCityText();
        }

        private void btnUpdateCity_Click(object sender, EventArgs e)
        {
            string cityName = this.txtCityName.Text;
            string counrty_id = this.cmbCoutry_id.Text;
            if (cityName != string.Empty && counrty_id != string.Empty)
            {
                int count = db.Cities.Where(c => c.Name.Trim() == cityName && c.Id != this.selectedItem.Id).Count();
                if (count == 0)
                {
                    this.selectedItem.Name = cityName;
                    this.selectedItem.Country_id = this.getCountrIdByName(counrty_id);
                    db.SaveChanges();
                    this.clearCityText();
                }
                else
                {
                    this.lblCityErrors.Text = "Artiq movcuddur !..";
                }
            }
            else
            {
                this.lblCityErrors.Text = "Boshlugu doldurun !..";
            }
        }

        private void CityClass_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
