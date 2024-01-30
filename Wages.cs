using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Inheritance
{
    internal class Wages : Employee
    {
        public double rate { get; set; }
        public double hours { get; set; }


        public double GetPay(double rate , double hours , double newRate)
        {


            newRate = rate * 0.5;
            if (hours > 40 )
            {
                return newRate;
            } else
            {
                return rate * hours;
            }


        }


       





    }
}

