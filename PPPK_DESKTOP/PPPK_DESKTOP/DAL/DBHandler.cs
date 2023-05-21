using Microsoft.Practices.EnterpriseLibrary.Data.Sql;
using PPPK_DESKTOP.Model;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace PPPK_DESKTOP.DAL
{
    class DBHandler
    {
        private static string cs = ConfigurationManager.ConnectionStrings["cs"].ConnectionString;
        private static SqlDatabase db = new SqlDatabase(cs);

        internal static IEnumerable<PutniNalog> GetAllPutniNalogi()
        {
            using (IDataReader dr = db.ExecuteReader(CommandType.StoredProcedure, nameof(GetAllPutniNalogi)))
            {
                while (dr.Read())
                {
                    yield return new PutniNalog
                    {
                        IDPutniNalog = int.Parse(dr[nameof(PutniNalog.IDPutniNalog)].ToString()),
                        Brzina = int.Parse(dr[nameof(PutniNalog.Brzina)].ToString()),
                        ZavrsniGrad = dr[nameof(PutniNalog.ZavrsniGrad)].ToString(),
                        OcekivaniDani = int.Parse(dr[nameof(PutniNalog.OcekivaniDani)].ToString()),
                        Kilometri = int.Parse(dr[nameof(PutniNalog.Kilometri)].ToString()),
                        Tip = (Tip)Enum.Parse(typeof(Tip), dr[nameof(PutniNalog.Tip)].ToString(), true),
                        VozacID = int.Parse(dr[nameof(PutniNalog.VozacID)].ToString()),
                        PocetniGrad = dr[nameof(PutniNalog.PocetniGrad)].ToString(),
                        VoziloID = int.Parse(dr[nameof(PutniNalog.VoziloID)].ToString()),
                        Gorivo = int.Parse(dr[nameof(PutniNalog.Gorivo)].ToString())

                    };
                }
            }
        }
        internal static PutniNalog GetPuntniNalog(int idPutniNalog)
        {
            DataSet ds = db.ExecuteDataSet(MethodBase.GetCurrentMethod().Name, idPutniNalog);
            DataRow dr = ds?.Tables?[0]?.Rows?[0];
            return dr != null ? new PutniNalog
            {
                IDPutniNalog = int.Parse(dr[nameof(PutniNalog.IDPutniNalog)].ToString()),
                Brzina = int.Parse(dr[nameof(PutniNalog.Brzina)].ToString()),
                ZavrsniGrad = dr[nameof(PutniNalog.ZavrsniGrad)].ToString(),
                OcekivaniDani = int.Parse(dr[nameof(PutniNalog.OcekivaniDani)].ToString()),
                Kilometri = int.Parse(dr[nameof(PutniNalog.Kilometri)].ToString()),
                Tip = (Tip)Enum.Parse(typeof(Tip), dr[nameof(PutniNalog.Tip)].ToString(), true),
                VozacID = int.Parse(dr[nameof(PutniNalog.VozacID)].ToString()),
                PocetniGrad = dr[nameof(PutniNalog.PocetniGrad)].ToString(),
                VoziloID = int.Parse(dr[nameof(PutniNalog.VoziloID)].ToString()),
                Gorivo = int.Parse(dr[nameof(PutniNalog.Gorivo)].ToString())

            } : null;
        }

        internal static IEnumerable<Vozac> GetAllVozaci()
        {
            using (IDataReader dr = db.ExecuteReader(CommandType.StoredProcedure, nameof(GetAllVozaci)))
            {
                while (dr.Read())
                {
                    yield return new Vozac
                    {
                        IDVozac = int.Parse(dr[nameof(Vozac.IDVozac)].ToString()),
                        BrojVozackeDozvole = int.Parse(dr[nameof(Vozac.BrojVozackeDozvole)].ToString()),
                        Name = dr[nameof(Vozac.Name)].ToString(),
                        BrojMobitela = int.Parse(dr[nameof(Vozac.BrojMobitela)].ToString())
                    };
                }
            }
        }
        internal static IEnumerable<Vozilo> GetAllVozila()
        {
            using (IDataReader dr = db.ExecuteReader(CommandType.StoredProcedure, nameof(GetAllVozila)))
            {
                while (dr.Read())
                {
                    yield return new Vozilo
                    {
                        IDVozilo = int.Parse(dr[nameof(Vozilo.IDVozilo)].ToString()),
                        MarkaVozila = dr[nameof(Vozilo.MarkaVozila)].ToString(),
                        GodinaProizvodnje = int.Parse(dr[nameof(Vozilo.GodinaProizvodnje)].ToString()),
                        InicijalnoStanjeKilometara = int.Parse(dr[nameof(Vozilo.InicijalnoStanjeKilometara)].ToString()),
                        TipVozila = dr[nameof(Vozilo.TipVozila)].ToString()
                    };
                }
            }
        }
        internal static int AddPutniNalog(PutniNalog putniNalog) => db.ExecuteNonQuery(MethodBase.GetCurrentMethod().Name, putniNalog.VozacID, putniNalog.VoziloID, (int)putniNalog.Tip, putniNalog.PocetniGrad, putniNalog.ZavrsniGrad, putniNalog.OcekivaniDani, putniNalog.Kilometri, putniNalog.Brzina, putniNalog.Gorivo);
        internal static int UpdatePutniNalog(PutniNalog putniNalog, int idPutniNalog) => db.ExecuteNonQuery(MethodBase.GetCurrentMethod().Name, idPutniNalog, putniNalog.VozacID, putniNalog.VoziloID, (int)putniNalog.Tip, putniNalog.PocetniGrad, putniNalog.ZavrsniGrad, putniNalog.OcekivaniDani, putniNalog.Kilometri, putniNalog.Brzina, putniNalog.Gorivo);
        internal static int DeletePutniNalog(int putniNalog) => db.ExecuteNonQuery(MethodBase.GetCurrentMethod().Name, putniNalog);

        internal static int AddVozilo(Vozilo vozilo) => db.ExecuteNonQuery(MethodBase.GetCurrentMethod().Name, vozilo.TipVozila, vozilo.MarkaVozila, vozilo.GodinaProizvodnje, vozilo.InicijalnoStanjeKilometara);
        internal static int AddVozac(Vozac vozac) => db.ExecuteNonQuery(MethodBase.GetCurrentMethod().Name, vozac.Name, vozac.BrojMobitela, vozac.BrojVozackeDozvole);
    
    }
}
