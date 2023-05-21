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
    public partial class XML : Form
    {
        private List<PutniNalog> putniNalogs;
        public XML()
        {
            InitializeComponent();
        }

        private void XML_Load(object sender, EventArgs e)
        {
            Init();
        }

        private void Init()
        {
            putniNalogs = Import();
            lbNalozi.DataSource = putniNalogs;
        }

        private List<PutniNalog> Import()
        {
            List<PutniNalog> putni_Nalogs = new List<PutniNalog>();
            DataSet ds = new DataSet();
            ds.ReadXml(Main.XML_PATH);

            ds.Tables[0].Rows.Cast<DataRow>()
                .ToList()
                .ForEach(putniNalogRow =>
                {
                    int iDTravelOrder = int.Parse(putniNalogRow[nameof(PutniNalog.IDPutniNalog)].ToString());
                    string pocetniGrad = putniNalogRow[nameof(PutniNalog.PocetniGrad)].ToString();
                    string zavrsniGrad = putniNalogRow[nameof(PutniNalog.ZavrsniGrad)].ToString();
                    int ocekivaniDani = int.Parse(putniNalogRow[nameof(PutniNalog.OcekivaniDani)].ToString());
                    int kilometri = int.Parse(putniNalogRow[nameof(PutniNalog.Kilometri)].ToString());
                    int brzina = int.Parse(putniNalogRow[nameof(PutniNalog.Brzina)].ToString());
                    int gorivo = int.Parse(putniNalogRow[nameof(PutniNalog.Gorivo)].ToString());
                    Tip tip = (Tip)Enum.Parse(typeof(Tip), putniNalogRow[nameof(PutniNalog.Tip)].ToString(), true);
                    int vozacID = int.Parse(putniNalogRow[nameof(PutniNalog.VozacID)].ToString());
                    int voziloID = int.Parse(putniNalogRow[nameof(PutniNalog.VoziloID)].ToString());

                    putni_Nalogs.Add(new PutniNalog(vozacID, voziloID, tip, pocetniGrad, zavrsniGrad, ocekivaniDani, kilometri, brzina, gorivo));
                });
            return putni_Nalogs;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Main().Show();
        }
    }
}
