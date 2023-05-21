using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PPPK_DESKTOP.Forms
{
    public partial class AddVehicle : Form
    {
        public AddVehicle()
        {
            InitializeComponent();
        }

        public string GetTypeOfVehicle()
        {
            return tbTypeOfVehicle.Text;
        }
        public string GetMarkaVehicle()
        {
            return tbMarkaVehicle.Text;
        }
        public string GetYearOfProduction()
        {
            return tbYearOfProduction.Text.Trim();
        }
        public string GetInicijalniBrojKilometara()
        {
            return tbKilometri.Text.Trim();
        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            new Main().Show();
            this.Hide();
        }
    }
}
