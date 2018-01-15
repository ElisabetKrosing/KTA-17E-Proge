using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangman_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hangman Game \n Arvake Sõnas olevaid tähti.");
            // Arvuti valib sõnadekogust 1 sõna. Vaatab mis tähed seal on. Prindib välja õige arvu _ . Arva ära seal olevad tähed. 5 elu mida loetakse.
            string[] sõnadekogu = new string[] { "Pseudokood", "Tarkvara", "Arvuti", "Integraalid", "Binaarkood", "Programm", "Koodimine", "Internet"};
            Random rnd = new Random();
            int r = rnd.Next(0, 8);
            string sõna = sõnadekogu[r];
            

            for (int ctr = 0; ctr <= sõna.Length - 1; ctr++)
            {
                Console.Write("_ ");
            }

            int elud = 100;

           

            while (elud > 0)
            {

                Console.Write("Pakkuge täht: ");
                string täht = Console.ReadLine();
                char letter = char.Parse(täht);
                List<string> arvatudTähed = new List<string>();
               // int täheAsukoht;
                int pikkus1 = arvatudTähed.Count;

                //tähtede kontroll
                for (int ctr = 0; ctr <= sõna.Length - 1; ctr++)
                {
                    char[] arvatudTähedS = new char[30];

                    if (letter == sõna[ctr])
                    {
                        Console.Write("{0} ", sõna[ctr]);

                        char jätaMeelde = sõna[ctr];
                        arvatudTähed.Add(täht);
                      //  täheAsukoht = ctr; 
                        arvatudTähedS[ctr] = letter;

                    }
                   
                    else
                    {
                        Console.Write("_ ");
                    }
                }
               // if (arvatudTähedS[täheAsukoht] == sõna[ctr])
               // {
               //     Console.Write("{0} ", sõna[ctr]);
               // }

                //elude arvutamine
                int pikkus2 = arvatudTähed.Count;
                if (pikkus1<pikkus2)
                {

                }
                else
                {
                    elud--;
                }


            }

            if (elud == 0)
            {
                Console.WriteLine("\n Kahjuks kaotasite!");
            }
            else
            {
                Console.WriteLine("\n Palju õnne, võitsite!");
            }
          
            
            Console.WriteLine("");

            Console.ReadKey();
        }
    }
}
