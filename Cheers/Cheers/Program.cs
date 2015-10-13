using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cheers
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Hello there! What's your name?");
            string name = System.Console.ReadLine();
            System.Console.WriteLine("Hi," + name);
            name = name.ToLower();
            foreach (char letter in name)
            {
                string a = "a ";
                bool hasVowel = "aeioulfrh".IndexOf(letter) >= 0;
                if (hasVowel)
                {
                    a = "an ";
                }

                System.Console.WriteLine("Give me " + a + letter);
            }
            name = name.ToUpper();
            System.Console.WriteLine(name + " is GRAND!");
            System.Console.WriteLine("Press any key to exit");
            System.Console.ReadKey();
        }
    }
}
