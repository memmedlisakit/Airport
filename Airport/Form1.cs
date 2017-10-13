using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Airport
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void qapilarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            GateClass gte = new GateClass();
            gte.Show();
        }

        private void uchushZolaqlariToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            RunwaysClass rnwy = new RunwaysClass();
            rnwy.Show();
        }

        private void terminallarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            TerminalsClass tml = new TerminalsClass();
            tml.Show();
        }

        private void olkelerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            CountryClass cntr = new CountryClass();
            cntr.Show();
        }

        private void sheherlerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            CityClass cty = new CityClass();
            cty.Show();
        }

        private void shirketlerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            CompanyClass cmpny = new CompanyClass();
            cmpny.Show();
        }

        private void seferlerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FlightsClass flgt = new FlightsClass();
            flgt.Show();
        }
    }
}
