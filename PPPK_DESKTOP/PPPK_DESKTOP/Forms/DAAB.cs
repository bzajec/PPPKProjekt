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
    public partial class DAAB : Form
    {
        public DAAB()
        {
            InitializeComponent();
        }

        private void DAAB_Load(object sender, EventArgs e)
        {
            FillPutniNalozi();
        }

        private void FillPutniNalozi()
        {
            try
            {
                lbNalozi.DataSource = DBHandler.GetAllPutniNalogi().ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddNalogDAAB dodaj_DAAB_Putni = new AddNalogDAAB();
            DialogResult result = dodaj_DAAB_Putni.ShowDialog();
            if (result == DialogResult.OK
                && !string.IsNullOrEmpty(dodaj_DAAB_Putni.GetNalogType().ToString())
                && !string.IsNullOrEmpty(dodaj_DAAB_Putni.GetDriver().ToString())
                && !string.IsNullOrEmpty(dodaj_DAAB_Putni.GetVehicle().ToString())
                && !string.IsNullOrEmpty(dodaj_DAAB_Putni.GetStartCity())
                && !string.IsNullOrEmpty(dodaj_DAAB_Putni.GetEndCity())
                && !string.IsNullOrEmpty(dodaj_DAAB_Putni.GetDays())
                && !string.IsNullOrEmpty(dodaj_DAAB_Putni.GetKilometri())
                && !string.IsNullOrEmpty(dodaj_DAAB_Putni.GetSpeed())
                && !string.IsNullOrEmpty(dodaj_DAAB_Putni.GetFuel())
                )
            {
                try
                {
                    if (DBHandler.AddPutniNalog(new PutniNalog(dodaj_DAAB_Putni.GetDriver(), dodaj_DAAB_Putni.GetVehicle(), dodaj_DAAB_Putni.GetNalogType(), dodaj_DAAB_Putni.GetStartCity(), dodaj_DAAB_Putni.GetEndCity(), int.Parse(dodaj_DAAB_Putni.GetDays()), int.Parse(dodaj_DAAB_Putni.GetKilometri()), int.Parse(dodaj_DAAB_Putni.GetSpeed()), int.Parse(dodaj_DAAB_Putni.GetFuel()))) > 0)
                    {
                        FillPutniNalozi();
                        this.Show();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else if (result == DialogResult.Cancel)
            {
            }
            else
            {
                this.Show();
                MessageBox.Show("Neušpjesno dodavanje", "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (lbNalozi.SelectedIndex < 0)
            {
                return;
            }
            this.Hide();
            EditNalogDAAB uredi_DAAB_Putni = new EditNalogDAAB();
            var putninalog = lbNalozi.SelectedItem as PutniNalog;
            uredi_DAAB_Putni.SetDriver(putninalog.VozacID);
            uredi_DAAB_Putni.SetVehicle(putninalog.VoziloID);
            uredi_DAAB_Putni.SetNalogType(putninalog.Tip);
            uredi_DAAB_Putni.SetStartCity(putninalog.PocetniGrad);
            uredi_DAAB_Putni.SetEndCity(putninalog.ZavrsniGrad);
            uredi_DAAB_Putni.SetDays(putninalog.OcekivaniDani);
            uredi_DAAB_Putni.SetKilometri(putninalog.Kilometri);
            uredi_DAAB_Putni.SetSpeed(putninalog.Brzina);
            uredi_DAAB_Putni.SetFuel(putninalog.Gorivo);
            DialogResult result = uredi_DAAB_Putni.ShowDialog();
            if (result == DialogResult.OK
                && !string.IsNullOrEmpty(uredi_DAAB_Putni.GetDriver().ToString())
                && !string.IsNullOrEmpty(uredi_DAAB_Putni.GetVehicle().ToString())
                && !string.IsNullOrEmpty(uredi_DAAB_Putni.GetNalogType().ToString())
                && !string.IsNullOrEmpty(uredi_DAAB_Putni.GetStartCity())
                && !string.IsNullOrEmpty(uredi_DAAB_Putni.GetEndCity())
                && !string.IsNullOrEmpty(uredi_DAAB_Putni.GetDays().ToString())
                && !string.IsNullOrEmpty(uredi_DAAB_Putni.GetKilometri().ToString())
                && !string.IsNullOrEmpty(uredi_DAAB_Putni.GetSpeed().ToString())
                && !string.IsNullOrEmpty(uredi_DAAB_Putni.GetFuel().ToString()))
            {
                try
                {
                    if (DBHandler.UpdatePutniNalog(new PutniNalog(putninalog.IDPutniNalog, uredi_DAAB_Putni.GetDriver(), uredi_DAAB_Putni.GetVehicle(), uredi_DAAB_Putni.GetNalogType(), uredi_DAAB_Putni.GetStartCity(), uredi_DAAB_Putni.GetEndCity(), int.Parse(uredi_DAAB_Putni.GetDays()), int.Parse(uredi_DAAB_Putni.GetKilometri()), int.Parse(uredi_DAAB_Putni.GetSpeed()), int.Parse(uredi_DAAB_Putni.GetFuel())), putninalog.IDPutniNalog) > 0)
                    {
                        FillPutniNalozi();
                        this.Show();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else if (result == DialogResult.Cancel)
            {
            }
            else
            {
                this.Show();
                MessageBox.Show("Neušpjesno dodavanje", "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lbNalozi.SelectedItem is PutniNalog putni_Nalog)
            {
                if (MessageBox.Show("Zelite li stvarno izbrisati?", "Siguran??", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    try
                    {
                        if (DBHandler.DeletePutniNalog(putni_Nalog.IDPutniNalog) > 0)
                        {
                            FillPutniNalozi();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Main().Show();
        }
    }
}
