using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2_Lab_8.BL
{
    class Staff: Person
    {
        private string school;
        private double pay;
        public Staff(string Name,string address,string school,double pay): base(Name,address)
        {
            this.school = school;
            this.pay = pay;
        }
        public string getSchool()
        {
            return school;
        }
        public void setSchool(string school)
        {
            this.school = school;
        }
        public double getPay()
        {
            return pay;
        }
        public void setPay(double pay)
        {
            this.pay= pay;
        }
        public override string toString()
        {
          
            return (base.toString()+ " School: " + school + " Pay: " + pay);
        }
    }
}
