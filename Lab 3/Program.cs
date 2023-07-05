
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3
{
    class Program
    {
        //Task 1
        /* 
          class student
         {

            public string sname;
             public int roll_no;
             public float CGPA;

         }
         static void Main(string[] args)
         {
             student name = new student();
             Console.WriteLine("Name: {0}",name.sname);
              Console.WriteLine("Roll No: {0}", name.roll_no);
              Console.WriteLine("CGPA: {0}", name.CGPA);
             Console.ReadKey();
        }
        */

        //Task 2

        /*
          class student
           {
               public student()
               {
                   Console.WriteLine("Default Constructor Called");
               }
               public string sname;
               public int roll_no;
               public float CGPA;
           }
           static void Main(string[] args)
           {
               student name = new student();
              //   Console.WriteLine("Name: {0}", name.sname);
             //    Console.WriteLine("Roll No: {0}", name.roll_no);
            //     Console.WriteLine("CGPA: {0}", name.CGPA);
               Console.ReadKey();
           }
           */

        //Task 3

        /*
          class student
        {
            public student()
            {
                 sname = "Adullah Zahid";
                
            }
            public string sname;
            public int roll_no;
            public float CGPA;
        }
        static void Main(string[] args)
        {
              student name = new student();
              Console.WriteLine("Name: {0}", name.sname);
             //Console.WriteLine("Roll No: {0}", name.roll_no);
              //Console.WriteLine("CGPA: {0}", name.CGPA);
              Console.ReadKey();
        }
        */

        //Task 4

        /*
          class student
          {
              public student()
              {
                  sname = "Adullah Zahid";
                  roll_no = 3;
                  CGPA = 3.6F;
              }

              public string sname;
              public int roll_no;
              public float CGPA;
          }
          static void Main(string[] args)
          {
              student name = new student();
              student newname = new student();
              Console.WriteLine("Name: {0}", name.sname);
              Console.WriteLine("Roll No: {0}", name.roll_no);
              Console.WriteLine("CGPA: {0}", name.CGPA);
              Console.WriteLine("----------New----------");
              Console.WriteLine("New Name: {0}",newname.sname);
              Console.WriteLine("New Roll No: {0}", newname.roll_no);
              Console.WriteLine("New CGPA: {0}", newname.CGPA);
              Console.ReadKey();
          }
        */

        //Task 5
        /*
         class student
         {
             public student(string na)
             {
                 sname = na;
             }

             public string sname;
             public int roll_no;
             public float CGPA;
         }
         static void Main(string[] args)
         {
             student name = new student("John");
             student newname = new student("Jack");
             Console.WriteLine("Name: {0}", name.sname);
             //Console.WriteLine("Roll No: {0}", name.roll_no);
             //Console.WriteLine("CGPA: {0}", name.CGPA);
             Console.WriteLine("----------New----------");
             Console.WriteLine("New Name: {0}", newname.sname);
             //Console.WriteLine("New Roll No: {0}", newname.roll_no);
            // Console.WriteLine("New CGPA: {0}", newname.CGPA);
             Console.ReadKey();
         }
        */

        //Task 6
        /*
         class student
         {
             public student(string nam,int roll,float cgpa)
             {
                 sname = nam;
                 roll_no = roll;
                 CGPA = cgpa;
             }
             public string sname;
             public int roll_no;
             public float CGPA;
         }
         static void Main(string[] args)
         {
             student name = new student("Abdullah zahid",3,3.6F);
             student newname = new student("Rauf",37,3.3F);
             Console.WriteLine("Name: {0}", name.sname);
             Console.WriteLine("Roll No: {0}", name.roll_no);
             Console.WriteLine("CGPA: {0}", name.CGPA);
             Console.WriteLine("----------New----------");
             Console.WriteLine("New Name: {0}", newname.sname);
             Console.WriteLine("New Roll No: {0}", newname.roll_no);
             Console.WriteLine("New CGPA: {0}", newname.CGPA);
             Console.ReadKey();
         }
        */

        //TASK 7
        /*
        class student
        {
            public student()
               {
                  Console.WriteLine("Default Constructor Called");
               }
            public student(student name)
            {
                sname = name.sname;
                roll_no = name.roll_no;
                CGPA = name.CGPA;
            }
            public string sname;
            public int roll_no;
            public float CGPA;
        }
        static void Main(string[] args)
        {
            student name = new student();
            name.sname = "Abdullah Zahid";
            name.roll_no = 3;
            name.CGPA = 3.6F;
            Console.WriteLine("Name: {0}", name.sname);
            Console.WriteLine("Roll No: {0}", name.roll_no);
            Console.WriteLine("CGPA: {0}", name.CGPA);
            student newname = new student(name);
            Console.WriteLine("----------New----------");
            Console.WriteLine("New Name: {0}", newname.sname);
            Console.WriteLine("New Roll No: {0}", newname.roll_no);
            Console.WriteLine("New CGPA: {0}", newname.CGPA);
            student nname = new student();
            Console.WriteLine("----------N----------");
            Console.WriteLine("New Name: {0}", nname.sname);
            Console.WriteLine("New Roll No: {0}", nname.roll_no);
            Console.WriteLine("New CGPA: {0}", nname.CGPA);
            Console.ReadKey();
        }
        */
        //Task 8
        /*
         //static void Main(string[] args)
         //{
         //    List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
         //   for (int i = 0; i < numbers.Count; i++)
         //    {
          //       Console.WriteLine(numbers[i]);
           //  }
           //  Console.ReadKey();
         //}
         static void Main(string[] args)
         {
             List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
             foreach (var i in numbers)
             {
                 Console.WriteLine(i);
             }
             Console.Read();
         }
         */
        //Task 1 ClockType
        /*
         class clocktype
        {
            public int hours;
            public int minutes;
            public int seconds;
            public clocktype()
            {
                hours = 0;
                minutes = 0;
                seconds = 0;
            }
            public clocktype(int h)
            {
                hours = h;
            }
            public clocktype(int h, int m)
            {
                hours = h;
                minutes = m;
            }
            public clocktype(int h, int m, int s)
            {
                hours = h;
                minutes = m;
                seconds = s;
            }
            public void incrementSecond()
            {
                seconds++;
            }
            public void incrementhours()
            {
                hours++;
            }
            public void incrementminutes()
            {
                minutes++;
            }
            public void printTime()
            {
                Console.WriteLine(hours + " " + minutes + " " + seconds);
            }
            public bool isEqual(int h, int m, int s)
            {
                if (hours == h && minutes == m && seconds == s)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            public bool isEqual(clocktype temp)
            {
                if (hours == temp.hours && minutes == temp.minutes && seconds == temp.seconds)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        static void Main(string[] args)
        {
            //Console.WriteLine(name.name1);
            //Default Constructor
            clocktype empty_time = new clocktype();
            Console.Write("Empty Time: ");
            empty_time.printTime();

            //Parametarized Constructor
            clocktype hour_time = new clocktype(8);
            Console.Write("Hour Time: ");
            hour_time.printTime();

            //Paramer Constructor (two Parameters)
            clocktype minute_time = new clocktype(8, 10);
            Console.Write("Minute Time: ");
            minute_time.printTime();

            //Paramer Constructor (three Parameters)
            clocktype full_time = new clocktype(8, 10,0);
            Console.Write("Full Time: ");
            full_time.printTime();

            //increment Second
            full_time.incrementSecond();
            Console.Write("Full Time (Increment Seconds): ");
            full_time.printTime();

            //increment Minutes
            full_time.incrementminutes();
            Console.Write("Full Time (Increment Minutes): ");
            full_time.printTime();

            //increment Hours
            full_time.incrementhours();
            Console.Write("Full Time (Increment Hours): ");
            full_time.printTime();

            //check if Equal
            bool flag = full_time.isEqual(9, 11, 11);
            Console.WriteLine("Flag: " + flag);

            //Check if Equal with Object
            clocktype cmp = new clocktype(10, 12, 1);
            flag = full_time.isEqual(cmp);
            Console.WriteLine("Object Flag: " + flag);
            Console.Read();
        }
        */
        //Challenge 1
        /*
        class clocktype
        {
            public clocktype()
            {
                Console.WriteLine("Default Constructor Called");
                hours = 0;
                minutes = 0;
                seconds = 0;
            }
            public clocktype(int h)
            {
                hours = h;
            }
            public clocktype(int h, int m)
            {
                hours = h;
                minutes = m;
            }
            public clocktype(int h, int m, int s)
            {
                hours = h;
                minutes = m;
                seconds = s;
            }
            public int hours;
            public int minutes;
            public int seconds;

            public void printTime()
            {
                Console.WriteLine(" {0} : {1} : {2}", hours, minutes, seconds);
            }
            public void incrementSecond()
            {

                seconds++;
                if (seconds == 60)
                {
                    seconds = 0;
                    incrementMinute();
                }
            }

            public void incrementMinute()
            {
                minutes++;
                if (minutes == 60)
                {
                    minutes = 0;
                    incrementHour();
                }
            }
            public void incrementHour()
            {
                hours++;
                if (hours == 24)
                {
                    hours = 0;

                }
            }
            public void changeTime(int hour, int minute, int second)
            {
                hours = hour;
                minutes = minute;
                seconds = second;
            }
            private int timeinseconds(int hh, int mm, int ss)
            {
                return ((hh * 60 * 60) + (mm * 60) + ss);
            }

            public void compareTime(int hh, int mm, int ss)
            {
                int giventime = timeinseconds(hh, mm, ss);
                int currenttime = timeinseconds(hours, minutes, seconds);
                if (giventime > currenttime)
                {
                    giventime = giventime - currenttime;
                    hh = giventime / 3600;
                    giventime = giventime % 3600;
                    mm = giventime / 60;
                    giventime = giventime % 60;
                    ss = giventime;
                    Console.WriteLine("Given Time is Greater :\n  {0} : {1} : {2}", hh, mm, ss);
                }
                else if (giventime < currenttime)
                {
                    currenttime = currenttime - giventime;
                    hh = currenttime / 3600;
                    currenttime = currenttime % 3600;
                    mm = currenttime / 60;
                    currenttime = currenttime % 60;
                    ss = currenttime;
                    Console.WriteLine("Current Time is greater : \n  {0} : {1} : {2}", hh, mm, ss);
                }
            }
            public int elapsedTime()
            {
                return timeinseconds(hours, minutes, seconds);
            }
            public int remainingTime()
            {
                return (timeinseconds(hours, minutes, seconds)-(24*3600));
            }
        }
        static void Main(string[] args)
        {

            Console.Write("Enter Hours: ");
            int hours = int.Parse(Console.ReadLine());
            Console.Write("Enter Minutes: ");
            int minutes = int.Parse(Console.ReadLine());
            Console.Write("Enter Seconds: ");
            int seconds = int.Parse(Console.ReadLine());
            clocktype clock = new clocktype(hours, minutes, seconds);
            int option = choice();
            //clocktype settime = new clocktype();
            do
            {

                option = choice();
                if (option == 1)
                {
                    Console.Write("Enter Hours: ");
                    int newhours = int.Parse(Console.ReadLine());
                    Console.Write("Enter Minutes: ");
                    int newminutes = int.Parse(Console.ReadLine());
                    Console.Write("Enter Seconds: ");
                    int newseconds = int.Parse(Console.ReadLine());
                    clock.changeTime(newhours, newminutes, newseconds);
                                        //printTime();
                }
                else if (option == 2)
                {
                    clock.printTime();
                }
                else if (option == 3)
                {
                    clock.incrementSecond();
                }
                else if (option == 4)
                {
                    clock.incrementMinute();
                }
                else if (option == 5)
                {
                    clock.incrementHour();
                }
                else if (option == 6)
                {
                    clock.compareTime(hours, minutes, seconds);
                }
                else if (option == 7)
                {
                    Console.WriteLine("Elapsed Time: "+clock.elapsedTime());
                }
                else if (option == 8)
                {
                    Console.WriteLine("Remaining Time: " + clock.remainingTime());
                }         
            } while (option != 9);
            Console.ReadLine();
        }
        public static int choice()
        {
            Console.WriteLine("\t\t-----Menu------");
            Console.WriteLine("1. Change the time(seconds, minutes, hours).\n2.Print the time.\n3.Increment the time by one second.\n4.Increment the time by one minute.\n5.Increment the time by one hour.\n6.Compare the two times for equality.\n\t * With manual timings\n\t * With passed object’s timings\n7)Elapsed Timing \n8) Remaining Time");
            int CHOICE = int.Parse(Console.ReadLine());
            return CHOICE;
        }
        */
        //Challenge 2
        ///*
        class product
        {
            public string name;
            public string category;
            public double price;
            public int stockQuantity;
            public int minimumStock;
            public int salestax;
            public product(string name,string category,double price,int stockQuantity,int minimumStock)
            {
                this.name = name;
                this.category = category;
                this.price = price;
                this.stockQuantity = stockQuantity;
                this.minimumStock = minimumStock;
                if(category=="Grocery"|| category == "grocery")
                {
                    salestax = 10;
                }
                else if (category == "Fruit" || category == "fruit")
                {
                    salestax = 5;
                }
                else
                {
                    salestax = 15;
                }
            }
            public void display()
            {
                Console.Write("Name: {0}\tCategory: {1}\tPrice: {2}\tStock Quantity: {3}\tMinimum Stock Quantity: {4}\n", name, category, price, stockQuantity, minimumStock);
            }
            public void taxdisplay()
            {
                Console.Write("Name: {0}\tCategory: {1}\tPrice: {2}\tStock Quantity: {3}\tMinimum Stock Quantity: {4}\tSales Tax: {5}%\n", name, category, price, stockQuantity, minimumStock,salestax);
            }

        }
        
        static void Main(string[] args)
        {
            int option= optionfn();
            List<product> products = new List<product>();
            do
            {
                if (option  == 1)
                {
                    Console.Clear();
                    addProduct(products);
                }
                else if (option == 2)
                {
                    Console.Clear();
                    viewProduct(products);
                }
                else if (option == 3)
                {
                    Console.Clear();
                    int index= findProduct(products);
                   products[index].display();
                }
                else if (option == 4)
                {
                    Console.Clear();
                    salesTax(products);
                }
                else if (option == 5)
                {

                }
                option = optionfn();
            } while (option!=6);
            Console.Read();
        }

        static int optionfn()
        {
            int op=0;
            Console.WriteLine("\t\t-----Menu------");
            Console.WriteLine("1. Add Product\n2. View All Product\n3. Find Product with the Highest Unit Price \n4. View Sales Tax of All Products\n5. Products to be Ordered \n");
            op = int.Parse(Console.ReadLine());
            return op;
        }

        static void addProduct(List<product> products)
        {
            Console.Write("Enter name of Product: ");
            string name = Console.ReadLine();
            Console.Write("Enter category of Products(Groceries/Fresh Fruit): ");
            string category = Console.ReadLine();
            Console.Write("Enter price of Product: ");
            double pprice=double.Parse(Console.ReadLine());
            Console.Write("Enter Stock Quantity: ");
            int pquantity = int.Parse(Console.ReadLine());
            Console.Write("Enter Minimum Stock: ");
            int pstock = int.Parse(Console.ReadLine());
            products.Add(new product(name,category,pprice,pquantity,pstock));
        }
        static void viewProduct(List<product> products)
        {
            foreach(product p in products)
            {
                p.display(); 
            }
        }
        static int findProduct(List<product> products)
        {
            double z = products[0].price;
            int index = 0;
            for(int i = 0; i < products.Count; i++)
            {
                if(products[i].price > z)
                {
                    z = products[i].price;
                    index = i;
                }
            }
            return index;
        }
        static void salesTax(List<product> products)
        {
            foreach (product p in products)
            {
                p.taxdisplay();
            }
        }
    }
}

