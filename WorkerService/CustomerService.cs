using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkerService.Model;

namespace WorkerService
{
    public class CustomerService
    {
        public void DisplayCustomerInfo(Customer customer)
        {
            Console.WriteLine($"Name: {customer.Name}, Age: {customer.Age}");
        }
    }
}
