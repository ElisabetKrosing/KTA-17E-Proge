using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programm mis lubab sisestada N+1 hulga erinevaid sõnu, kuni sisestatakse -1 \n");

            List<string> sõnad = new List<string>();

            while (true)
            {
                Console.Write("Sisesta sõna:");
                string input = Console.ReadLine();
                if (input == "-1")
                {
                    break;
                }
                else
                {
                    sõnad.Add(input);
                }
            }

            Console.Write("Sisestasite sõnad: \n");
            sõnad.ForEach(i => Console.Write("{0}\t \n", i));
            Console.WriteLine("Valin nendest välja suvalise: ");
            Random rnd = new Random();
            int r = rnd.Next(sõnad.Count);
            Console.WriteLine((string)sõnad[r]);


            Console.ReadKey();
        }
    }
}
