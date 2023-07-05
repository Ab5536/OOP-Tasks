using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab_4_task_3.BL;

namespace Lab_4_task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Customer> customers = new List<Customer>();
            int option;
            do
            {
                option = Menu();
                if (option == 1)
                {
                    Customer cust = takenewcustomer();               
                        Console.Write("Enter the number of Products Customer Bought(minimum 1): ");
                        int num = int.Parse(Console.ReadLine());
                        if (num < 1)
                        {
                          Console.WriteLine("Products cannot be Zero");
                          continue;
                        }
                    Console.Clear();
                    for (int i = 0; i < num; i++)
                    {
                        Product pr = takenewProduct();
                        cust.addProduct(pr);
                    }
                    customers.Add(cust);
                }
                else if (option == 2)
                {
                    Customer cust = checkCustomer(customers);
                    if (cust != null)
                    {
                        Console.Clear();
                        List<Product> products = cust.getAllproducts();
                        viewproducts(cust, products);
                    }
                    else
                    {
                        Console.WriteLine("Custometr Not Found");
                    }
                }
                else if (option == 3)
                {
                    Console.Clear();
                    Customer cust = checkCustomer(customers);
                    if (cust != null)
                    {
                        //float totalprice = 0;
                       // float totaltax = 0;
                        List<Product> products = cust.getAllproducts();
                        foreach (Product p in products)
                        {
                            //totalprice = totalprice + p.Price*100;
                            float tax = p.calculateTax();
                            Console.WriteLine("Name of Product: {0}\nCategory of Product: {1}\nPrice of Product: {2}\nTax: {3}%", p.Name, p.Category, p.Price, tax);
                            //totaltax = totaltax + tax;
                        }                     
                        //Console.WriteLine()

                    }
                    else
                    {
                        Console.WriteLine("Custometr Not Found");
                    }
                }
                else if (option == 4)
                {
                    break;
                } 

            } while (option != 4);
        }

        private static void viewproducts(Customer cust,List<Product> products)
        { 
            foreach (Product p in products)
            {
                Console.WriteLine("Name of Product: {0}\nCategory of Product: {1}\nPrice of Product: {2}", p.Name, p.Category, p.Price);
            }
        }

        public static Customer checkCustomer(List<Customer> customers)
        {
            Console.Write("Enter the Name of Customer: ");
            string name = Console.ReadLine();
            foreach (Customer cust in customers)
            {
                if (cust.CustomerName == name)
                {
                    return cust;
                }
            }
            return null;
        }

        public static int Menu()
        {
            Console.WriteLine("1. Enter information of Customer ");
            Console.WriteLine("2. Total Purchased Products of Customer");
            Console.WriteLine("3. Calculate Tax");
            Console.WriteLine("4. Exit");
            Console.Write("Your Choice: ");
            int option = int.Parse(Console.ReadLine());
            return option;
        }
        public static Customer takenewcustomer()
        {
            Console.Write("Enter Customer name: ");
            string customerName = Console.ReadLine();
            Console.Write("Enter Customer's contact number: ");
            string customerContact = Console.ReadLine();
            Console.Write("Enter Customer's Address: ");
            string custmerAdress = Console.ReadLine();
            Customer cust = new Customer(customerName, customerContact, custmerAdress);
            return cust;
        }
        public static Product takenewProduct()
        {            
            Console.Write("Enter Product Name: ");
            string Name = Console.ReadLine();
            Console.Write("Enter Product Category: ");
            string Category = Console.ReadLine();
            Console.Write("Enter Product Price: ");
            int Price = int.Parse(Console.ReadLine());
            Product pr= new Product(Name,Category,Price);
            return pr;
        }
    }
}
