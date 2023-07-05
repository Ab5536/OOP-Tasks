using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3_Lab_8.BL
{
    class Cat: Mammal
    {
        public Cat(string Name): base(Name)
        {

        }
        public void greets()
        {
            Console.WriteLine("Meow");
        }
        public override string toString()
        {
            return base.toString();
        }
    }
}
