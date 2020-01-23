using System;
using System.Collections.Generic;
using System.Text;

namespace Practical_3
{
    public abstract class Salesman
    {
        String firstName ;
        String lastName;
        public String FullName {
            get { return firstName +" " + lastName; }
        }
        public Salesman(String fn,String lnm)
        {
            firstName=fn;
            lastName = lnm;
        }
          

        public abstract void Sell();

    }
}
