using PPPK_DESKTOP.Model;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace PPPK_DESKTOP.DAL
{
    class SqlHandler
    {
        private const string ID_VOZAC = "@idVozac";
        private const string NAME = "@name";
        private const string BROJ_MOBITELA = "@BrojMobitela";
        private const string BROJ_VOZACKE_DOZVOLE = "@BrojVozackeDozvole";

        private const string ID_VOZILO = "@idVozilo";
        private const string TIP_VOZILA = "@TipVozila";
        private const string MARKA_VOZILA = "@MarkaVozila";
        private const string GODINA_PROIZVODNJE = "@GodinaProizvodnje";
        private const string INICJALNO_STANJE_KILOMETARA = "@InicijalnoStanjeKilometara";

        private const string ID_PUTNI_NALOG = "@idPutniNalog";
        private const string VOZAC_ID = "@VozacID";
        private const string VOZILO_ID = "@VoziloID";
        private const string TIP = "@Tip";
        private const string POCETNI_GRAD = "@PocetniGrad";
        private const string ZAVRSNI_GRAD = "@ZavrsniGrad";
        private const string OCEKIVANI_DANI = "@OcekivaniDani";
        private const string KILOMETRI = "@Kilometri";
        private const string BRZINA = "@Brzina";
        private const string GORIVO = "@Gorivo";

        private static readonly string cs = ConfigurationManager.ConnectionStrings["cs"].ConnectionString;

        //Vozac

        internal static List<Vozac> GetAllVozaci()
        {
            List<Vozac> vozac = new List<Vozac>();
            using (SqlConnection con = new SqlConnection(cs))
            {
                con.Open();
                con.InfoMessage += Con_InfoMessage;
                using (SqlCommand cmd = con.CreateCommand())
                {
                    cmd.CommandText = nameof(GetAllVozaci);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            vozac.Add(new Vozac
                            (
                                (int)dr[nameof(Vozac.IDVozac)],
                                dr[nameof(Vozac.Name)].ToString(),
                                (int)dr[nameof(Vozac.BrojMobitela)],
                                (int)dr[nameof(Vozac.BrojVozackeDozvole)]
                            )
                            );
                        }
                    }
                }
            }
            return vozac;
        }

        private static void Con_InfoMessage(object sender, SqlInfoMessageEventArgs e)
        {
            throw new NotImplementedException();
        }

        internal static int AddVozac(string name, int brojMobitela, int brojVozackeDozvole)
        {
            using (SqlConnection con = new SqlConnection(cs))
            {
                con.Open();
                using (SqlCommand cmd = con.CreateCommand())
                {
                    cmd.CommandText = nameof(AddVozac);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue(NAME, name);
                    cmd.Parameters.AddWithValue(BROJ_MOBITELA, brojMobitela);
                    cmd.Parameters.AddWithValue(BROJ_VOZACKE_DOZVOLE, brojVozackeDozvole);

                    return cmd.ExecuteNonQuery();
                }
            }
        }

        internal static Vozac GetVozac(int idVozac)
        {
            Vozac vozac = null;
            using (SqlConnection con = new SqlConnection(cs))
            {
                con.Open();
                using (SqlCommand cmd = con.CreateCommand())
                {
                    cmd.CommandText = nameof(GetVozac);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue(ID_VOZAC, idVozac);
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            vozac = new Vozac
                            (
                                dr[nameof(Vozac.Name)].ToString(),
                                (int)dr[nameof(Vozac.BrojMobitela)],
                                (int)dr[nameof(Vozac.BrojVozackeDozvole)]
                            );

                        }
                    }
                }
            }

            return vozac;
        }

        internal static int DeleteVozac(int idVozac)
        {
            using (TransactionScope scope = new TransactionScope())
            {
                using (SqlConnection con = new SqlConnection(cs))
                {
                    con.Open();
                    using (SqlCommand cmd = con.CreateCommand())
                    {
                        cmd.CommandText = nameof(DeleteVozac);
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue(ID_VOZAC, idVozac);
                        int result = cmd.ExecuteNonQuery();
                        scope.Complete();
                        return result;
                    }
                }

            }
        }

        internal static int UpdateVozac(int idVozac, string name, int brojMobitela, int brojVozackeDozvole)
        {
            using (SqlConnection con = new SqlConnection(cs))
            {
                con.Open();
                using (SqlCommand cmd = con.CreateCommand())
                {
                    cmd.CommandText = nameof(UpdateVozac);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue(ID_VOZAC, idVozac);
                    cmd.Parameters.AddWithValue(NAME, name);
                    cmd.Parameters.AddWithValue(BROJ_MOBITELA, brojMobitela);
                    cmd.Parameters.AddWithValue(BROJ_VOZACKE_DOZVOLE, brojVozackeDozvole);

                    return cmd.ExecuteNonQuery();
                }
            }
        }

        //Vozilo

        internal static List<Vozilo> GetAllVozila()
        {
            List<Vozilo> vozilo = new List<Vozilo>();
            using (SqlConnection con = new SqlConnection(cs))
            {
                con.Open();
                using (SqlCommand cmd = con.CreateCommand())
                {
                    cmd.CommandText = nameof(GetAllVozila);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            vozilo.Add(new Vozilo
                            (
                                (int)dr[nameof(Vozilo.IDVozilo)],
                                dr[nameof(Vozilo.TipVozila)].ToString(),
                                dr[nameof(Vozilo.MarkaVozila)].ToString(),
                                (int)dr[nameof(Vozilo.GodinaProizvodnje)],
                                (int)dr[nameof(Vozilo.InicijalnoStanjeKilometara)]
                            )
                            );
                        }
                    }
                }
            }
            return vozilo;
        }

        internal static int AddVozilo(string tipVozila, string markaVozila, int godinaProizvodnje, int inicijalnoStanjeKilometara)
        {
            using (SqlConnection con = new SqlConnection(cs))
            {
                con.Open();
                using (SqlCommand cmd = con.CreateCommand())
                {
                    cmd.CommandText = nameof(AddVozilo);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue(TIP_VOZILA, tipVozila);
                    cmd.Parameters.AddWithValue(MARKA_VOZILA, markaVozila);
                    cmd.Parameters.AddWithValue(GODINA_PROIZVODNJE, godinaProizvodnje);
                    cmd.Parameters.AddWithValue(INICJALNO_STANJE_KILOMETARA, inicijalnoStanjeKilometara);

                    return cmd.ExecuteNonQuery();
                }
            }
        }

        internal static Vozilo GetVozilo(int idVozilo)
        {
            Vozilo vozilo = null;
            using (SqlConnection con = new SqlConnection(cs))
            {
                con.Open();
                using (SqlCommand cmd = con.CreateCommand())
                {
                    cmd.CommandText = nameof(GetVozilo);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue(ID_VOZILO, idVozilo);
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            vozilo = new Vozilo
                            (
                                dr[nameof(Vozilo.TipVozila)].ToString(),
                                dr[nameof(Vozilo.MarkaVozila)].ToString(),
                                (int)dr[nameof(Vozilo.GodinaProizvodnje)],
                                (int)dr[nameof(Vozilo.InicijalnoStanjeKilometara)]
                            );

                        }
                    }
                }
            }
            return vozilo;
        }

        internal static int UpdateVozilo(int idVozilo, string tipVozila, string markaVozila, int godinaProizvodnje, int inicijalnoStanjeKilometara)
        {
            using (SqlConnection con = new SqlConnection(cs))
            {
                con.Open();
                using (SqlCommand cmd = con.CreateCommand())
                {
                    cmd.CommandText = nameof(UpdateVozilo);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue(ID_VOZILO, idVozilo);
                    cmd.Parameters.AddWithValue(TIP_VOZILA, tipVozila);
                    cmd.Parameters.AddWithValue(MARKA_VOZILA, markaVozila);
                    cmd.Parameters.AddWithValue(GODINA_PROIZVODNJE, godinaProizvodnje);
                    cmd.Parameters.AddWithValue(INICJALNO_STANJE_KILOMETARA, inicijalnoStanjeKilometara);

                    return cmd.ExecuteNonQuery();
                }
            }
        }

        internal static int DeleteVozilo(int idVozilo)
        {
            using (TransactionScope scope = new TransactionScope())
            {
                using (SqlConnection con = new SqlConnection(cs))
                {
                    con.Open();
                    using (SqlCommand cmd = con.CreateCommand())
                    {
                        cmd.CommandText = nameof(DeleteVozilo);
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue(ID_VOZILO, idVozilo);
                        int result = cmd.ExecuteNonQuery();
                        scope.Complete();
                        return result;
                    }
                }

            }
        }

        //Nalogi

        internal static List<PutniNalog> GetAllPutniNalogi()
        {
            List<PutniNalog> putni_nalog = new List<PutniNalog>();
            using (SqlConnection con = new SqlConnection(cs))
            {
                con.Open();
                using (SqlCommand cmd = con.CreateCommand())
                {
                    cmd.CommandText = nameof(GetAllPutniNalogi);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            putni_nalog.Add(new PutniNalog
                            (
                                (int)dr[nameof(PutniNalog.IDPutniNalog)],
                                (int)dr[nameof(PutniNalog.VozacID)],
                                (int)dr[nameof(PutniNalog.VoziloID)],
                                (Tip)Enum.Parse(typeof(Tip), dr[nameof(PutniNalog.Tip)].ToString(), true),
                                dr[nameof(PutniNalog.PocetniGrad)].ToString(),
                                dr[nameof(PutniNalog.ZavrsniGrad)].ToString(),
                                (int)dr[nameof(PutniNalog.OcekivaniDani)],
                                (int)dr[nameof(PutniNalog.Kilometri)],
                                (int)dr[nameof(PutniNalog.Brzina)],
                                (int)dr[nameof(PutniNalog.Gorivo)]
                            )
                            );
                        }
                    }
                }
            }
            return putni_nalog;
        }

        internal static int AddPutniNalog(Tip tip, int vozacID, int voziloID, string pocetniGrad, string zavrsniGrad, int ocekivaniDani, int kilometri, int brzina, int gorivo)
        {
            using (SqlConnection con = new SqlConnection(cs))
            {
                con.Open();
                using (SqlCommand cmd = con.CreateCommand())
                {
                    cmd.CommandText = nameof(AddPutniNalog);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue(TIP, tip);
                    cmd.Parameters.AddWithValue(VOZAC_ID, vozacID);
                    cmd.Parameters.AddWithValue(VOZILO_ID, voziloID);
                    cmd.Parameters.AddWithValue(POCETNI_GRAD, pocetniGrad);
                    cmd.Parameters.AddWithValue(ZAVRSNI_GRAD, zavrsniGrad);
                    cmd.Parameters.AddWithValue(OCEKIVANI_DANI, ocekivaniDani);
                    cmd.Parameters.AddWithValue(KILOMETRI, kilometri);
                    cmd.Parameters.AddWithValue(BRZINA, brzina);
                    cmd.Parameters.AddWithValue(GORIVO, gorivo);

                    return cmd.ExecuteNonQuery();
                }
            }
        }

        internal static int UpdatePutniNalog(int iDPutniNalog, int vozacID, int voziloID, Tip tip, string pocetniGrad, string zavrsniGrad, int ocekivaniDani, int kilometri, int brzina, int gorivo)
        {
            using (SqlConnection con = new SqlConnection(cs))
            {
                con.Open();
                using (SqlCommand cmd = con.CreateCommand())
                {
                    cmd.CommandText = nameof(UpdatePutniNalog);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue(ID_PUTNI_NALOG, iDPutniNalog);
                    cmd.Parameters.AddWithValue(VOZAC_ID, vozacID);
                    cmd.Parameters.AddWithValue(VOZILO_ID, voziloID);
                    cmd.Parameters.AddWithValue(TIP, tip);
                    cmd.Parameters.AddWithValue(POCETNI_GRAD, pocetniGrad);
                    cmd.Parameters.AddWithValue(ZAVRSNI_GRAD, zavrsniGrad);
                    cmd.Parameters.AddWithValue(OCEKIVANI_DANI, ocekivaniDani);
                    cmd.Parameters.AddWithValue(KILOMETRI, kilometri);
                    cmd.Parameters.AddWithValue(BRZINA, brzina);
                    cmd.Parameters.AddWithValue(GORIVO, gorivo);

                    return cmd.ExecuteNonQuery();
                }
            }
        }

        internal static PutniNalog GetPutniNalog(int idPutniNalog)
        {
            PutniNalog putni_nalog = null;
            using (SqlConnection con = new SqlConnection(cs))
            {
                con.Open();
                using (SqlCommand cmd = con.CreateCommand())
                {
                    cmd.CommandText = nameof(GetPutniNalog);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue(ID_PUTNI_NALOG, idPutniNalog);
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            putni_nalog = new PutniNalog
                            (
                                (int)dr[nameof(PutniNalog.VozacID)],
                                (int)dr[nameof(PutniNalog.VoziloID)],
                                (Tip)Enum.Parse(typeof(Tip), dr[nameof(PutniNalog.Tip)].ToString(), true),
                                dr[nameof(PutniNalog.PocetniGrad)].ToString(),
                                dr[nameof(PutniNalog.ZavrsniGrad)].ToString(),
                                (int)dr[nameof(PutniNalog.OcekivaniDani)],
                                (int)dr[nameof(PutniNalog.Kilometri)],
                                (int)dr[nameof(PutniNalog.Brzina)],
                                (int)dr[nameof(PutniNalog.Gorivo)]
                            );

                        }
                    }
                }
            }

            return putni_nalog;
        }

        internal static int DeletePutniNalog(int idPutniNalog)
        {
            using (TransactionScope scope = new TransactionScope())
            {
                using (SqlConnection con = new SqlConnection(cs))
                {
                    con.Open();
                    using (SqlCommand cmd = con.CreateCommand())
                    {
                        cmd.CommandText = nameof(DeletePutniNalog);
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue(ID_PUTNI_NALOG, idPutniNalog);
                        int result = cmd.ExecuteNonQuery();
                        scope.Complete();
                        return result;
                    }
                }

            }
        }

        internal static void VratiBazuNaTvornicke()
        {
            using (TransactionScope scope = new TransactionScope())
            {
                using (SqlConnection con = new SqlConnection(cs))
                {
                    con.Open();
                    using (SqlCommand cmd = con.CreateCommand())
                    {
                        cmd.CommandText = nameof(VratiBazuNaTvornicke);
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        cmd.ExecuteNonQuery();
                        scope.Complete();
                    }
                }

            }
        }
    }
}
