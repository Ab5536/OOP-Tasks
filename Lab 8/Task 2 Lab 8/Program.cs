using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_2_Lab_8.BL;
namespace Task_2_Lab_8
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> persons = new List<Person>();
            Student st1 = new Student("Abdullah","Khalid Hall","BS-CS",1,55255);
            Student st2 = new Student("Talha", "Tariq Hall", "BS-CS", 2, 55);
            Staff staff1 = new Staff("Sir Laeeq", "Mianwali", "UET", 100000);
            Staff staff2 = new Staff("Sir Irzam", "Jehlum", "UET CS", 990000);
            persons.Add(st1);
            persons.Add(st2);
            persons.Add(staff1);
            persons.Add(staff2);
            foreach(Person p in persons)
            {
                Console.WriteLine(p.toString());
            }
            /*
            Console.WriteLine(st1.toString());
            Console.WriteLine(st2.toString());
            Console.WriteLine(staff1.toString());
            Console.WriteLine(staff2.toString());
            */
            Console.ReadKey();
        }
    }
}
