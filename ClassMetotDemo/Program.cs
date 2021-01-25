using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer();
            customer.Id = 1;
            customer.FirstName = "ismail";
            customer.LastName = "demirel";
            customer.TcNo = "123456";
            customer.City = "Ankara";

            Customer customer1 = new Customer
            {
                Id = 2,
                TcNo = "123456",
                FirstName = "ismail",
                LastName = "demirel",

                City = "Ankara"
            };


            Customer[] customerDizi = new Customer[2];
            customerDizi[0] = customer;
            customerDizi[1] = customer1;        

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer);
            customerManager.Delete(customer);
            Console.WriteLine("listelendi");
            customerManager.List( customerDizi);

        }
    }
}
