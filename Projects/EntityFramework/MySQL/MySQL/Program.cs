using Microsoft.EntityFrameworkCore.Migrations.Operations;

namespace MySQL;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        InsertData();

        PrintData();

        Console.ReadLine();
    }

   

    private static void InsertData()
    {
        using (var context = new CustomerContext())
        {
            try
            {
                // Creates the database if not exists
                context.Database.EnsureCreated();

                // Adds a customer
                var customer = new Customer
                {
                    Id = 1,
                    Name = "John Doe",
                    Address = "123 Main St",
                    City = "New York"
                };
                try
                {
                    context.Customers.Add(customer);
                }catch(Exception e)
                {
                    Console.WriteLine(e.Message);
                }

                var customer1 = new Customer
                {
                    Id = 2,
                    Name = "Pankaj Mishra",
                    Address = "123 Main St",
                    City = "Dubai"
                };

                context.Customers.Add(customer1);

                context.SaveChanges();
            }catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
    private static void PrintData()
    {
        using (var context = new CustomerContext())
        {
            var customers = context.Customers.ToList();
            foreach (var customer in customers)
            {
                Console.WriteLine($"Id: {customer.Id}, Name: {customer.Name}, Address: {customer.Address}, City: {customer.City}");
            }
        }
    }
}