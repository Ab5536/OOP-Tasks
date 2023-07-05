using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Code_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //task1();
            //task2();
            // task3();
            //task4();
            //task5();
            //task6();
            //task7();
            //task8();


            //Manual 2
            //newtask1();
            //newtask2();
            //newtask3();
            //newtask4();
            //takeawaytask2();


            //Manual 3
            // Etask1();
            //  manualtask1();


            takeawaytask2();





        }

        public static void task()
        {
            Console.WriteLine("Hello World!!");
            Console.Write("Hello World");
            Console.ReadKey();
        }

            public static void task1()
        {
            int variable = 7;
            Console.WriteLine("Value : ");
            Console.Write(variable);
            Console.ReadKey();
        }
        public static void task2()
        {
            string variable = "I am String";
            Console.WriteLine("String : ");
            Console.Write(variable);
            Console.ReadKey();
        }
        public static void task3()
        {
            char variable = 'A';
            Console.WriteLine("Character: ");
            Console.Write(variable);
            Console.ReadKey();
        }
        public static void task4()
        {
            float variable = 7.7F;
            Console.WriteLine("Decimal : ");
            Console.Write(variable);
            Console.ReadKey();
        }

        public static void task5()
        {
            string str;
            str = Console.ReadLine();
            Console.WriteLine("You have inputted");
            Console.WriteLine(str);
            Console.ReadKey();
        }
        public static void task6()
        {
            string str;
            str = Console.ReadLine();
            Console.WriteLine("You have inputted : ");
            int num = int.Parse(str);
            Console.Write("The Number is : ");
            Console.Write(num);
            Console.ReadKey();
        }
        public static void task7()
        {
            string str;
            Console.WriteLine("Enter Floating Point Value : ");
            str = Console.ReadLine();
            float num = float.Parse(str);
            Console.Write("The Floating Value is : ");
            Console.Write(num);
            Console.ReadKey();

        }
        public static void task8()
        {
            //Console.ForegroundColor=ConsoleColor.Red;
            float Area;
            Console.WriteLine("Enter Length : ");
            string str = Console.ReadLine();
            float length=int.Parse(str);
            Area = length * length;
            Console.WriteLine("The Area is: " + Area);
           // Console.Write(Area);
            Console.ReadKey();
        }
        public static void newtask1()
        {
            Console.Write("Enter an  Number: ");
            string str = Console.ReadLine();
            float num = float.Parse(str);
            if (num > 50)
            {
                Console.WriteLine("You are Passed");
            }
            else
            {
                Console.WriteLine("You are Failed");
            }
            Console.ReadKey();
        }
        public static void newtask2()
        {
            for(int x = 0; x < 5; x++)
            {
                Console.WriteLine("Welcome Boss ");
            }
            Console.Read();
        }
        /*
         public static void newtask()
         {
             Console.ReadKey();
         }
        */
        public static void newtask3()
        {
            int sum=0 ;
            int num=1;
            while (num != -1)
            {
                Console.Write("Enter a Number : ");
                string str = Console.ReadLine();
                num = int.Parse(str);
                sum = sum + num;
            }
            Console.Write("Sum : " + sum);
            Console.Read();
        }
        public static void newtask4()
        {
            int num = 3;
            Console.Write("Enter the Number  : ");
            num = int.Parse(Console.ReadLine());
            int[] numbers = new int[num];
            for(int x=0;x<num;x++)
            {
                Console.Write("Enter the Number " + (x + 1) + " : ");
                numbers[x] = int.Parse(Console.ReadLine());
            }
            int largest = numbers[0];
            for(int y = 0; (y+1) < num; y++)
            {
                if (numbers[y+1] > numbers[y])
                {
                    largest = numbers[y+1];
                }
            }
            Console.WriteLine("Largest Number is: " + largest);
            Console.Read();
        }
        public static void Etask1()
        {
            Console.Write("Enter Number 1: ");
            float num1 = float.Parse(Console.ReadLine());
            Console.Write("Enter Number 2: ");
            float num2 = float.Parse(Console.ReadLine());
           Console.WriteLine("Sum : "+ Add(num1, num2));
            Console.ReadKey();
        }
        private static float Add(float num1,float num2)
        {
            return num1 + num2;
        }
        public static void takeawaytask2()
        {
            int lilly_age,toys_price;
            float priceofWashingMachine;
            Console.Write("Enter Age of Lilly: ");
            lilly_age = int.Parse(Console.ReadLine());
            Console.Write("Enter Price of Washing Machine: ");
            priceofWashingMachine = float.Parse(Console.ReadLine());
            Console.Write("Enter Price  of Toy :  ");
            toys_price = int.Parse(Console.ReadLine());
            int brotherAmount = 0,toycount=0,lillymoney=0,increment=10;
            for (int x = 1; x <= lilly_age; x++)
            {
                if (x % 2 != 0)
                {
                    toycount++;
                }
                else if (x % 2 == 0)
                {
                    lillymoney = lillymoney + increment;
                    increment =increment + 10;
                    brotherAmount++;
                    lillymoney--;
                }
            }
            int priceofAll=toycount* toys_price;
            lillymoney=priceofAll + lillymoney;
            
            if (lillymoney >= priceofWashingMachine)
            {
                float finallillymoney = (float)lillymoney - priceofWashingMachine;
                Console.WriteLine("Yes !...." + finallillymoney);
            }
            else
            {
                float reqamount = priceofWashingMachine - (float)lillymoney;
                Console.WriteLine("No!....."+ reqamount);
            }
            Console.ReadKey();
        }
        public static void manual3task1()
        {
            string path = "E:\\2nd Semester\\OOP\\Lab 1\\hello.txt";
            if (File.Exists(path))
            {
                StreamReader fileVariable = new StreamReader(path);
                string record;
                while((record=fileVariable.ReadLine()) != null)
                {
                    Console.WriteLine(record);
                }
                fileVariable.Close();
            }
            else
            {
                Console.WriteLine("Not Exists ");
            }
            
        }
    }
}

