using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pojisteni
{
    class Pojisteny
    {
        public string Jmeno { get; set; }
        public string Prijmeni { get; set; }
        public int Telefon { get; set; }
        public int Vek { get; set; }

        public Pojisteny(string jmeno, string prijmeni, int telefon, int vek)
        {
            this.Jmeno = jmeno;
            this.Prijmeni = prijmeni;
            this.Telefon = telefon;
            this.Vek = vek;
        }
        public override string ToString()
        {
            return Jmeno + " " + Prijmeni + " " + Vek + "       " + Telefon;
        }
    }
}
