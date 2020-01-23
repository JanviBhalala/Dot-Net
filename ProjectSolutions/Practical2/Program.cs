using System;
using System.Text.RegularExpressions;

namespace Practical2
{
    class Program
    {
        static void Main(string[] args)
        {
            string name, country;
            do
            {
                Console.WriteLine("What's your name?");
                name = Console.ReadLine();
            }
            while (!Regex.IsMatch(name, @"^[a-zA-Z]+$"));
            do
            {
                Console.WriteLine("Where are you from?");
                country = Console.ReadLine();
            }
            while (!Regex.IsMatch(country, @"^[a-zA-Z]+$"));

            Console.WriteLine("Hello " + name +" from " +country);
        }
    }
}
