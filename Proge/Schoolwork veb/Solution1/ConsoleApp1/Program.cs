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

            String text = Console.ReadLine();
            List<String> Sõnad = new List<String>();
            Sõnad = text.Split(' ').ToList();
        }

    }
}
