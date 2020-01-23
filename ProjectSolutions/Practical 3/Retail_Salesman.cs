using System;
using System.Collections.Generic;
using System.Text;

namespace Practical_3
{
    public class Retail_Salesman 
    {
        String firstName;
        String lastName;
        public String FullName
        {
            get { return firstName + lastName; }
        }
        public Retail_Salesman(String fn, String lnm)
        {
            firstName = fn;
            lastName = lnm;
        }
        public void Sell()
        {
            Console.WriteLine("I am " + FullName + " I want you to buy this Product");
        }
        // public Retail_Salesman(String fn, String lnm) : base(fn, lnm)
        //{}

        // override public void Sell(){
        //  Console.WriteLine("I am " + FullName + " I want you to buy this Product");
        //}
    }
}

