using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PPPK_Servis.Forms
{
    public partial class Main : Form
    {
        private PPPK_ProjektEntities pPPK_ProjektEntities = new PPPK_ProjektEntities();
        private Servi servis;
        private Item selectedItem;
        private Vozilo selectedVehicle;
        public Main()
        {
            InitializeComponent();
            Init();
        }

        private void Init()
        {
            lbServices.DataSource = pPPK_ProjektEntities.Servis.ToList();
        }

        private void btnAddService_Click(object sender, EventArgs e)
        {
            new EditServices().Show();
            this.Hide();
        }

        private void btnHtml_Click(object sender, EventArgs e)
        {
            HtmlGenerator.HtmlGeneratorr((lbServices.SelectedItem as Servi).Vozilo);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            pPPK_ProjektEntities.Servis.Remove(lbServices.SelectedItem as Servi);

            pPPK_ProjektEntities.SaveChanges();
            Init();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            new UpdateServices((lbServices.SelectedItem as Servi).IDServis).Show();
            this.Hide();
        }

        private void lbServices_SelectedIndexChanged(object sender, EventArgs e)
        {
            servis = lbServices.SelectedItem as Servi;
            selectedVehicle = servis.Vozilo as Vozilo;
            selectedItem = servis.Item as Item;
            lblServis.Text = servis.IDServis.ToString();
            lblVozilo.Text = selectedVehicle.TipVozila;
            lblMarka.Text = selectedVehicle.MarkaVozila;
            lblItem.Text = selectedItem.ItemName;
        }
    }
}
