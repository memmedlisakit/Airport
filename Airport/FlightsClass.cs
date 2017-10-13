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
    public partial class FlightsClass : Form
    {
        AirportDatabaseEntities db = new AirportDatabaseEntities();
        Flight selectedItem; 

        public FlightsClass()
        {
            InitializeComponent();
            this.fillCitiesName();
            this.fillCompaniesName();
            this.fillGatesName();
            this.fillRunwaysName();
            this.fillTerminalsName();
            fillDgwFlightsData();
        }
        
        private void clearText()
        {
            this.cmbCities.Text = "";
            this.cmbCompanies.Text = "";
            this.cmbGates.Text = "";
            this.cmbRunways.Text = "";
            this.cmbStatus.Text = "";
            this.cmbTerminals.Text = "";
            this.cmbType.Text = "";
            this.lblbErrors.Text = "";
            this.fillDgwFlightsData();
            this.btnAddFlight.Visible = true;
            this.btnUpdate.Visible = false;
        }

        private void fillDgwFlightsData()
        {
            this.dgwFlightsData.DataSource = db.Flights.Select(fl => new
            {
                Id = fl.Id,
                CityName =fl.City.Name,
                CompanyName = fl.Company.Name,
                Type = fl.Type==1?"Ucush":"Enish",
                Status = fl.Status==1? "Active" : "Passive",
                Gate = fl.Gate.Name,
                Runway = fl.Runway.Name,
                Terminal = fl.Terminal.Name,
                Date = fl.Date
            }).ToList();

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 frm1 = new Form1();
            frm1.Show();
        }

        private void fillCitiesName()
        {
            var citiy = db.Cities.Select(cty => cty.Name.Trim()).ToArray<string>();
            this.cmbCities.Items.AddRange(citiy);
        }

        private void fillCompaniesName()
        {
            var company = db.Companies.Select(cmp => cmp.Name.Trim()).ToArray<string>();
            this.cmbCompanies.Items.AddRange(company);
        }

        private void fillGatesName()
        {
            var gate = db.Gates.Select(gt => gt.Name.Trim()).ToArray<string>();
            this.cmbGates.Items.AddRange(gate);
        }

        private void fillRunwaysName()
        {
            var runway = db.Runways.Select(rnw => rnw.Name.Trim()).ToArray<string>();
            this.cmbRunways.Items.AddRange(runway);
        }

        private void fillTerminalsName()
        {
            var terminal = db.Terminals.Select(trm => trm.Name.Trim()).ToArray<string>();
            this.cmbTerminals.Items.AddRange(terminal);
        }

        private void btnAddFlight_Click(object sender, EventArgs e)
        {
            string cityName = this.cmbCities.Text;
            string companiyName = this.cmbCompanies.Text;
            string gateName = this.cmbGates.Text;
            string runwayName = this.cmbRunways.Text;
            string terminalName = this.cmbTerminals.Text;
            string status = this.cmbStatus.Text;
            string typeName = this.cmbType.Text;
            DateTime dateTime = this.dateTimeFlights.Value;
          

            void addFlightData()
            {
                Flight flight = new Flight();
                flight.City_id = this.getCityIdByName(cityName);
                flight.Company_id = this.getCompanyIdByName(companiyName);
                flight.Gate_id = this.getGateIdByName(gateName);
                flight.Terminal_id = this.getTerminalIdByName(terminalName);
                flight.Runway_id = this.getRunwayIdByName(runwayName);
                flight.Status = this.checkStatus(status);
                flight.Type = this.checkType(typeName);
                flight.Date = dateTime;
                db.Flights.Add(flight);
                db.SaveChanges();
                this.clearText();

                }

            if (cityName != string.Empty && companiyName != string.Empty && gateName != string.Empty &&
                runwayName != string.Empty && terminalName != string.Empty && status != string.Empty && typeName != string.Empty)
            {
                Flight selectedFlight;
                bool condition = true;
                for (int i = 1; i <= db.Flights.Count(); i++)
                {
                    selectedFlight = db.Flights.Find(i);
                    if (selectedFlight.Gate.Name.Trim() == gateName && selectedFlight.Runway.Name.Trim() == runwayName && selectedFlight.Date.Value > dateTime.AddMinutes(-45))
                    {
                        condition = false;
                        break;
                    }
                    else if (selectedFlight.Date <= dateTime.AddMinutes(-45))
                    {
                        if (selectedFlight.Gate.Name != gateName)
                        {
                            condition = true;
                        }
                        else if (selectedFlight.Runway.Name != runwayName)
                        {
                            condition = true;
                        }
                    }
                    else if (selectedFlight.Gate.Name.Trim() == gateName && selectedFlight.Runway.Name.Trim() == runwayName)
                    {
                        if (selectedFlight.Date <= dateTime.AddMinutes(-45))
                        {
                            condition = true;
                        }
                    }
                }
                if (condition == true)
                {
                    addFlightData();
                    this.fillDgwFlightsData();
                }
                else
                {
                    this.lblbErrors.Text = "Emeliyyet alinmadi !...";
                }
            }
            else
            {
                this.lblbErrors.Text = "Butun melumatlari doldurun !...";
            }
        }

        private int getCityIdByName( string prm_cityName)
        {
            City cty = db.Cities.Where(cy => cy.Name == prm_cityName).First();
            return cty.Id;
        }

        private int getCompanyIdByName(string prm_companyName)
        {
            Company cmpy = db.Companies.Where(cmp => cmp.Name == prm_companyName).First();
            return cmpy.Id;
        }

        private int getGateIdByName(string prm_gateName)
        {
            Gate gate = db.Gates.Where(gt => gt.Name == prm_gateName).First();
            return gate.Id;
        }

        private int getRunwayIdByName(string prm_runwayName)
        {
            Runway rnwy = db.Runways.Where(rn => rn.Name == prm_runwayName).First();
            return rnwy.Id;
        }

        private int getTerminalIdByName(string prm_terminalName)
        {
            Terminal trm = db.Terminals.Where(tr => tr.Name == prm_terminalName).First();
            return trm.Id;
        }


        private byte checkStatus(string prm_status)
        {
            if (prm_status == "Active")
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }

        private byte checkType(string prm_type)
        {
            if (prm_type == "Ucush")
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }

        private void dgwFlightsData_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int id = Convert.ToInt32(this.dgwFlightsData.Rows[e.RowIndex].Cells[0].Value);
            this.selectedItem = db.Flights.Find(id);
            this.cmbStatus.Text = selectedItem.Status == 1 ? "Active" : "Passive";
            this.cmbType.Text = selectedItem.Type == 1 ? "Ucush" : "Enish";
            this.cmbCities.Text = selectedItem.City.Name;
            this.cmbCompanies.Text = selectedItem.Company.Name;
            this.dateTimeFlights.Value = selectedItem.Date.Value;
            this.cmbGates.Text = selectedItem.Gate.Name;
            this.cmbRunways.Text = selectedItem.Runway.Name;
            this.cmbTerminals.Text = selectedItem.Terminal.Name;
            this.btnAddFlight.Visible = false;
            this.btnUpdate.Visible = true;
        }

       
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string cityName = this.cmbCities.Text;
            string companiyName = this.cmbCompanies.Text;
            string gateName = this.cmbGates.Text;
            string runwayName = this.cmbRunways.Text;
            string terminalName = this.cmbTerminals.Text;
            string status = this.cmbStatus.Text;
            string typeName = this.cmbType.Text;
            DateTime dateTime = this.dateTimeFlights.Value;
            string insertTime = dateTime.ToString("dd/MM/yyyy hh:mm tt");
            dateTime = Convert.ToDateTime(insertTime);

            void addFlightData()
            {
                this.selectedItem.City_id = this.getCityIdByName(cityName);
                this.selectedItem.Company_id = this.getCompanyIdByName(companiyName);
                this.selectedItem.Gate_id = this.getGateIdByName(gateName);
                this.selectedItem.Terminal_id = this.getTerminalIdByName(terminalName);
                this.selectedItem.Runway_id = this.getRunwayIdByName(runwayName);
                this.selectedItem.Status = this.checkStatus(status);
                this.selectedItem.Type = this.checkType(typeName);
                this.selectedItem.Date = dateTime;
                db.SaveChanges();
                this.clearText();

            }
            if (cityName != string.Empty && companiyName != string.Empty && gateName != string.Empty &&
                runwayName != string.Empty && terminalName != string.Empty && status != string.Empty && typeName != string.Empty)
            {
                Flight selectedItem;
                bool condition = true;
                for (int i = 1; i <= db.Flights.Count(); i++)
                {
                    selectedItem = db.Flights.Find(i);
                    if (selectedItem.Gate.Name.Trim() == gateName && selectedItem.Runway.Name.Trim() == runwayName && selectedItem.Date > dateTime.AddMinutes(-45))
                    {
                        condition = false;
                        break;
                    }
                    else if (selectedItem.Date <= dateTime.AddMinutes(-45))
                    {
                        if (selectedItem.Gate.Name != gateName)
                        {
                            condition = true;
                        }
                        else if (selectedItem.Runway.Name != runwayName)
                        {
                            condition = true;
                        }
                    }
                    else if (selectedItem.Gate.Name.Trim() == gateName && selectedItem.Runway.Name.Trim() == runwayName)
                    {
                        if (selectedItem.Date <= dateTime.AddMinutes(-45))
                        {
                            condition = true;
                        }
                    }
                }
                if (condition == true)
                {
                    addFlightData();
                    this.fillDgwFlightsData();
                }
                else
                {
                    this.lblbErrors.Text = "Emeliyyet alinmadi !...";
                }
            }
            else
            {
                this.lblbErrors.Text = "Butun melumatlari doldurun !...";
            }
        }
    }
}
