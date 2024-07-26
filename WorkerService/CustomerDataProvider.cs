using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkerService.Model;

namespace WorkerService
{
    public class CustomerDataProvider
    {
        public List<Customer> GetCustomerData()
        {
            // Simulated customer data
            return new List<Customer>
            {
                new Customer { Name = "John Doe", Age = 30 },
                new Customer { Name = "Jane Smith", Age = 25 }
            };
        }
    }
}
