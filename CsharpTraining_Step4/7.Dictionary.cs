using System;
using System.Collections.Generic;

namespace DictionaryNamespace
{


    //Dict we wo't to use term Index -> Key

    //Dictionary<TKey,TValue> dict = new Dictionary<TKey,TValue>();

    class ExampleDict
    {
        static void Main() {

            //Key value pair called dict
            //
            Dictionary<int, string> tableContent = new Dictionary<int, string>();
            tableContent.Add(1,  "Chapter1");
            tableContent.Add(7,  "Chapter2");
            tableContent.Add(21, "Chapter3");

            //output
            //Key is important to get the value
            string nameOfChapter1 =  tableContent[1]; //think logic
            string nameOfChapter2 =  tableContent[7]; //think logic
            string nameOfChapter3 =  tableContent[21]; //think logic


            if (tableContent.ContainsKey(7))  //checking that table contains is the 7 or not.
            {
                Console.WriteLine("Yeah 7 is avaible");
            }


            tableContent.Remove(21);  //remve 21 key  //-D


            tableContent.Add(37, "Chapter4");  //Add - C


            if (tableContent.ContainsKey(7))  //checking that table contains is the 7 or not.
            {
                tableContent[7] = "Chapter 1.1.";   //update  - U
                //Console.WriteLine("Yeah 7 is avaible");
            }


            //LambdaExpressions =>

            foreach (KeyValuePair<int, string> kvp in tableContent) 
            {
                Console.WriteLine($"Key is {kvp.Key}");    // -R
                Console.WriteLine($"Value is {kvp.Value}"); //-R
            }



        }
    }
}