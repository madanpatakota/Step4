using System;
using System.Collections;


namespace HashTableNamesapce
{

    //Key is unque and value can be duplicate
    class ExampleHashTable
    {
        static void Main()
        {

            //Unique not duplicate key


            //Keyvalue pair and its non-generic type
            Hashtable ht  = new Hashtable();
            ht.Add("Madan", "7204185064");
			//ht.Add("Madan", "1233333333"); // runtime exeption
			ht.Add(101, "Employee id with 101");
            ht.Add("Salary", 10000);


            string phonenum = (string)ht["Madan"];
            string descripiton = (string)ht[101];
            int salary = (int)ht["Salary"];


            //unboxing   

            //Update
            ht[101] = "Employee id with 101 is availble in Ban";


            //remove
            ht.Remove("Salary");


            //Add
            ht.Add("IsActive", true);


			foreach (DictionaryEntry entry in ht)
            {
                Console.WriteLine($"Key - {entry.Key}  ,  Value - {entry.Value}");

            }


            if (ht.ContainsKey(101))
            {
                Console.WriteLine( ht[101] + " Availble");
			}

        }
   
    

        //static void Getvalues()
        //{

        //}

        //static void AddItem(DictionaryEntry entry)
        //{

        //}

        //static void RemoveItem(dynamic key)
        //{

        //}



        //LastRecord
        //100 

        //101 , ""

        //static void UpdateItem(string key)
        //{

        //}
    
    
    }
}
