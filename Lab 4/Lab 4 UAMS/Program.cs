using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab_4_UAMS.BL;

namespace Lab_4_UAMS
{
    class Program
    {
        static void Main(string[] args)
        {
            int option = 0;
            List<Student> students = new List<Student>();

            do
            {
                option = Menu();
                if (option == 1)
                {
                    students.Add(inputnewStudent());
                }
                else if (option == 2)
                {

                }
                else if (option == 3)
                {

                }
                else if (option == 4)
                {

                }
                else if (option ==5)
                {

                }
                else if (option == 6)
                {

                }
                else if (option == 7)
                {

                }
                else if (option == 8)
                {

                }
            }whle();
        }

        public static Student inputnewStudent()
        {
            Console.Write("Enter Student Name: ");
            string name = Console.ReadLine();
            Console.Write("Enter Student Age: ");
            int age = int.Parse(Console.ReadLine());
            Console.Write("Enter Student's FSC Marks: ");
            int fscMarks = int.Parse(Console.ReadLine());
            Console.Write("Enter Student's ECAT Marks: ");
            int ecatMarks = int.Parse(Console.ReadLine());
            Console.WriteLine("Available Degree Programs: ");
            Console.Write("Enter how many preferences to Enter: ");
            int num = int.Parse(Console.ReadLine());
            List<String> subjects = new List<string>();
            for (int x = 0; x < num; x++)
            {
                Console.Write("Enter {0} Preference: ");
                string pref = Console.ReadLine();
                subjects.Add(pref);
            }
            Console.Write("Press any Key to Continue..... ");
            Console.ReadKey();
        }
        public static void inputnewDegree()
        {
            Console.Write("Enter Degree Name: ");
            string degreeName = Console.ReadLine();
            Console.Write("Enter degree Duration: ");
            int degreeDuration=int.Parse(Console.ReadLine());
            Console.Write("Enter seats for Degree: ");
            int seats = int.Parse(Console.ReadLine());
            Console.Write("Enter How many Subjects to Enter:  ");
            int num = int.Parse(Console.ReadLine());
            Console.Write("Enter Subject code: ");
            int subjectCode = int.Parse(Console.ReadLine());
            Console.Write("Enter Subject Type: ");
            string subjectType = Console.ReadLine();
            Console.Write("Enter Subject Credit Hours: ");
            int creditHours = int.Parse(Console.ReadLine());
            Console.Write("Enter Subject Fees: ");
            int fees = int.Parse(Console.ReadLine());

            Console.Write("Press any Key to Continue..... ");
            Console.ReadKey();


        }

        public static int Menu()
        {
            Console.WriteLine("1. Add Student");
            Console.WriteLine("2. Add Degree Program");
            Console.WriteLine("3. Generate Merit");
            Console.WriteLine("4. View Registered Students");
            Console.WriteLine("5. View Students of a Specific Program");
            Console.WriteLine("6. Register Subjects for a Specific Student");
            Console.WriteLine("7. Calculate Fees for all Registered Students");
            Console.WriteLine("8. Exit");
            Console.Write("Your Choice: ");
            int option = int.Parse(Console.ReadLine());
            return option;
        }
    }
}
