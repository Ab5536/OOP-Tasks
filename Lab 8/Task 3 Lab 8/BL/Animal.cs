using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3_Lab_8.BL
{
    class Animal
    {
        protected string Name;
        public Animal(string Name)
        {
            this.Name = Name;
        }
        public virtual string toString()
        {
            return " Name: " + Name;
        }
    }
}
