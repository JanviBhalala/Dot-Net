using System;

namespace Practical_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Car_Salesman c = new Car_Salesman("Janvi","Bhalala");
            c.Sell();
            Retail_Salesman r = new Retail_Salesman("Bansi","Bera");
            r.Sell();
            Console.ReadKey();
        }
    }
}
