using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class CustomerManager
    {
      
        public void Add(Customer customer)
        {
            Console.WriteLine("customer eklendi");
        }

        public void Delete(Customer customer)
        {
            Console.WriteLine("customer silindi");
        }

        public void List(Customer[] customers)
        {
            foreach (var customer in customers)
            {
                Console.WriteLine("Custumer id : " + customer.Id);
                Console.WriteLine("Customer name : " + customer.FirstName);
                Console.WriteLine("Customer last name : " + customer.LastName);
                Console.WriteLine("Customer TC kimlik no : " + customer.TcNo);
                Console.WriteLine("Şehir : " + customer.City);
                Console.WriteLine("--------------------------------------");
            }
        }
    }
}
