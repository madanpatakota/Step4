using CustomerManagement;
using System;
using System.CodeDom;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectCode
{

    internal class CustomerListExample
    {
        // List to store Customer objects
        private List<Customer> customers;

        // Constructor to initialize the List
        public CustomerListExample()
        {
            customers = new List<Customer>();
        }

        /// <summary>
        /// Add Customer
        /// </summary>
        /// <param name="customer"></param>
        public void AddCustomer(Customer customer)
        {
            // Add a new customer to the List
            customers.Add(customer);
        }

        /// <summary>
        /// Update Customer
        /// </summary>
        /// <param name="customer"></param>
        public void UpdateCustomer(Customer customer)
        {
            // Find the customer by ID
            for (int i = 0; i < customers.Count; i++)
            {
                if (customers[i].Id == customer.Id)
                {
                    // Update the customer information
                    customers[i] = customer;
                    return;
                }
            }
            // If customer is not found, print a message
            Console.WriteLine("Customer not found.");
        }

        /// <summary>
        /// Check if Customer Exists
        /// </summary>
        /// <param name="customerId"></param>
        /// <returns></returns>
        public bool CustomerExists(int customerId)
        {
            // Check if a customer with the given ID exists
            for (int i = 0; i < customers.Count; i++)
            {
                if (customers[i].Id == customerId)
                {
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// Remove Customer
        /// </summary>
        /// <param name="customerId"></param>
        public void RemoveCustomer(int customerId)
        {
            // Find the customer by ID and remove it
            for (int i = 0; i < customers.Count; i++)
            {
                if (customers[i].Id == customerId)
                {
                    customers.RemoveAt(i);
                    return;
                }
            }
            Console.WriteLine("Customer not found.");
        }

        /// <summary>
        /// Get Customer by ID
        /// </summary>
        /// <param name="customerId"></param>
        /// <returns></returns>
        public Customer GetCustomerById(int customerId)
        {
            // Find the customer by ID
            for (int i = 0; i < customers.Count; i++)
            {
                if (customers[i].Id == customerId)
                {
                    return customers[i];
                }
            }
            // If customer is not found, print a message
            Console.WriteLine("Customer not found.");
            return null;
        }
    }

    internal class ListProgram
    {
        static void Main(string[] args)
        {
            // Create an instance of CustomerListExample
            CustomerListExample customerList = new CustomerListExample();

            // Create some Customer objects
            Customer customer1 = new Customer(1, "John Doe", "john@example.com", "123-456-7890");
            Customer customer2 = new Customer(2, "Jane Smith", "jane@example.com", "098-765-4321");
            Customer customer3 = new Customer(3, "Jim Brown", "jim@example.com", "555-555-5555");
            Customer customer4 = new Customer(4, "Jake Blues", "jake@example.com", "444-444-4444");

            // Add customers to the List
            customerList.AddCustomer(customer1);
            customerList.AddCustomer(customer2);
            customerList.AddCustomer(customer3);
            customerList.AddCustomer(customer4);

            // Update customer2's information
            Customer updatedCustomer2 = new Customer(2, "Jane Doe", "jane.doe@example.com", "098-765-4321");
            customerList.UpdateCustomer(updatedCustomer2);

            // Check if a customer exists
            bool exists = customerList.CustomerExists(2);
            Console.WriteLine($"Customer with ID 2 exists: {exists}");

            // Remove customer3
            customerList.RemoveCustomer(3);

            // Get customer by ID
            Customer customer = customerList.GetCustomerById(4);
            if (customer != null)
            {
                Console.WriteLine($"Customer with ID 4: {customer.Name}, {customer.Email}, {customer.Phone}");
            }
        }
    }
}


/*
/// <summary>
/// This code demonstrates a simple List-based customer management system.
/// 
/// Key components:
/// 1. CustomerListExample Class:
///    - Manages a List of Customer objects.
///    - Provides methods to add, update, check the existence of, remove, and retrieve customers.
/// 
/// 2. Methods:
///    - AddCustomer: Adds a new customer to the List.
///    - UpdateCustomer: Updates an existing customer's information based on their ID.
///    - CustomerExists: Checks if a customer with a given ID exists in the List.
///    - RemoveCustomer: Removes a customer from the List based on their ID.
///    - GetCustomerById: Retrieves a customer from the List based on their ID.
/// 
/// 3. ListProgram Class:
///    - Contains the Main method, which is the entry point of the application.
///    - Demonstrates the usage of CustomerListExample by creating customers and performing add, update, existence check, remove, and retrieve operations.
/// 
/// 4. Customer Class:
///    - Represents a customer with properties Id, Name, Email, and Phone.
///    - Includes a constructor to initialize these properties and an overridden ToString method.
/// 
/// The code is written in C# version 7.3 and targets .NET Framework 4.7.2.
/// </summary>
 */