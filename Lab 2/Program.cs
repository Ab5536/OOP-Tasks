using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lab_2
{
    class Program
    {
        //Task 1
        /* 
         class students
         {
             public string name;
             public int roll_no;
             public float cgpa;
         }
         static void Main(string[] args)
         {
             Console.Read();
         }
        */

        //Task 2
        /*
        class students
         {
             public string name;
             public int roll_no;
             public float cgpa;
         }
         static void Main(string[] args)
         {
             students var= new students();
             var.name = "Abdullah Zahid";
             var.roll_no = 3;
             var.cgpa = 3.6F;
             Console.WriteLine("Name: {0} \n Roll No {1}: \n CGPA :{2} ", var.name,var.roll_no,var.cgpa);
             Console.Read();
         }
        */

        //Task 3
        /*
        class students
        {
            public string name;
            public int roll_no;
            public float cgpa;
        }
        static void Main(string[] args)
        {
            students var1 = new students();
            var1.name = "Abdullah Zahid";
            var1.roll_no = 3;
            var1.cgpa = 3.6F;
            Console.WriteLine("Name: {0} \nRoll No: {1} \nCGPA: {2}", var1.name, var1.roll_no, var1.cgpa); 
            students var2 = new students();
            var2.name = "Ahmad Baloch";
            var2.roll_no = 31;
            var2.cgpa = 3.25F;
            Console.WriteLine("Name: {0} \nRoll No: {1} \nCGPA: {2}", var2.name, var2.roll_no, var2.cgpa);
            Console.Read();
        }
        */

        //Task 4
        /*
        class students
         {
             public string name;
             public int roll_no;
             public float cgpa;
         }
       static void Main(string[] args)
         {
             students newvar = new students();
             Console.Write("Enter Your Name: ");
             newvar.name=Console.ReadLine(); 
             Console.Write("Enter Your Roll No: ");
             newvar.roll_no=int.Parse(Console.ReadLine());
             Console.Write("Enter Your CGPA: ");
             newvar.cgpa=float.Parse(Console.ReadLine());
             Console.WriteLine("Name: {0} \nRoll No: {1} \nCGPA: {2}", newvar.name, newvar.roll_no, newvar.cgpa);
             Console.Read();
         }
        */

        //Task 5
        /*
        class students
        {
            public string name;
            public int roll_no;
            public float cgpa;
            public char isHostelide;
            public string department;
        }

        static void Main(string[] args)
        {
            students[] s = new students[10];
            char option;
            int count = 0;
            do
            {
                option = menu();
                if (option == '1')
                {
                    s[count] = addstudent();
                    count = count + 1;
                }
                else if (option == '2')
                {
                    viewstudents(s, count);
                }
                else if (option == '3')
                {
                    topstudents(s, count);
                }
                else if (option == '4')
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid Choice");
                }
            } while (option != 4);
            Console.WriteLine("Press Enter to Exit....");
            Console.Read();
        }
        static char menu()
        {
            Console.Clear();
            Console.WriteLine("Press 1 for Adding a Student\nPress 2 for view Students\nPress 3for top 3 students\npress 4 to Exit");
            char choice = char.Parse(Console.ReadLine());
            return choice;
        }

        static students addstudent()
        {
            Console.Clear();
            students s1 = new students();
            Console.Write("Enter Your Name: ");
            s1.name = Console.ReadLine();
            Console.Write("Enter Your Roll No: ");
            s1.roll_no = int.Parse(Console.ReadLine());
            Console.Write("Enter Your CGPA: ");
            s1.cgpa = float.Parse(Console.ReadLine());
            Console.Write("Enter Your Department: ");
            s1.department = Console.ReadLine();
            Console.Write("Are You HostelLite (Y/N): ");
            s1.isHostelide = char.Parse(Console.ReadLine());
            return s1;
        }
        static void viewstudents(students[] s, int count)
        {
            Console.Clear();
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine("Name: {0} Roll No: {1} CGPA: {2} Department: {3} isHostelide: {4}", s[i].name, s[i].roll_no, s[i].cgpa, s[i].department, s[i].isHostelide);
            }
            Console.WriteLine("Press any Key to Continue");
            Console.ReadKey();
        }
        static void topstudents(students[] s, int count)
        {
            Console.Clear();
            if (count == 0)
            {
                Console.WriteLine("No Record Found");
            }
            else if (count == 1)
            {
                viewstudents(s, 1);
            }
            else if (count == 2)
            {
                for (int x = 0; x < 2; x++)
                {
                    int index = largest(s, x, count);
                    students temp = s[index];
                    s[index] = s[x];
                    s[x] = temp;
                }
                viewstudents(s, 3);
            }
        }
        static int largest(students[] s, int start, int end)
        {
            int index = start;
            float large = s[start].cgpa;
            for (int x = start; x < end; x++)
            {
                if (large < s[x].cgpa)
                {
                    large = s[x].cgpa;
                    index = x;
                }
            }
            return index;
        }
        */
        //Challenge 1
        /*
        class store
        {
            public string ID;
            public string name;
            public int price;
            public string brandName;
            public string country;
            public string Category;
        }
        static void Main(string[] args)
        {
            store[] st = new store[20];
            char option;
            int count = 0;
            do
            {
                option = menu();
                if (option == '1')
                {
                    st[count] = addproduct();
                    count += 1;
                }
                else if (option == '2')
                {
                    viewproducts(st, count);
                }
                else if (option == '3')
                {
                    Console.WriteLine("Total Price: {0}",totalworth(st, count));
                    Console.WriteLine("Press Enter to Exit....");
                    Console.Read();
                }
                else if (option == 4)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid Input");
                }
            } while (option != 4);
            Console.WriteLine("Press Enter to Exit....");
            Console.Read();
        }
        static char menu()
        {
            Console.Clear();
            Console.WriteLine("Press 1 for Adding a Product\nPress 2 for view Products\nPress 3for total Worth\npress 4 to Exit");
            char choice = char.Parse(Console.ReadLine());
            return choice;
        }

        static store addproduct()
        {
            store s1 = new store();
            Console.Write("Enter Product ID: ");
            s1.ID = Console.ReadLine();
            Console.Write("Enter Product Name: ");
            s1.name = Console.ReadLine();
            Console.Write("Enter Product Price: ");
            s1.price = int.Parse(Console.ReadLine());
            Console.Write("Enter product Category: ");
            s1.Category = Console.ReadLine();
            Console.Write("Enter product BrandName: ");
            s1.brandName = Console.ReadLine();
            Console.Write("Enter Country: ");
            s1.country = Console.ReadLine();
            return s1;
        }
        static void viewproducts(store[] sto, int count)
        {
            if (count == 0)
            {
                Console.WriteLine("No Products");
            }
            else
            {
                for (int i = 0; i < count; i++)
                {
                    Console.WriteLine("\n\n\tID: {0}\n\tName: {1}\n\tPrice: {2}\n\tCategory: {3}\n\tBrandName: {4}\n\tCountry: {5}", sto[i].ID, sto[i].name, sto[i].price, sto[i].Category, sto[i].brandName, sto[i].country);
                }
                Console.WriteLine("Press any Key to Continue");
                Console.ReadKey();
            }
        }
        static int totalworth(store[] stor, int count)
        {
            if (count == 0)
            {
                Console.WriteLine("No Products");
                return 0;
            }
            else
            {
                int sum = 0;
                for (int i = 0; i < count; i++)
                {
                    sum = sum + stor[i].price;
                }
                return sum;
            }
        }
        */
        //Challenge 2
        /*
        class credentials
        {
            public string username;
            public string password;
            public string role;
        }
        static void Main(string[] args)
        {
            string path = "E:\\2nd Semester\\file.txt";
            credentials[] user = new credentials[20];
            //int count = 0;
           int count = loaddatafromfile(path,user);
            char option;
            do
            {
                option = menu();
                if (option == '1')
                {
                    credentials temp = new credentials();
                    temp = signup();
                    user[count] = temp;
                    savedatainfile(path, temp);
                    count += 1;
                }
                else if (option == '2')
                {
                    credentials temp = new credentials();
                    temp = signin();
                    Console.WriteLine(checkUser(user, count, temp));
                }
                else if (option == '3')
                {
                    break;
                }
                else 
                {
                    Console.WriteLine("Invalid Input");
                }
            } while (option != 3);
            Console.WriteLine("Press Enter to Exit....");
            Console.Read();
        }
        static char menu()
        {
            Console.WriteLine("Press 1 for Signup\nPress 2 for signin\nPress 3 for Exit");
            char choice = char.Parse(Console.ReadLine());
            return choice;
        }
        static credentials signup()
        {
            credentials newuser = new credentials();
            Console.Write("Enter Username: ");
            newuser.username=Console.ReadLine();
            Console.Write("Enter Password: ");
            newuser.password = Console.ReadLine();
            Console.Write("Enter Role: ");
            newuser.role = Console.ReadLine();
            return newuser;
        }
        static void savedatainfile(string path,credentials temp)
        {
            if (File.Exists(path))
            {
                StreamWriter variable = new StreamWriter(path, true);
                variable.WriteLine(temp.username + "," + temp.password + "," + temp.role);
                variable.Flush();
                variable.Close();
            }
        }
        static int loaddatafromfile(string path,credentials[] user)
        {
            int count = 0;
            StreamReader filevar = new StreamReader(path);
            string data;
            
            if (File.Exists(path))
            {
                while ((data = filevar.ReadLine()) != null)
                {
                    int commacount = 1;
                    user[count] = new credentials();
                    for (int x = 0; x < data.Length; x++)
                    {
                        if (data[x] == ',')
                        {
                            commacount++;
                        }
                        else if (commacount == 1)
                        {
                            user[count].username = user[count].username + data[x];
                        }
                        else if (commacount == 2)
                        {
                            user[count].password = user[count].password + data[x];
                        }
                        else if (commacount == 3)
                        {
                            user[count].role = user[count].role + data[x];
                        }
                    }
                    count++;
                }
                filevar.Close();
                return count;
            }
            else
            {
                return 0;
            }
        }
        static credentials signin()
        {
            credentials olduser = new credentials();
            Console.Write("Enter Username: ");
            olduser.username = Console.ReadLine();
            Console.Write("Enter Password: ");
            olduser.password = Console.ReadLine();
            return olduser;
        }
        static string checkUser(credentials[] user,int count,credentials temp)
        {
            bool flag=false;
            int num=0;
            for(int x = 0; x < count; x++)
            {
                if(temp.username==user[x].username  && temp.password == user[x].password)
                {
                    flag = true;
                    num = x;
                    break;
                }
            }
            if (flag == true)
            {
                return "You signed in succesfully as " + user[num].role;
            }
            else 
            {
                return "You are not a user better Luck next Time";
            }
        }
        */
    }
}

