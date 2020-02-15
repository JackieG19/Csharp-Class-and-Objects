using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CsharpFundamentals
{    
    class Program
    {
        static void Main(string[] args)
        {
            //var customer = new Customer(1, "John");
            var customer = new Customer();
            customer.Id = 1;
            customer.Name = "John";
            
            var order = new Order();
            customer.Orders.Add(order);
            
            Console.WriteLine(customer.Id);
            Console.WriteLine(customer.Name);

        }
    }
}
