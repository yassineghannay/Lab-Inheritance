using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Inheritance
{
    // git test
    internal class Salaried : Employee
    {

     public double salary { get; set;  }

        public double GetPay(double salary)
        { 
            return salary;
              
            
        }

     


    }
}

