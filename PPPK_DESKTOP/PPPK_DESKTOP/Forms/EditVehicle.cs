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
    public partial class EditVehicle : Form
    {
        public EditVehicle()
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
        public string GetKilometri()
        {
            return tbKilometri.Text.Trim();
        }
        public string SetTypeOfVehicle(string tipVozila)
        {
            return tbTypeOfVehicle.Text = tipVozila;
        }
        public string SetMarkaVehicle(string markaVozila)
        {
            return tbMarkaVehicle.Text = markaVozila;
        }
        public string SetYearOfProduction(int godinaProizvodnje)
        {
            return tbYearOfProduction.Text = godinaProizvodnje.ToString();
        }
        public string SetKilometri(int inicijalniBrojKilometara)
        {
            return tbKilometri.Text = inicijalniBrojKilometara.ToString();
        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            new Main().Show();
            this.Hide();
        }
    }
}
