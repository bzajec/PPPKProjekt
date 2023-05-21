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
    public partial class UpdateServices : Form
    {

        private PPPK_ProjektEntities pPPK_ProjektEntities = new PPPK_ProjektEntities();
        int id;
        private Vozilo selectedVehicle;
        private Item selectedItem;

        public UpdateServices(int id)
        {
            InitializeComponent();
            Init();
            this.id = id;
        }

        private void Init()
        {
            lbVehicles.DataSource = pPPK_ProjektEntities.Voziloes.ToList();
            lbItems.DataSource = pPPK_ProjektEntities.Items.ToList();
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            new Main().Show();
            this.Hide();
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            new AddItem().Show();
            this.Hide();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Vozilo vozilo = lbVehicles.SelectedItem as Vozilo;
            Item item = lbItems.SelectedItem as Item;
            pPPK_ProjektEntities.UpdateServis(id, item.IDItem, vozilo.IDVozilo);
            pPPK_ProjektEntities.SaveChanges();
            new Main().Show();
            this.Hide();
        }

        private void lbVehicles_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedVehicle = lbVehicles.SelectedItem as Vozilo;
            lblType.Text = selectedVehicle.TipVozila;
            lblMarka.Text = selectedVehicle.MarkaVozila;
            lblGodina.Text = selectedVehicle.GodinaProizvodnje.ToString();
            lblKilometri.Text = selectedVehicle.InicijalnoStanjeKilometara.ToString();
        }

        private void lbItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedItem = lbItems.SelectedItem as Item;
            lblItem.Text = selectedItem.ItemName;
        }
    }
}
