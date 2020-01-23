using System;
using System.Collections.Generic;
using System.Text;

namespace Practical_3
{
    class Car_Salesman : Salesman
    { public Car_Salesman(String fn, String lnm) : base(fn, lnm) {

        }
        
        override public void Sell()
        {
            Console.WriteLine("I am " + FullName + " I want you to buy this Car");
        }
    }
}
