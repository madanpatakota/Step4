using System;
using System.Collections;
using System.Collections.Generic;


namespace ListNamespace
{


    //List<T> tList = new List<T>();
    class ExampleList
    {

        static void Main()
        {
            List<int> numbersList = new List<int>();
            
            //1.Type-Safety
            numbersList.Add(10);
            numbersList.Add(20);
            numbersList.Add(30);
            numbersList.Add(40);
            numbersList.Add(50);

            //2.Dynamic Size
            //List<int> numbersList1 = new List<int>();
            numbersList.Add(10);
            numbersList.Add(20);
            numbersList.Add(30);
            numbersList.Add(40);
            numbersList.Add(50);
            numbersList.Add(60);


            //No Boxing
            int first = numbersList[0];


            //numbersList  values 10 , 20 , 30 , 40 , 50 , 10 ,20 , 30 , 40 , 50


            // 4. multiple datatypes are not possible
            //numbersList.Add(false);
            //numbersList.Add("Hello");

            //5.Looping
            foreach (int x in numbersList)
            {
                int third = x;
                Console.WriteLine(x);
            }

            //6.Performance

            List<int> list1000items = new List<int>();
            for (int i = 0; i < 1000; i++)
            {
                list1000items.Add(i);  //int  noboxing
            }


            int y = list1000items[0];


        }


    }


}



// Practice will make you perfect developer....
// Practice and discuss
