using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Restaurant restaurant = new Restaurant("Resto restaurant", "1100 Main ST.");

            Tab tab = new Tab();

            tab.Add(7.55);
            tab.Add(3.24);
            tab.Add(6.157);

            Receipt receipt = restaurant.GetReceipt();

            Console.Write(receipt);

            Console.WriteLine();
            Console.WriteLine("Press any key to continue!");
            Console.ReadKey();
        }
    }
}
