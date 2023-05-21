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
    public partial class AddDriver : Form
    {
        public AddDriver()
        {
            InitializeComponent();
        }

        public string GetName()
        {
            return tbName.Text;
        }
        public string GetMobileNumber()
        {
            return tbMobileNumber.Text.Trim();
        }
        public string GetDriversLicence()
        {
            return tbDriversLicence.Text.Trim();
        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            new Main().Show();
            this.Hide();
        }
    }
}
