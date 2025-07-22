
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
    internal class CustomerArrayListExample
    {
        // ArrayList to store Customer objects
        public ArrayList customers;

        // Constructor to initialize the ArrayList
        public CustomerArrayListExample()
        {
            customers = new ArrayList();
        }

        /// <summary>
        /// Add Customer
        /// </summary>
        /// <param name="customer"></param>
        public void AddCustomer(Customer customer)
        {
            // Add a new customer to the ArrayList
            customers.Add(customer);
        }

        /// <summary>
        /// Update Customer
        /// </summary>
        /// <param name="customer"></param>
        public void UpdateCustomer(Customer customer)
        {
            // Iterate through the ArrayList to find the customer by ID
            for (int i = 0; i < customers.Count; i++)
            {
                // Check if the current customer's ID matches the provided customer's ID


                //The type cast((Customer)customers[i]) converts the object at customers[i] into a Customer object.
                //Without casting, we cannot directly access properties like Id because object does not have any of these members.
                if (((Customer)customers[i]).Id == customer.Id)
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
            // Iterate through the ArrayList to check if a customer with the given ID exists
            foreach (Customer customer in customers)
            {
                if (customer.Id == customerId)
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
            // Iterate through the ArrayList to find the customer by ID
            for (int i = 0; i < customers.Count; i++)
            {

                //The type cast((Customer)customers[i]) converts the object at customers[i] into a Customer object.
                //Without casting, we cannot directly access properties like Id because object does not have any of these members.
                if (((Customer)customers[i]).Id == customerId)
                {
                    // Remove the customer from the ArrayList
                    customers.RemoveAt(i);
                    return;
                }
            }
            // If customer is not found, print a message
            Console.WriteLine("Customer not found.");
        }

        /// <summary>
        /// Get Customer by ID
        /// </summary>
        /// <param name="customerId"></param>
        /// <returns></returns>
        public Customer GetCustomerById(int customerId)
        {
            // Iterate through the ArrayList to find the customer by ID
            foreach (Customer customer in customers)
            {
                if (customer.Id == customerId)
                {
                    return customer;
                }
            }
            // If customer is not found, print a message and return null
            Console.WriteLine("Customer not found.");
            return null;
        }
    }

    internal class ArrayListProgram
    {
        static void Main(string[] args)
        {
            // Create an instance of CustomerArrayListExample
            CustomerArrayListExample customerArray = new CustomerArrayListExample();

            // Create some Customer objects
            Customer customer1 = new Customer(1, "John Doe", "john@example.com", "123-456-7890");
            Customer customer2 = new Customer(2, "Jane Smith", "jane@example.com", "098-765-4321");
            Customer customer3 = new Customer(3, "Jim Brown", "jim@example.com", "555-555-5555");
            Customer customer4 = new Customer(4, "Jake Blues", "jake@example.com", "444-444-4444");

            // Add customers to the ArrayList
            customerArray.AddCustomer(customer1);
            customerArray.AddCustomer(customer2);
            customerArray.AddCustomer(customer3);
            customerArray.AddCustomer(customer4);

            // Update customer2's information
            Customer updatedCustomer2 = new Customer(2, "Jane Doe", "jane.doe@example.com", "098-765-4321");
            customerArray.UpdateCustomer(updatedCustomer2);

            // Check if a customer exists
            bool exists = customerArray.CustomerExists(2);
            Console.WriteLine($"Customer with ID 2 exists: {exists}");

            // Remove customer3
            customerArray.RemoveCustomer(3);

            // Get customer by ID
            Customer customer = customerArray.GetCustomerById(4);
            if (customer != null)
            {
                Console.WriteLine($"Customer with ID 4: {customer.Name}, {customer.Email}, {customer.Phone}");
            }
        }
    }
}



/*
/// <summary>
/// This code demonstrates a simple ArrayList-based customer management system.
/// 
/// Key components:
/// 1. CustomerArrayListExample Class:
///    - Manages an ArrayList of Customer objects.
///    - Provides methods to add, update, check the existence of, remove, and retrieve customers.
/// 
/// 2. Methods:
///    - AddCustomer: Adds a new customer to the ArrayList.
///    - UpdateCustomer: Updates an existing customer's information based on their ID.
///    - CustomerExists: Checks if a customer with a given ID exists in the ArrayList.
///    - RemoveCustomer: Removes a customer from the ArrayList based on their ID.
///    - GetCustomerById: Retrieves a customer from the ArrayList based on their ID.
/// 
/// 3. ArrayListProgram Class:
///    - Contains the Main method, which is the entry point of the application.
///    - Demonstrates the usage of CustomerArrayListExample by creating customers and performing add, update, existence check, remove, and retrieve operations.
/// 
/// 4. Customer Class:
///    - Represents a customer with properties Id, Name, Email, and Phone.
///    - Includes a constructor to initialize these properties and an overridden ToString method.
/// 
/// The code is written in C# version 7.3 and targets .NET Framework 4.7.2.
/// </summary>
 */