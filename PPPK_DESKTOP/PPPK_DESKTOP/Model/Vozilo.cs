using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPPK_DESKTOP.Model
{
    class Vozilo
    {
        public Vozilo(string tipVozila, string markaVozila, int godinaProizvodnje, int inicijalnoStanjeKilometara)
        {
            TipVozila = tipVozila;
            MarkaVozila = markaVozila;
            GodinaProizvodnje = godinaProizvodnje;
            InicijalnoStanjeKilometara = inicijalnoStanjeKilometara;
        }

        public Vozilo(int iDVozilo, string tipVozila, string markaVozila, int godinaProizvodnje, int inicijalnoStanjeKilometara)
            : this(tipVozila, markaVozila, godinaProizvodnje, inicijalnoStanjeKilometara)
        {
            IDVozilo = iDVozilo;
        }

        public int IDVozilo { get; set; }
        public string TipVozila { get; set; }
        public string MarkaVozila { get; set; }
        public int GodinaProizvodnje { get; set; }
        public int InicijalnoStanjeKilometara { get; set; }

        public Vozilo()
        {

        }

        public override string ToString() => TipVozila + " " + MarkaVozila;
    }
}
