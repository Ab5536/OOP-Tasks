using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4_task_3.BL
{
    class Customer
    {
        public string CustomerName;
        public string CustomerAddress;
        public string CustomerContact;
        public List<Product> products = new List<Product>();
        public Customer(string CustomerName, string CustomerAddress, string CustomerContact)
        {
            this.CustomerName = CustomerName;
            this.CustomerAddress = CustomerAddress;
            this.CustomerContact = CustomerContact;
        }
        public List<Product> getAllproducts()
        {
            return products;
        }
        public void addProduct(Product p)
        {
            products.Add(p);
        }
    }
}
