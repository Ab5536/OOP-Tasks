using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3_Lab_8.BL
{
    class Mammal:Animal
    {
        public Mammal(string Name) : base(Name)
        {

        }
        public override string toString()
        {
            return base.toString();
        }
    }
}
