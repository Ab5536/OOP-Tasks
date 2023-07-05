using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2_Lab_8.BL
{
    class Person
    {
        protected string Name;
        protected string address;
        public Person(string Name,string address)
        {
            this.Name = Name;
            this.address = address;
        }
        public string getName()
        {
            return Name;
        }
        public string getAddress()
        {
            return address;
        }
        public void setAddress(string address)
        {
            this.address = address;
        }
        public virtual string toString()
        {
            return "Name: " + Name + " Address: " + address;
        }
    }
}
