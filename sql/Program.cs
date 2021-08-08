using System;
using System.Collections.Generic;
using System.Linq;

namespace sql
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Customer> customerList = new List<Customer>();
            customerList.Add(new Customer("eden", "springfield", 10));
            customerList.Add(new Customer("eden", "springfield", 12));
            customerList.Add(new Customer("daddy", "springfield", 15));
            customerList.Add(new Customer("mommy", "woodbridge", 11));
            Console.WriteLine("Hello World!");

            var sqlQuery = (from temp in customerList where temp.city == "springfield" && temp.name=="eden" orderby temp.age select temp);
            foreach (var item in sqlQuery)
            {
                Console.WriteLine(item.age);
            }
            for (int i = 0; i < 10; i++)
            {
                Customer y = new Customer("eden", "home", 19);
            }
        }
    }
    class Customer
    {
        public string name;
        public string city;
        public int age;
        public Customer(string name, string city, int age)
        {
            this.name = name;
            this.city = city;
            this.age = age;
        }
    }
}
