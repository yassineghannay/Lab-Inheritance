using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;


namespace Lab_Inheritance
{
    
    class Employee
     
    {
        public string id { get; set; }
        public string name { get; set; }
        public string address { get; set; }
        public string phone { get; set; }
        public long sin { get; set; }
        public string dob { get; set; }
        public string dept { get; set; }

        


        public Employee()

        {
            
        }

        public Employee(string id, string name, string address, long sin, string dob,string dept , string phone)
        {
            this.name = name;
            this.id = id;
            this.address = address;
            this.sin = sin;
            this.dob = dob;
            this.dept = dept;
            this.phone = phone;

        }

        public override string ToString()
        {
            return $"the name is {name} and the id is {id} and the address is {address} and the sin is {sin} and the dob is {dop} and the departement is {dept}";
        }
          

    }
}

