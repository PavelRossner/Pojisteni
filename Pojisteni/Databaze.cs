using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pojisteni
{
    class Databaze
    {
        private List<Pojisteny> udaje;

        public Databaze()
        {
            udaje = new List<Pojisteny>();
        }
        public void NovyUdaj(string jmeno, string prijmeni, int telefon, int vek)
        {
            udaje.Add(new Pojisteny(jmeno, prijmeni, telefon, vek));
        }
        public void Hledani(string hledaneJmeno, string hledanePrijmeni)
        {

          
           Pojisteny dotaz = udaje.Where(p => p.Jmeno == hledaneJmeno && p.Prijmeni == hledanePrijmeni).FirstOrDefault();
          
            if (dotaz == null)
                    Console.WriteLine("Osoba nebyla nalezena");

                else
                    Console.WriteLine("\n" + dotaz + "\n");
            Console.WriteLine("Pokračujte libovolnou klávesou...\n");
            Console.ReadKey();
          

        }
        public void Vypis()
        {
            foreach (Pojisteny pojisteny in udaje)
                Console.WriteLine(pojisteny);
        }

    }
}
