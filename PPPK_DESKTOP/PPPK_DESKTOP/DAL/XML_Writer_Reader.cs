using PPPK_DESKTOP.Model;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace PPPK_DESKTOP.DAL
{
    class XML_Writer_Reader
    {
        private static string cs = ConfigurationManager.ConnectionStrings["cs"].ConnectionString;

        public const string VOZACI_PATH = @"xmlUPIS/vozaci.xml";
        public const string VOZILA_PATH = @"xmlUPIS/vozila.xml";
        public const string PUTNI_NALOZI_PATH = @"xmlUPIS/putniNalozi.xml";

        private const string SELECT_VOZACI = "select * from Vozac";
        private const string SELECT_VOZILA = "select * from Vozilo";
        private const string SELECT_PUTNI_NALOZI = "select * from PutniNalog";

        public const string VOZAC = "Vozac";
        public const string VOZILO = "Vozilo";
        public const string PUTNI_NALOG = "PutniNalog";

        private static List<Vozac> allVozaci;
        private static List<Vozilo> allVozila;
        private static List<PutniNalog> allPutniNalozi;

        public static void CreateXML()
        {
            CreatePutniNalozi();
            CreateVozila();
            CreateVozaci();

        }

        private static void CreatePutniNalozi()
        {
            using (XmlWriter xmlWriter = CreateWriter(PUTNI_NALOZI_PATH))
            {
                xmlWriter.WriteStartDocument();
                xmlWriter.WriteStartElement("PutniNalozi");

                DataTable dtPutniNalozi = GetDataTable(SELECT_PUTNI_NALOZI, PUTNI_NALOG);

                dtPutniNalozi.Rows.Cast<DataRow>()
                    .ToList()
                    .ForEach(dr =>
                    {
                        xmlWriter.WriteStartElement("PutniNalozi");
                        xmlWriter.WriteAttributeString("id", dr[nameof(PutniNalog.IDPutniNalog)].ToString());
                        xmlWriter.WriteElementString("tip", dr[nameof(PutniNalog.Tip)].ToString());
                        xmlWriter.WriteElementString("vozacID", dr[nameof(PutniNalog.VozacID)].ToString());
                        xmlWriter.WriteElementString("voziloID", dr[nameof(PutniNalog.VoziloID)].ToString());
                        xmlWriter.WriteElementString("pocetni_grad", dr[nameof(PutniNalog.PocetniGrad)].ToString());
                        xmlWriter.WriteElementString("zavrsni_grad", dr[nameof(PutniNalog.ZavrsniGrad)].ToString());
                        xmlWriter.WriteElementString("ocekivani_dani", dr[nameof(PutniNalog.OcekivaniDani)].ToString());
                        xmlWriter.WriteElementString("kilometri", dr[nameof(PutniNalog.Kilometri)].ToString());
                        xmlWriter.WriteElementString("brzina", dr[nameof(PutniNalog.Brzina)].ToString());
                        xmlWriter.WriteElementString("gorivo", dr[nameof(PutniNalog.Gorivo)].ToString());

                        xmlWriter.WriteEndElement();
                    });
                xmlWriter.WriteEndElement();
            }
        }

        private static void CreateVozila()
        {
            using (XmlWriter xmlWriter = CreateWriter(VOZILA_PATH))
            {
                xmlWriter.WriteStartDocument();
                xmlWriter.WriteStartElement("Vozila");

                DataTable dtVehicle = GetDataTable(SELECT_VOZILA, VOZILO);

                dtVehicle.Rows.Cast<DataRow>()
                    .ToList()
                    .ForEach(dr =>
                    {
                        xmlWriter.WriteStartElement("vozilo");
                        xmlWriter.WriteAttributeString("id", dr[nameof(Vozilo.IDVozilo)].ToString());
                        xmlWriter.WriteElementString("tip_vozila", dr[nameof(Vozilo.TipVozila)].ToString());
                        xmlWriter.WriteElementString("marka_vozila", dr[nameof(Vozilo.MarkaVozila)].ToString());
                        xmlWriter.WriteElementString("godina_proizvodnje", dr[nameof(Vozilo.GodinaProizvodnje)].ToString());
                        xmlWriter.WriteElementString("inicijalno_stanje_kilometara", dr[nameof(Vozilo.InicijalnoStanjeKilometara)].ToString());
                        xmlWriter.WriteEndElement();
                    });
                xmlWriter.WriteEndElement();
            }
        }

        private static void CreateVozaci()
        {
            using (XmlWriter xmlWriter = CreateWriter(VOZACI_PATH))
            {
                xmlWriter.WriteStartDocument();
                xmlWriter.WriteStartElement("Vozac");

                DataTable dtPerson = GetDataTable(SELECT_VOZACI, VOZAC);

                dtPerson.Rows.Cast<DataRow>()
                    .ToList()
                    .ForEach(dr =>
                    {
                        xmlWriter.WriteStartElement("vozac");
                        xmlWriter.WriteAttributeString("id", dr[nameof(Vozac.IDVozac)].ToString());
                        xmlWriter.WriteElementString("ime_prezime", dr[nameof(Vozac.Name)].ToString());
                        xmlWriter.WriteElementString("broj_mobitela", dr[nameof(Vozac.BrojMobitela)].ToString());
                        xmlWriter.WriteElementString("broj_vozacke_dozvole", dr[nameof(Vozac.BrojVozackeDozvole)].ToString());
                        xmlWriter.WriteEndElement();
                    });
                xmlWriter.WriteEndElement();
            }
        }

        private static XmlWriter CreateWriter(string path)
        {
            XmlWriterSettings settings = new XmlWriterSettings
            {
                Indent = true
            };
            return XmlWriter.Create(path, settings);
        }

        private static DataTable GetDataTable(string command, string table)
        {
            using (SqlConnection con = new SqlConnection(cs))
            {
                SqlDataAdapter da = new SqlDataAdapter(command, con);
                DataTable dataTable = new DataTable(table);
                da.Fill(dataTable);
                return dataTable;
            }
        }

        public static void Restore()
        {
            allPutniNalozi = GetPutniNalozi();
            allVozila = GetVozila();
            allVozaci = GetVozaci();

            allVozaci.ForEach(vozac => DBHandler.AddVozac(vozac));
            allVozila.ForEach(vozilo => DBHandler.AddVozilo(vozilo));
            allPutniNalozi.ForEach(putninalog => DBHandler.AddPutniNalog(putninalog));
        }

        private static List<PutniNalog> GetPutniNalozi()
        {
            List<PutniNalog> putni_Nalogs = new List<PutniNalog>();

            XmlDocument xmlDocument = LoadDocument(PUTNI_NALOZI_PATH);
            XmlElement root = xmlDocument.DocumentElement;
            XmlNodeList contactNodes = root.SelectNodes("PutniNalozi");

            contactNodes.Cast<XmlNode>()
                .ToList()
                .ForEach(cn =>
                {
                    int id = int.Parse(cn.Attributes[0].Value);
                    string tip = cn.SelectSingleNode("tip").InnerText;
                    string vozacID = cn.SelectSingleNode("vozacID").InnerText;
                    string voziloID = cn.SelectSingleNode("voziloID").InnerText;
                    string pocetniGrad = cn.SelectSingleNode("pocetni_grad").InnerText;
                    string zavrsniGrad = cn.SelectSingleNode("zavrsni_grad").InnerText;
                    string ocekivaniDani = cn.SelectSingleNode("ocekivani_dani").InnerText;
                    string kilometri = cn.SelectSingleNode("kilometri").InnerText;
                    string brzina = cn.SelectSingleNode("brzina").InnerText;
                    string gorivo = cn.SelectSingleNode("gorivo").InnerText;

                    putni_Nalogs.Add(new PutniNalog(id, int.Parse(vozacID), int.Parse(voziloID), (Tip)Enum.Parse(typeof(Tip), tip, true), pocetniGrad, zavrsniGrad, int.Parse(ocekivaniDani), int.Parse(kilometri), int.Parse(brzina), int.Parse(gorivo)));
                });

            return putni_Nalogs;
        }

        private static List<Vozilo> GetVozila()
        {
            List<Vozilo> vozilos = new List<Vozilo>();

            XmlDocument xmlDocument = LoadDocument(VOZILA_PATH);
            XmlElement root = xmlDocument.DocumentElement;
            XmlNodeList contactNodes = root.SelectNodes("vozilo");

            contactNodes.Cast<XmlNode>()
                .ToList()
                .ForEach(cn =>
                {
                    int id = int.Parse(cn.Attributes[0].Value);
                    string tipVozila = cn.SelectSingleNode("tip_vozila").InnerText;
                    string markaVozila = cn.SelectSingleNode("marka_vozila").InnerText;
                    string godinaProizvodnje = cn.SelectSingleNode("godina_proizvodnje").InnerText;
                    string inicijalno_Stanje_Kilometara = cn.SelectSingleNode("inicijalno_stanje_kilometara").InnerText;

                    vozilos.Add(new Vozilo(id, tipVozila, markaVozila, int.Parse(godinaProizvodnje), int.Parse(inicijalno_Stanje_Kilometara)));
                });

            return vozilos;
        }

        private static List<Vozac> GetVozaci()
        {
            List<Vozac> vozacs = new List<Vozac>();

            XmlDocument xmlDocument = LoadDocument(VOZACI_PATH);
            XmlElement root = xmlDocument.DocumentElement;
            XmlNodeList contactNodes = root.SelectNodes("vozac");

            contactNodes.Cast<XmlNode>()
                .ToList()
                .ForEach(cn =>
                {
                    int id = int.Parse(cn.Attributes[0].Value);
                    string name = cn.SelectSingleNode("ime_prezime").InnerText;
                    string brojMobitela = cn.SelectSingleNode("broj_mobitela").InnerText;
                    string brojVozackeDozvole = cn.SelectSingleNode("broj_vozacke_dozvole").InnerText;

                    vozacs.Add(new Vozac(id, name, int.Parse(brojMobitela), int.Parse(brojVozackeDozvole)));
                });

            return vozacs;
        }

        private static XmlDocument LoadDocument(string path)
        {
            XmlDocument xmlDocument = new XmlDocument();
            xmlDocument.Load(path);
            return xmlDocument;
        }

    }
}
