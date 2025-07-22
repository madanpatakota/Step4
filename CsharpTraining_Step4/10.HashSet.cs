using System;
using System.Collections.Generic;
using System.Globalization;


namespace HashSetNamespace
{
   class ExampleHashSet
    {
        static void Main()
        {

            HashSet<int> numbers = new HashSet<int>();
            numbers.Add(10);
            numbers.Add(10);
            numbers.Add(20);
            numbers.Add(30);
            numbers.Add(30);



            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }



            HashSet<string> emails = new HashSet<string>();
            emails.Add("madan@gmail.com");
            emails.Add("madan@gmail.com");
            emails.Add("madan@gmail.com");
            emails.Add("madan1@gmail.com");

            foreach (string email in emails)
            {
                Console.WriteLine("hastable " + email);
            }

            if (emails.Contains("madan@gmail.com"))
            {
                Console.WriteLine("Yes ... mail id is thier");
            }


            emails.Remove("madan1@gmail.com");
            emails.Add("ram@gmail.com");



            //Console.WriteLine("exit");


            List<string> emails1 = new List<string>();
            emails1.Add("madan@gmail.com");
            emails1.Add("madan@gmail.com");
            emails1.Add("madan@gmail.com");
            emails1.Add("madan1@gmail.com");

            foreach (string email in emails1)
            {
                Console.WriteLine("List " + email);
            }

        }
    }
}
