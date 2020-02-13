using System;

namespace PRACTICAL4
{
    class Program
    {
        static void Main(string[] args)
        {
            string infix;
            Console.WriteLine("Enter Infix String...");
            infix = Console.ReadLine();
            string postfix;
            ToPostfix toPostfix = new ToPostfix();
            toPostfix.ifixTopostfix(infix, out postfix);
            Console.WriteLine("infix : "+infix);
            Console.WriteLine("postfix : "+postfix);
        }
    }
}
