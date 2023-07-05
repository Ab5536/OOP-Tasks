using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main_Lab_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 0;
            int option = optionfn();
            List<Student> students = new List<Student>();
            do
            {
                option = optionfn();                
                if (option == 1)
                {
                    Console.Write("Enter your Name: ");
                    string name = Console.ReadLine();
                    Console.Write("Enter Roll Number: ");
                    int roll_no = int.Parse(Console.ReadLine());
                    Console.Write("Enter CGPA: ");
                    float Cgpa = float.Parse(Console.ReadLine());
                    Console.Write("Enter Matric Marks: ");
                    int matricMarks = int.Parse(Console.ReadLine());
                    Console.Write("Enter FSC Marks: ");
                    int fscMarks = int.Parse(Console.ReadLine());
                    Console.Write("Enter ECAT Marks: ");
                    int ecatMarks = int.Parse(Console.ReadLine());
                    Console.Write("Enter your HomeTown: ");
                    string homeTown = Console.ReadLine();
                    Console.WriteLine("Enter true for Hostelite and false for Day Scholar: ");
                    bool isHostelite = bool.Parse(Console.ReadLine());
                    Console.WriteLine("Enter \n1)true if you are availing Scholarship \n2)False if you are not taking scholarship: ");
                    bool isTakingScholarship = bool.Parse(Console.ReadLine());
                    students.Add(new Student(name, roll_no, Cgpa, matricMarks, fscMarks, ecatMarks, homeTown, isHostelite, isTakingScholarship));
                    students[num].viewMerit();
                    students[num].viewScholarship();
                    num++;
                    
                    // students.
                }
            } while (option != 2);
            Console.Read();
        }
        
        static int optionfn()
        {
            int op = 0;
            Console.WriteLine("\t\t-----Menu------");
            Console.WriteLine("1. Run CRC\n2)Exit");
            op = int.Parse(Console.ReadLine());
            return op;
        }
    }
}
