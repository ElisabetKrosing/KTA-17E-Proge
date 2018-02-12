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

            string valmisSõna = "";

            /*2.Kui on 1 täht lisa esimene täht char listi
            Kui on viimane täht lisa viimane täht char listi
            kui on 2 - eelviimane täht sega need ära.*/
            for (int i = 0; Sõnad.Count >= i ; i++)
            {
                List<char> sõna = new List<char>(Sõnad[i]);
                List<char> tähed = new List<char>();
                List<char> shuffle = new List<char>();

                for (int j = 0; sõna.Count >= j ; j++) // Sega tähed
                {
                    if (j == 0)
                    {
                         tähed.Add(sõna[j]);
                    }
                    else if (j == sõna.Count) //Kõige viimasena
                    {
                        char[] shuffledamine = shuffle.ToArray();

                        for (int ii = 0; ii < shuffledamine.Length; ii++)           //shuffledamine
                        {
                            Random rnd = new Random();
                            int rN = rnd.Next(0, (shuffledamine.Length - ii));

                            char s = shuffledamine[shuffledamine.Length - ii];
                            shuffledamine[shuffledamine.Length - ii] = shuffledamine[rN];
                            shuffledamine[rN] = s;

                        }

                        for (int jj = 0; jj < shuffledamine.Length; jj++)
                        {
                            tähed.Add(shuffledamine[jj]);
                        }

                        tähed.Add(sõna[j]);

                    }
                    else
                    {
                        shuffle.Add(sõna[j]);
                        
                    }
                    

                    StringBuilder builder = new StringBuilder();
                    foreach (int täht in tähed)
                    {
                        // Append each int to the StringBuilder overload.
                        builder.Append(täht);
                    }
                     valmisSõna = builder.ToString();

                 

                }
             }
            string valmisLause = string.Join(",", valmisSõna.ToArray());
            Console.WriteLine(valmisLause);
        }

        }
    }

