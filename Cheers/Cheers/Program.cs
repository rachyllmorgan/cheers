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
            System.Console.WriteLine("Hi, " + name);
            foreach (char letter in name.ToLower())
            {
                if (Char.IsLetter(letter))
                {
                    string a = "a...  ";
                    string hasVowel = "aeioulfrh";
                    if (hasVowel.Contains(letter))
                    {
                        a = "an... ";
                    }

                    System.Console.WriteLine("Give me " + a + letter);
                }
            }
            System.Console.WriteLine(name.ToUpper() + " is GRAND!");
            System.Console.WriteLine("Hey, " + name + ", what’s your birthday? (MM / DD");
            DateTime birthdate = DateTime.Parse(System.Console.ReadLine());
            DateTime today = DateTime.Today;
            DateTime next = birthdate.AddYears(DateTime.Today.Year - birthdate.Year);
            int remainingDays = (next - today).Days;
            string days = " days ";
            if (remainingDays == 1)
            {
                days = " day ";
            }
            if (next < today)
            {
                next = next.AddYears(1);
                remainingDays = (next - today).Days;
                System.Console.WriteLine("Your birthday is " + remainingDays + days + "away!");
            }
            else if (next == today)
            {
                System.Console.WriteLine("Happy Birthday!!");
            }
            else
            {
                remainingDays = (next - today).Days;
                System.Console.WriteLine("Your birthday is " + remainingDays + days + "away!");
            }
            System.Console.WriteLine("Press any key to exit");
            System.Console.ReadKey();
        }
    }
}
