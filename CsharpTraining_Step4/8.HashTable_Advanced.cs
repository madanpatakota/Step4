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
    internal class CustomerHashTableExample
    {
        // Hashtable to store Customer objects with their ID as the key
        public Hashtable customers;

        // Constructor to initialize the Hashtable
        public CustomerHashTableExample()
        {
            customers = new Hashtable();
        }

        /// <summary>
        /// Add Customer
        /// </summary>
        /// <param name="customer"></param>
        public void AddCustomer(Customer customer)
        {
            // Add a new customer to the Hashtable
            customers[customer.Id] = customer;
        }

        /// <summary>
        /// Update Customer
        /// </summary>
        /// <param name="customer"></param>
        public void UpdateCustomer(Customer customer)
        {
            // Update the customer information
            if (customers.ContainsKey(customer.Id))
            {
                customers[customer.Id] = customer;
            }
            else
            {
                Console.WriteLine("Customer not found.");
            }
        }

        /// <summary>
        /// Check if Customer Exists
        /// </summary>
        /// <param name="customerId"></param>
        /// <returns></returns>
        public bool CustomerExists(int customerId)
        {
            // Check if a customer with the given ID exists
            return customers.ContainsKey(customerId);
        }

        /// <summary>
        /// Remove Customer
        /// </summary>
        /// <param name="customerId"></param>
        public void RemoveCustomer(int customerId)
        {
            // Remove the customer by ID
            if (!customers.ContainsKey(customerId))
            {
                Console.WriteLine("Customer not found.");
            }
            else
            {
                customers.Remove(customerId);
            }
        }

        /// <summary>
        /// Get Customer by ID
        /// </summary>
        /// <param name="customerId"></param>
        /// <returns></returns>
        public Customer GetCustomerById(int customerId)
        {
            // Find the customer by ID
            if (customers.ContainsKey(customerId))
            {
                return (Customer)customers[customerId];
            }
            Console.WriteLine("Customer not found.");
            return null;
        }
    }

    internal class HashTableProgram
    {
        static void Main(string[] args)
        {
            // Create an instance of CustomerHashTableExample
            CustomerHashTableExample customerHashTable = new CustomerHashTableExample();

            // Create some Customer objects
            Customer customer1 = new Customer(1, "John Doe", "john@example.com", "123-456-7890");
            Customer customer2 = new Customer(2, "Jane Smith", "jane@example.com", "098-765-4321");
            Customer customer3 = new Customer(3, "Jim Brown", "jim@example.com", "555-555-5555");
            Customer customer4 = new Customer(4, "Jake Blues", "jake@example.com", "444-444-4444");

            // Add customers to the Hashtable
            customerHashTable.AddCustomer(customer1);
            customerHashTable.AddCustomer(customer2);
            customerHashTable.AddCustomer(customer3);
            customerHashTable.AddCustomer(customer4);

            // Update customer2's information
            Customer updatedCustomer2 = new Customer(2, "Jane Doe", "jane.doe@example.com", "098-765-4321");
            customerHashTable.UpdateCustomer(updatedCustomer2);

            // Check if a customer exists
            bool exists = customerHashTable.CustomerExists(2);
            Console.WriteLine($"Customer with ID 2 exists: {exists}");

            // Remove customer3
            customerHashTable.RemoveCustomer(3);

            // Get customer by ID
            Customer customer = customerHashTable.GetCustomerById(4);
            if (customer != null)
            {
                Console.WriteLine($"Customer with ID 4: {customer.Name}, {customer.Email}, {customer.Phone}");
            }
        }
    }
}

/// <summary>
/// This code demonstrates a simple Hashtable-based customer management system.
/// 
/// Key components:
/// 1. CustomerHashTableExample Class:
///    - Manages a Hashtable of Customer objects.
///    - Provides methods to add, update, check the existence of, remove, and retrieve customers.
/// 
/// 2. Methods:
///    - AddCustomer: Adds a new customer to the Hashtable.
///    - UpdateCustomer: Updates an existing customer's information based on their ID.
///    - CustomerExists: Checks if a customer with a given ID exists in the Hashtable.
///    - RemoveCustomer: Removes a customer from the Hashtable based on their ID.
///    - GetCustomerById: Retrieves a customer from the Hashtable based on their ID.
/// 
/// 3. HashTableProgram Class:
///    - Contains the Main method, which is the entry point of the application.
///    - Demonstrates the usage of CustomerHashTableExample by creating customers and performing add, update, existence check, remove, and retrieve operations.
/// 
/// 4. Customer Class:
///    - Represents a customer with properties Id, Name, Email, and Phone.
///    - Includes a constructor to initialize these properties and an overridden ToString method.
/// 
/// The code is written in C# version 7.3 and targets .NET Framework 4.7.2.
/// </summary>