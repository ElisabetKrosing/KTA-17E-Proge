using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("See programm vahetab sisestatud sõnade seesmised tähed.");
            Console.WriteLine("Teie sisestatud sõnad: \n");
            String text = Console.ReadLine();
         

            //1.Tee String Stringi listiks?

            List<String> Sõnad = new List<String>();
            Sõnad = text.Split(' ').ToList();

            /*2.Kui on 1 täht lisa esimene täht char listi
            Kui on viimane täht lisa viimane täht char listi
            kui on 2 - eelviimane täht sega need ära.*/
            for (int i = 0; Sõnad.Count >= i ; i++)
            {
                List<char> sõna = new List<char>(Sõnad[i]);
                List<char> tähed = new List<char>();

                for (int j = 0; sõna.Count >= j ; j++) // Sega tähed
                {
                    if (j == 0)
                    {
                         tähed.Add(sõna[j]);
                    }
                    else if (j == sõna.Count)
                    {
                        tähed.Add(sõna[sõna.Count]);

                    }
                    else
                    {

                    }
                }

            }

        }
    }
}
