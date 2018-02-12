using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("See programm vahetab sisestatud sõnade seesmised tähed.");
            Console.WriteLine("Teie sisestatud sõnad: \n");
            String text = Console.ReadLine();

            string word = text;                                                       //
            string scrambled_Word = AjaSegi(word);


            Console.WriteLine(scrambled_Word);

            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
        }

        static string AjaSegi(string word)
        {
            char[] chars = new char[word.Length];
            Random rand = new Random(10000);
            int index = 0;
            while (word.Length > 0)
            { // Get a random number between 0 and the length of the word. 
                int next = rand.Next(0, word.Length - 1); // Take the character from the random position 
                                                          //and add to our char array. 
                                                          // Remove the character from the word. 

                if (chars[index] == 0)
                {
                    word = word.Substring(0, next) + word.Substring(next + 1);
                }
                else if(chars[index] == word.Length)
                {
                    word = word.Substring(0, next) + word.Substring(next + 1);
                }
                else
                {
                    chars[index] = word[next];
                    word = word.Substring(0, next) + word.Substring(next + 1);
                }
                          
                ++index;
            }
            return new String(chars);
        }
    }
}
