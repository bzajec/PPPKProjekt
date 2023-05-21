using PPPK_DESKTOP.DAL;
using PPPK_DESKTOP.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PPPK_DESKTOP.Forms
{
    public partial class Main : Form
    {

        private static string cs = ConfigurationManager.ConnectionStrings["cs"].ConnectionString;
        private const string SELECT_ALL = "SelectAll";
        public const string XML_PATH = "Projekt.xml";

        public Main()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddVehicle dodajVozilo = new AddVehicle();
            DialogResult result = dodajVozilo.ShowDialog();
            if (result == DialogResult.OK
                && !string.IsNullOrEmpty(dodajVozilo.GetTypeOfVehicle())
                && !string.IsNullOrEmpty(dodajVozilo.GetMarkaVehicle())
                && !string.IsNullOrEmpty(dodajVozilo.GetYearOfProduction())
                && !string.IsNullOrEmpty(dodajVozilo.GetInicijalniBrojKilometara()))
            {
                try
                {
                    if (SqlHandler.AddVozilo(dodajVozilo.GetTypeOfVehicle(), dodajVozilo.GetMarkaVehicle(), int.Parse(dodajVozilo.GetYearOfProduction()), int.Parse(dodajVozilo.GetInicijalniBrojKilometara())) > 0)
                    {
                        FillVehicles();
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
            if (lbVozila.SelectedIndex < 0)
            {
                return;
            }
            this.Hide();
            EditVehicle urediVozilo = new EditVehicle();
            var vozilo = lbVozila.SelectedItem as Vozilo;
            urediVozilo.SetTypeOfVehicle(vozilo.TipVozila);
            urediVozilo.SetMarkaVehicle(vozilo.MarkaVozila);
            urediVozilo.SetYearOfProduction(vozilo.GodinaProizvodnje);
            urediVozilo.SetKilometri(vozilo.InicijalnoStanjeKilometara);
            DialogResult result = urediVozilo.ShowDialog();
            if (result == DialogResult.OK
                && !string.IsNullOrEmpty(urediVozilo.GetTypeOfVehicle())
                && !string.IsNullOrEmpty(urediVozilo.GetMarkaVehicle())
                && !string.IsNullOrEmpty(urediVozilo.GetYearOfProduction())
                && !string.IsNullOrEmpty(urediVozilo.GetKilometri()))
            {
                try
                {
                    if (SqlHandler.UpdateVozilo(vozilo.IDVozilo, urediVozilo.GetTypeOfVehicle(), urediVozilo.GetMarkaVehicle(), int.Parse(urediVozilo.GetYearOfProduction()), int.Parse(urediVozilo.GetKilometri())) > 0)
                    {
                        FillVehicles();
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
            if (lbVozila.SelectedItem is Vozilo vozilo)
            {
                if (MessageBox.Show("Zelite li stvarno izbrisati?", "Are you sure?", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    try
                    {
                        if (SqlHandler.DeleteVozilo(vozilo.IDVozilo) > 0)
                        {
                            FillVehicles();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                lblTipVozila.Text = " ";
                lblMarkVozila.Text = " ";
                lblGodinaProizvodnje.Text = " ";
                lblInicijalniKilometri.Text = " ";
            }
        }


        private void Main_Load(object sender, EventArgs e)
        {
            FillDrivers();
            FillVehicles();
            FillPutniNalozi();
            cbNalozi.DataSource = Enum.GetValues(typeof(Tip));
        }

        

        

        private void FillVehicles()
        {
            try
            {
                lbVozila.DataSource = SqlHandler.GetAllVozila();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void FillDrivers()
        {
            try
            {
                lbVozaci.DataSource = SqlHandler.GetAllVozaci();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void FillPutniNalozi()
        {
            try
            {
                lbNalozi.DataSource = SqlHandler.GetAllPutniNalogi();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAddDriver_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddDriver dodajVozac = new AddDriver();
            DialogResult result = dodajVozac.ShowDialog();
            if (result == DialogResult.OK
                && !string.IsNullOrEmpty(dodajVozac.GetName())
                && !string.IsNullOrEmpty(dodajVozac.GetMobileNumber())
                && !string.IsNullOrEmpty(dodajVozac.GetDriversLicence()))
            {
                try
                {
                    if (SqlHandler.AddVozac(dodajVozac.GetName(), int.Parse(dodajVozac.GetMobileNumber()), int.Parse(dodajVozac.GetDriversLicence())) > 0)
                    {
                        FillDrivers();
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
                MessageBox.Show("Neušpjesno dodavanje", "Error!!", MessageBoxButtons.OK);
            }
        }

        private void btnEditDriver_Click(object sender, EventArgs e)
        {
            if (lbVozaci.SelectedIndex < 0)
            {
                return;
            }
            this.Hide();
            EditDriver urediVozac = new EditDriver();
            var vozac = lbVozaci.SelectedItem as Vozac;
            urediVozac.SetName(vozac.Name);
            urediVozac.SetMobileNumber(vozac.BrojMobitela);
            urediVozac.SetDriversLicence(vozac.BrojVozackeDozvole);
            DialogResult result = urediVozac.ShowDialog();
            if (result == DialogResult.OK
                && !string.IsNullOrEmpty(urediVozac.GetName())
                && !string.IsNullOrEmpty(urediVozac.GetMobileNumber())
                && !string.IsNullOrEmpty(urediVozac.GetDriversLicence()))
            {
                try
                {
                    if (SqlHandler.UpdateVozac(vozac.IDVozac, urediVozac.GetName(), int.Parse(urediVozac.GetMobileNumber()), int.Parse(urediVozac.GetDriversLicence())) > 0)
                    {
                        FillDrivers();
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

        private void btnDeleteDriver_Click(object sender, EventArgs e)
        {
            if (lbVozaci.SelectedItem is Vozac vozac)
            {
                if (MessageBox.Show("Zelite li stvarno izbrisati?", "Are you sure?", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    try
                    {
                        if (SqlHandler.DeleteVozac(vozac.IDVozac) > 0)
                        {
                            FillDrivers();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                lblName.Text = " ";
                lblPhone.Text = " ";
                lblVozacka.Text = " ";
            }
        }

        private void btnAddNalog_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddNalog dodajPutniNalog = new AddNalog();
            DialogResult result = dodajPutniNalog.ShowDialog();
            if (result == DialogResult.OK
                && !string.IsNullOrEmpty(dodajPutniNalog.GetTypeNalog().ToString())
                && !string.IsNullOrEmpty(dodajPutniNalog.GetDriver().ToString())
                && !string.IsNullOrEmpty(dodajPutniNalog.GetVehicle().ToString())
                && !string.IsNullOrEmpty(dodajPutniNalog.GetStartCity())
                && !string.IsNullOrEmpty(dodajPutniNalog.GetEndCity())
                && !string.IsNullOrEmpty(dodajPutniNalog.GetDays())
                && !string.IsNullOrEmpty(dodajPutniNalog.GetKilometri())
                && !string.IsNullOrEmpty(dodajPutniNalog.GetSpeed())
                && !string.IsNullOrEmpty(dodajPutniNalog.GetFuel())
                )
            {
                try
                {
                    if (SqlHandler.AddPutniNalog(dodajPutniNalog.GetTypeNalog(), dodajPutniNalog.GetDriver(), dodajPutniNalog.GetVehicle(), dodajPutniNalog.GetStartCity(), dodajPutniNalog.GetEndCity(), int.Parse(dodajPutniNalog.GetDays()), int.Parse(dodajPutniNalog.GetKilometri()), int.Parse(dodajPutniNalog.GetSpeed()), int.Parse(dodajPutniNalog.GetFuel())) > 0)
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

        private void btnEditNalog_Click(object sender, EventArgs e)
        {
            if (lbNalozi.SelectedIndex < 0)
            {
                return;
            }
            this.Hide();
            EditNalog urediPutniNalog = new EditNalog();
            var putninalog = lbNalozi.SelectedItem as PutniNalog;
            urediPutniNalog.SetDriver(putninalog.VozacID);
            urediPutniNalog.SetVehicle(putninalog.VoziloID);
            urediPutniNalog.SetNalogType(putninalog.Tip);
            urediPutniNalog.SetStartCity(putninalog.PocetniGrad);
            urediPutniNalog.SetEndCity(putninalog.ZavrsniGrad);
            urediPutniNalog.SetDays(putninalog.OcekivaniDani);
            urediPutniNalog.SetKilometri(putninalog.Kilometri);
            urediPutniNalog.SetSpeed(putninalog.Brzina);
            urediPutniNalog.SetFuel(putninalog.Gorivo);
            DialogResult result = urediPutniNalog.ShowDialog();
            if (result == DialogResult.OK
                && !string.IsNullOrEmpty(urediPutniNalog.GetDriver().ToString())
                && !string.IsNullOrEmpty(urediPutniNalog.GetVehicle().ToString())
                && !string.IsNullOrEmpty(urediPutniNalog.GetNalogType().ToString())
                && !string.IsNullOrEmpty(urediPutniNalog.GetStartCity())
                && !string.IsNullOrEmpty(urediPutniNalog.GetEndCity())
                && !string.IsNullOrEmpty(urediPutniNalog.GetDays().ToString())
                && !string.IsNullOrEmpty(urediPutniNalog.GetKilometri().ToString())
                && !string.IsNullOrEmpty(urediPutniNalog.GetSpeed().ToString())
                && !string.IsNullOrEmpty(urediPutniNalog.GetFuel().ToString()))
            {
                try
                {
                    if (SqlHandler.UpdatePutniNalog(putninalog.IDPutniNalog, urediPutniNalog.GetDriver(), urediPutniNalog.GetVehicle(), urediPutniNalog.GetNalogType(), urediPutniNalog.GetStartCity(), urediPutniNalog.GetEndCity(), int.Parse(urediPutniNalog.GetDays()), int.Parse(urediPutniNalog.GetKilometri()), int.Parse(urediPutniNalog.GetSpeed()), int.Parse(urediPutniNalog.GetFuel())) > 0)
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

        private void btnDeleteNalog_Click(object sender, EventArgs e)
        {
            if (lbNalozi.SelectedItem is PutniNalog putni_Nalog)
            {
                if (MessageBox.Show("Zelite li stvarno izbrisati?", "Are you sure?", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    try
                    {
                        if (SqlHandler.DeletePutniNalog(putni_Nalog.IDPutniNalog) > 0)
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

        private void lbVozila_SelectedIndexChanged(object sender, EventArgs e)
        {
            var index = lbVozila.SelectedItem as Vozilo;
            lblTipVozila.Text = index.TipVozila.ToString();
            lblMarkVozila.Text = index.MarkaVozila.ToString();
            lblGodinaProizvodnje.Text = index.GodinaProizvodnje.ToString();
            lblInicijalniKilometri.Text = index.InicijalnoStanjeKilometara.ToString();
        }

        private void lbVozaci_SelectedIndexChanged(object sender, EventArgs e)
        {
            var index = lbVozaci.SelectedItem as Vozac;
            lblName.Text = index.Name.ToString();
            lblPhone.Text = index.BrojMobitela.ToString();
            lblVozacka.Text = index.BrojVozackeDozvole.ToString();
        }

        private void lbNalozi_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<PutniNalog> putni_Nalogs = SqlHandler.GetAllPutniNalogi();

            putni_Nalogs.ToList().ForEach(nalog =>
            {
                if (nalog.Tip != (Tip)cbNalozi.SelectedValue)
                {
                    putni_Nalogs.Remove(nalog);
                }
            });

            lbNalozi.DataSource = putni_Nalogs;

            
            
        }

        private void btnCreateXML_Click(object sender, EventArgs e)
        {
            CreateXml();
        }

        private void CreateXml()
        {
            DataSet ds = CreateDataSet();
            ds.WriteXml(XML_PATH, XmlWriteMode.WriteSchema);
        }

        private DataSet CreateDataSet()
        {
            using (SqlConnection con = new SqlConnection(cs))
            {
                SqlDataAdapter da = new SqlDataAdapter(SELECT_ALL, con);
                DataSet ds = new DataSet("PutniNalozi");
                da.Fill(ds);
                ds.Tables[0].TableName = nameof(PutniNalog);
                return ds;
            }
        }

        private void btnViewXML_Click(object sender, EventArgs e)
        {
            this.Hide();
            new XML().Show();
        }

        private void btnBackup_Click(object sender, EventArgs e)
        {
            XML_Writer_Reader.CreateXML();
        }

        private void btnRestore_Click(object sender, EventArgs e)
        {
            XML_Writer_Reader.Restore();
        }

        private void btnDAAB_Click(object sender, EventArgs e)
        {
            this.Hide();
            new DAAB().Show();
        }

        private void btnDeleteAll_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Jeste li sigurni da želite sve pobrisati?", "Are you sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                SqlHandler.VratiBazuNaTvornicke();
                FillDrivers();
                FillVehicles();
                lblName.Text = string.Empty;
                lblPhone.Text = string.Empty;
                lblVozacka.Text = string.Empty;
            }
            else
            {
                return;
            }
            lblName.Text = " ";
            lblPhone.Text = " ";
            lblVozacka.Text = " ";
            lblTipVozila.Text = " ";
            lblMarkVozila.Text = " ";
            lblGodinaProizvodnje.Text = " ";
            lblInicijalniKilometri.Text = " ";
        }
    }
}
