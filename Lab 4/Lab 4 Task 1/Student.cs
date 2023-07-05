using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main_Lab_4
{
    class Student
    {
        public string name;
        public int roll_no;
        public float Cgpa;
        public int matricMarks;
        public int fscMarks;
        public int ecatMarks;
        public string homeTown;
        public bool isHostelite;
        public bool isTakingScholarship;
        public Student(string name, int roll_no,float Cgpa,int matricMarks,int fscMarks,int ecatMarks,string homeTown,bool isHostelite,bool isTakingScholarship)
        {
            this.name = name;
            this.roll_no = roll_no;
            this.Cgpa = Cgpa;
            this.matricMarks = matricMarks;
            this.fscMarks = fscMarks;
            this.ecatMarks = ecatMarks;
            this.homeTown = homeTown;
            this.isHostelite = isHostelite;
            this.isTakingScholarship = isTakingScholarship;
        }
        /* public  void Hostelite(char check)
         {
             if (check == 'y' || check == 'Y')
             {
                 isHostelite = true;
             }
             else if (check == 'n' || check == 'N')
             {
                 isHostelite = false;
             }
         }
         public void Scholarship(char check)
         {
             if (check == 'y' || check == 'Y')
             {
                 isTakingScholarship = true;
             }
             else if (check == 'n' || check == 'N')
             {
                 isTakingScholarship = false;
             }
         }*/
        public double calculateMerit()
        {
            return ((fscMarks*100/1100)*0.60)+((ecatMarks*100/400)*0.40);
        }
        public void viewMerit()
        {
            Console.WriteLine("Merit of {0}: {1}",name, calculateMerit());
        }
        public bool isEligibleforScholarship()
        {
            double meritPercentage = calculateMerit();
            if (meritPercentage>=80 && isHostelite == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void viewScholarship()
        {
            Console.WriteLine("{0} ! Is Eligible : {1}",name,isEligibleforScholarship());
        }
    }
}
