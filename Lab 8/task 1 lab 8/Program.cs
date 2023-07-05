using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_1_lab_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Cylinder obj1 = new Cylinder();
            Cylinder obj2 = new Cylinder(2,3);
            Cylinder obj3 = new Cylinder(6,5,"Blue");
            obj1.setHeight(5);
            obj2.setHeight(6);
            obj2.setHeight(7);
            Console.WriteLine("Volume of 1: {0}", obj1.getVolume());
            Console.WriteLine("Volume of 2: {0}", obj2.getVolume());
            Console.WriteLine("Volume of 3: {0}", obj3.getVolume());
            Console.ReadKey();
        }
    }
}
