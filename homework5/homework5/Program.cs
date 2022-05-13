using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace homework5
{
    
    
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                customer customer1 = new customer(1,"customer1");
                customer customer2 = new customer(2, "customer2");
                customer customer3 = new customer(3, "customer3");

                good good1 = new good(1, "good1", 1.23);
                good good2 = new good(2, "good2", 4.56);
                good good3 = new good(3, "good3", 7.89);

                Order order1 = new Order(1,customer1);
                Order order2 = new Order(2, customer2);

                order1.addDetails(new orderDetails(good1, 5));
                order2.addDetails(new orderDetails(good2, 5));

                orderService orderService1 = new orderService();
                orderService1.addOrder(order1);
                orderService1.addOrder(order2);

                Console.WriteLine("\n GetById");
                Console.WriteLine(orderService1.GetById(1));
                Console.WriteLine(orderService1.GetById(5));

            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
