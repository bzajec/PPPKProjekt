using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPPK_DESKTOP.Model
{
    class Vozac
    {
        public Vozac(string name, int brojMobitela, int brojVozackeDozvole)
        {
            Name = name;
            BrojMobitela = brojMobitela;
            BrojVozackeDozvole = brojVozackeDozvole;
        }

        public Vozac(int iDVozac, string name, int brojMobitela, int brojVozackeDozvole)
            : this(name, brojMobitela, brojVozackeDozvole)
        {
            IDVozac = iDVozac;
        }

        public int IDVozac { get; set; }
        public string Name { get; set; }
        public int BrojMobitela { get; set; }
        public int BrojVozackeDozvole { get; set; }

        public Vozac()
        {
        }

        public override string ToString() => Name;
    }
}
