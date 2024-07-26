using WorkerService;
using WorkerService.Model;

var builder = Host.CreateApplicationBuilder(args);
//builder.Services.AddHostedService<Worker>();
var dataProvider = new CustomerDataProvider();
var customerService = new CustomerService();

// Get customer data
List<Customer> customers = dataProvider.GetCustomerData();

// Process each customer
foreach (var customer in customers)
{
    customerService.DisplayCustomerInfo(customer);
}
var host = builder.Build();
host.Run();
