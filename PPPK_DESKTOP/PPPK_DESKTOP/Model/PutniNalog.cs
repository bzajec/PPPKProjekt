using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPPK_DESKTOP.Model
{
    class PutniNalog
    {
        public PutniNalog(int vozacID, int voziloID, Tip tip, string pocetniGrad, string zavrsniGrad, int ocekivaniDani, int kilometri, int brzina, int gorivo)
        {
            VozacID = vozacID;
            VoziloID = voziloID;
            Tip = tip;
            PocetniGrad = pocetniGrad;
            ZavrsniGrad = zavrsniGrad;
            OcekivaniDani = ocekivaniDani;
            Kilometri = kilometri;
            Brzina = brzina;
            Gorivo = gorivo;
        }

        public PutniNalog(int iDPutniNalog, int vozacID, int voziloID, Tip tip, string pocetniGrad, string zavrsniGrad, int ocekivaniDani, int kilometri, int brzina, int gorivo)
            : this(vozacID, voziloID, tip, pocetniGrad, zavrsniGrad, ocekivaniDani, kilometri, brzina, gorivo)
        {
            IDPutniNalog = iDPutniNalog;
        }

        public int IDPutniNalog { get; set; }
        public int VozacID { get; set; }
        public int VoziloID { get; set; }
        public Tip Tip { get; set; }
        public string PocetniGrad { get; set; }
        public string ZavrsniGrad { get; set; }
        public int OcekivaniDani { get; set; }
        public int Kilometri { get; set; }
        public int Brzina { get; set; }
        public int Gorivo { get; set; }

        public PutniNalog()
        {
        }

        public override string ToString() => " " + " " + VozacID + " " + " " + " " + " " + VoziloID + " " + " " + " " + " " + Tip + " " + " " + " " + " " + PocetniGrad + " " + " " + " " + " " + ZavrsniGrad + " " + " " + " " + " " + OcekivaniDani + " " + " " + " " + " " + Kilometri + " " + " " + " " + " " + Brzina + " " + " " + " " + " " + Gorivo;
    }
}
