using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Inheritance
{
    internal class PartTime : Employee
    {

        public double rate { get; set; }
        public double hours { get; set;  }


        public double GetPay(double rate, double hours)
        {
           
            return rate * hours;

        }


     

    }
}

