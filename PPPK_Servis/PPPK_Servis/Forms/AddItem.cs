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

    public partial class AddItem : Form
    {

        private PPPK_ProjektEntities pPPK_ProjektEntities = new PPPK_ProjektEntities();

        public AddItem()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            new EditServices().Show();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Item item = new Item();
            item.ItemName = tbItem.Text;
            pPPK_ProjektEntities.Items.Add(item);

            pPPK_ProjektEntities.SaveChanges();

            this.Hide();
            new EditServices().Show();
        }
    }
}
