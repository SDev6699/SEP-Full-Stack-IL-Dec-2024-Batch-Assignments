using System;

namespace GenericRepositoryApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create repositories for Product and Customer
            IRepository<Product> productRepository = new GenericRepository<Product>();
            IRepository<Customer> customerRepository = new GenericRepository<Customer>();

            // Add Products
            Product product1 = new Product { Name = "Laptop", Price = 1500.00m };
            Product product2 = new Product { Name = "Smartphone", Price = 800.00m };
            productRepository.Add(product1);
            productRepository.Add(product2);

            // Add Customers
            Customer customer1 = new Customer { FirstName = "Alice", LastName = "Johnson" };
            Customer customer2 = new Customer { FirstName = "Bob", LastName = "Smith" };
            customerRepository.Add(customer1);
            customerRepository.Add(customer2);

            // Save changes
            productRepository.Save();
            customerRepository.Save();

            Console.WriteLine("\nAll Products:");
            foreach(var product in productRepository.GetAll())
            {
                Console.WriteLine(product);
            }

            Console.WriteLine("\nAll Customers:");
            foreach(var customer in customerRepository.GetAll())
            {
                Console.WriteLine(customer);
            }

            // Get Product by Id
            int searchId = 1;
            Product foundProduct = productRepository.GetById(searchId);
            Console.WriteLine($"\nProduct with Id {searchId}: {foundProduct}");

            // Remove a Customer
            customerRepository.Remove(customer1);
            customerRepository.Save();

            Console.WriteLine("\nAll Customers after removal:");
            foreach(var customer in customerRepository.GetAll())
            {
                Console.WriteLine(customer);
            }
        }
    }
}