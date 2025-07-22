using CustomerManagement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectCode
{
    internal class CustomerArrayExample
    {

        public Customer[] customers;
        public int count;

        public CustomerArrayExample(int size)
        {
            customers = new Customer[size];
            count = 0;
        }
        //Add new customer

        /// <summary>
        /// Add Customer
        /// </summary>
        /// <param name="customer"></param>
        public void AddCustomer(Customer customer)
        {
            if (count < customers.Length)
            {
                customers[count] = customer;
                count++;
            }
            else
            {
                Console.WriteLine("Array is full. Cannot add more customers.");
            }
        }
        /// <summary>
        /// Update Customer
        /// </summary>
        /// <param name="customer"></param>
        public void UpdateCustomer(Customer customer)
        {
            for (int i = 0; i < count; i++)
            {
                if (customers[i].Id == customer.Id)
                {
                    customers[i] = customer;
                    return;
                }
            }
            Console.WriteLine("Customer not found.");
        }
        /// <summary>
        /// Check if Customer Exists
        /// </summary>
        /// <param name="customerId"></param>
        /// <returns></returns>
        public bool CustomerExists(int customerId)
        {
            for (int i = 0; i < count; i++)
            {
                if (customers[i].Id == customerId)
                {
                    return true;
                }
            }
            return false;
        }








    }
    internal class Program
    {
        static void Main(string[] args)
        {
            CustomerArrayExample customerArray = new CustomerArrayExample(3);

            Customer customer1 = new Customer(1, "John Doe", "john@example.com", "123-456-7890");
            Customer customer2 = new Customer(2, "Jane Smith", "jane@example.com", "098-765-4321");
            Customer customer3 = new Customer(3, "Jim Brown", "jim@example.com", "555-555-5555");
            Customer customer4 = new Customer(4, "Jake Blues", "jake@example.com", "444-444-4444");

            customerArray.AddCustomer(customer1);
            customerArray.AddCustomer(customer2);
            customerArray.AddCustomer(customer3);
            customerArray.AddCustomer(customer4); // This should print "Array is full. Cannot add more customers."

            // Update customer2's information
            Customer updatedCustomer2 = new Customer(2, "Jane Doe", "jane.doe@example.com", "098-765-4321");
            customerArray.UpdateCustomer(updatedCustomer2);

            // Check if a customer exists
            bool exists = customerArray.CustomerExists(2);
            Console.WriteLine($"Customer with ID 2 exists: {exists}");
        }
    }
}



/*
/// <summary>
/// This code demonstrates a simple array-based customer management system.
/// 
/// Key components:
/// 1. CustomerArrayExample Class:
///    - Manages an array of Customer objects.
///    - Provides methods to add, update, and check the existence of customers.
/// 
/// 2. Methods:
///    - AddCustomer: Adds a new customer to the array if there is space.
///    - UpdateCustomer: Updates an existing customer's information based on their ID.
///    - CustomerExists: Checks if a customer with a given ID exists in the array.
/// 
/// 3. Program Class:
///    - Contains the Main method, which is the entry point of the application.
///    - Demonstrates the usage of CustomerArrayExample by creating customers and performing add, update, and existence check operations.
/// 
/// 4. Customer Class:
///    - Represents a customer with properties Id, Name, Email, and Phone.
///    - Includes a constructor to initialize these properties and an overridden ToString method.
/// 
/// The code is written in C# version 7.3 and targets .NET Framework 4.7.2.
/// </summary>
 */