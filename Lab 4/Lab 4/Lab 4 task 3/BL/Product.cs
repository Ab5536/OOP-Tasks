using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4_task_3.BL
{
    class Product
    {
        public string Name;
        public string Category;
        public int Price;
        public Product(string Name,string Category,int Price)
        {
            this.Name = Name;
            this.Category = Category;
            this.Price = Price;
        }
        public float calculateTax()
        {
            float tax = 0;
            string category = Category.ToLower();
            if (category == "fruit")
            {
                tax = Price * (10.0f / 100.0f);
            }
            else if (category == "grocery")
            {
                tax = Price * (5.0f / 100.0f);
            }
            return tax;

        }
    }
}
