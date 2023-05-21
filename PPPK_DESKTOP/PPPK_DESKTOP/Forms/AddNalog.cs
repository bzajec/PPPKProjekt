using PPPK_DESKTOP.DAL;
using PPPK_DESKTOP.Model;
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
    public partial class AddNalog : Form
    {
        public AddNalog()
        {
            InitializeComponent();
        }

        public string GetStartCity()
        {
            return tbStartCity.Text;
        }
        public string GetEndCity()
        {
            return tbEndCity.Text;
        }
        public string GetDays()
        {
            return tbDays.Text.Trim();
        }

        public int GetDriver()
        {
            var vozac = lbDrivers.SelectedItem as Vozac;
            return vozac.IDVozac;
        }
        public int GetVehicle()
        {
            var vozilo = lbVehicles.SelectedItem as Vozilo;
            return vozilo.IDVozilo;
        }
        public Tip GetTypeNalog()
        {
            return (Tip)Enum.Parse(typeof(Tip), cbNalogType.SelectedItem.ToString(), true);
        }
        public string GetKilometri()
        {
            return tbKilometri.Text.Trim();
        }
        public string GetSpeed()
        {
            return tbSpeed.Text.Trim();
        }
        public string GetFuel()
        {
            return tbFuel.Text.Trim();
        }

        private void AddNalog_Load(object sender, EventArgs e)
        {
            FillDrivers();
            FillVehicles();
            cbNalogType.DataSource = Enum.GetValues(typeof(Tip));
        }

        private void FillDrivers()
        {
            try
            {
                lbDrivers.DataSource = SqlHandler.GetAllVozaci();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FillVehicles()
        {
            try
            {
                lbVehicles.DataSource = SqlHandler.GetAllVozila();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            new Main().Show();
            this.Hide();
        }
    }
}
