using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3_Lab_8.BL
{
    class Dog:Mammal
    {
        public Dog(string Name): base(Name)
        {
        }
        public void greets()
        {
            Console.WriteLine("Woof");
        }
        public void greets(Dog another)
        {
            Console.WriteLine("Wooof");
        }
        public override string toString()
        {
            return base.toString();
        }
    }
}
