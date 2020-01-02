using System;

namespace Practical1
{
    class Program
    {
        static void Main(string[] args)
        {
            Pattern1();
            Console.WriteLine();
            Pattern2();
            Console.WriteLine();
            Pattern3();
            Console.WriteLine();
            Pattern4();
            Console.ReadKey();

            
        }

        static void Pattern1()
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                    Console.Write("*");
                Console.WriteLine();
            }
        }
        static void Pattern2()
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = i; j < 5; j++)
                    Console.Write("*");
                Console.WriteLine();
            }

        }
        static void Pattern3()
        {
            for (int i = 0; i < 5; i++)
            { 

                for (int k = 1; k <= i + 1; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
        static void Pattern4()
        {
            for (int i = 1,int k = 0; i <= 5; ++i)
            {
                for (int space = 1; space <= 5 - i; ++space)
                { Console.Write(""); }
                while ( k != 2 * (i - 1))
                {
                Console.Write("*");
                ++k;
                }
            Console.WriteLine();
        }
        }
    }
}
