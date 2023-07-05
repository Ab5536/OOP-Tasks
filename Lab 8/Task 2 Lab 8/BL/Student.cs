using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_2_Lab_8.BL;

namespace Task_2_Lab_8.BL
{
    class Student : Person
    {
        private string program;
        private int year;
        private double fee;
        public Student(string Name,string address,string program,int year,double fee): base(Name, address)
        {
            this.program = program;
            this.year = year;
            this.fee = fee;
        }
        public string getProgram()
        {
            return program;
        }
        public void setProgram(string program)
        {
            this.program = program;
        }
        public int getYear()
        {
            return year;
        }
        public void setYear(int year)
        {
            this.year = year;
        }
        public double getFee()
        {
            return fee;
        }
        public void setFee(double fee)
        {
            this.fee=fee;
        }
        public override string toString()
        {
          // base.toString();
            return base.toString() + " Program: " + program + " Year: " + year +" Fee: "+fee;
        }


    }
}
