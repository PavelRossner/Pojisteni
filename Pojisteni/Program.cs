using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pojisteni
{
    class Program
    {
        static void Main(string[] args)
        {
            Operace operace = new Operace();

            Console.WriteLine("--------------------------------");
            Console.WriteLine("Evidence pojištěných");
            Console.WriteLine("--------------------------------");
            int akce = 0;
            while (akce != 4)

            {
                Console.WriteLine();
                Console.WriteLine("Vyberte si akci:");
                Console.WriteLine("1 - Přidat nového pojištěného");
                Console.WriteLine("2 - Vypsat všechny pojištěné");
                Console.WriteLine("3 - Vyhledat pojištěného");
                Console.WriteLine("4 - Konec");
                akce = int.Parse(Console.ReadLine());

                if (akce == 1)
                    operace.Zadani();

                else if (akce == 2)
                    operace.Vypis();

                else if (akce == 3)

                {
                    operace.ZadaniHledani();
                }

                else if (akce == 4)
                    Console.WriteLine("Program ukončíte libovolnou klávesou.\n");

                else
                    Console.WriteLine("Neplatné zadání, zkuste znovu.\n");
            }
            Console.ReadKey();
        }
    }
}

