using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cykly
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
            //cyklus s nekonecnym poctem opakovani
            //cykus s podminkou na zacatku, pokud neni splnena tak se cyklus ani nespusti
            int counter = 0;
            bool a = bool.Parse(Console.ReadLine());
            while (a == true) //vyhodnocovani podminky
            {
                //příkaz
                
                counter += 1;
                Console.WriteLine(counter);
            }

            Console.WriteLine("podmínka nebyla splněna a dostal jsem se sem!");
            */


            //cyklus spevným počtem opakování
            //for(počáteční hodnota, podmínka, příkaz)
            //i++ -> inkrementace, přičtení o jedna
            //i-- -> dekrementace, snížení o jedna
            //cyklus for má řídicí proměnnou (i)
            Console.WriteLine("kolikrat se ma cyklus opakovat");
            int x = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < x; i++)
            {
                Console.WriteLine(i);
            }

            Console.ReadKey();
        }
    }
}
