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
    public partial class EditNalogDAAB : Form
    {
        public EditNalogDAAB()
        {
            InitializeComponent();
            FillDrivers();
            FillVehicles();
            cbNalogType.DataSource = Enum.GetValues(typeof(Tip));
        }

        private void FillDrivers()
        {
            try
            {
                lbDrivers.DataSource = DBHandler.GetAllVozaci().ToList();
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
                lbVehicles.DataSource = DBHandler.GetAllVozila().ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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
            return tbDays.Text;
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
        public Tip GetNalogType()
        {
            return (Tip)Enum.Parse(typeof(Tip), cbNalogType.SelectedItem.ToString(), true);
        }
        public string GetKilometri()
        {
            return tbKilometri.Text;
        }
        public string GetSpeed()
        {
            return tbSpeed.Text;
        }
        public string GetFuel()
        {
            return tbFuel.Text;
        }

        public void SetStartCity(string PocetniGrad)
        {
            tbStartCity.Text = PocetniGrad;
        }
        public void SetEndCity(string ZavrsniGrad)
        {
            tbEndCity.Text = ZavrsniGrad;
        }
        public void SetDays(int BrojDana)
        {
            tbDays.Text = BrojDana.ToString();
        }
        public void SetDriver(int Vozacid)
        {
            lbDrivers.SelectedItem = Vozacid;
        }
        public void SetVehicle(int Voziloid)
        {
            lbVehicles.SelectedItem = Voziloid;
        }
        public void SetNalogType(Tip tip)
        {
            cbNalogType.SelectedItem = (Tip)Enum.Parse(typeof(Tip), tip.ToString(), true);
        }
        public void SetKilometri(int Kilometri)
        {
            tbKilometri.Text = Kilometri.ToString();
        }
        public void SetSpeed(int Brzina)
        {
            tbSpeed.Text = Brzina.ToString();
        }
        public void SetFuel(int Gorivo)
        {
            tbFuel.Text = Gorivo.ToString();
        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            new DAAB().Show();
            this.Hide();
        }
    }
}
