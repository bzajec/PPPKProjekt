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
    public partial class EditDriver : Form
    {
        public EditDriver()
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
        public void SetName(string ime)
        {
            tbName.Text = ime;
        }
        public void SetMobileNumber(int brojmoba)
        {
            tbMobileNumber.Text = brojmoba.ToString();
        }
        public void SetDriversLicence(int vozacka)
        {
            tbDriversLicence.Text = vozacka.ToString();
        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            new Main().Show();
            this.Hide();
        }
    }
}
