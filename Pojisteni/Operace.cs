using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pojisteni
{
    class Operace
    {
        private Databaze databaze;
        public Operace()
        {
            databaze = new Databaze();
        }
        public void Zadani()

        {
            Console.WriteLine();
            Console.WriteLine("Zadejte jméno pojištěného:");
            string jmeno = Console.ReadLine();
            Console.WriteLine("Zadejte příjmení:");
            string prijmeni = Console.ReadLine();
            Console.WriteLine("Zadejte telefonní číslo:");
            int telefon = int.Parse(Console.ReadLine());
            Console.WriteLine("Zadejte věk:");
            int vek = int.Parse(Console.ReadLine());

            databaze.NovyUdaj(jmeno, prijmeni, telefon, vek);

            Console.WriteLine();
            Console.WriteLine("Data byla uložena. Pokračujte libovolnou klávesou...\n");
            Console.ReadKey();
        }
        public void ZadaniHledani()
        {
            Console.WriteLine();
            Console.WriteLine("Zadejte jméno pojištěného: ");
            string hledaneJmeno = Console.ReadLine();
            Console.WriteLine("Zadejte příjmení: ");
            string hledanePrijmeni = Console.ReadLine();

            if (string.IsNullOrEmpty(hledaneJmeno) || string.IsNullOrEmpty(hledanePrijmeni))
                Console.WriteLine("\nChybějící údaj, zadejte znovu.");
            else
                databaze.Hledani(hledaneJmeno, hledanePrijmeni);
        }

        public void Vypis()
        {
            Console.WriteLine();
            databaze.Vypis();
            Console.WriteLine("\n");
            Console.WriteLine("Pokračujte libovolnou klávesou...");
            Console.ReadKey();
        }



    }
}
