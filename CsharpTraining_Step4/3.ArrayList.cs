using System;
using System.Collections;

namespace ArrayListNamespace
{
    class ExampleArrayList
    {
        static void Main()
        {
            ArrayList arrayList = new ArrayList();

            // 1. Not-TypesSafety
            arrayList.Add(10);
            arrayList.Add(20);
            arrayList.Add("Hello");
            arrayList.Add(false);

            //Print Console.writeline


            //2. ArrayList Dynamic Size.  
            arrayList.Add(10);       // 0   object 
            arrayList.Add(20);       // 1   object
            arrayList.Add("Hello");  // 2  //object
            arrayList.Add(false);    // 3  //object
            arrayList.Add(20);       // 4  //object
            
            //object to  Expected datatyps
            //Boxing and UnBoxing
            int first = (int)arrayList[0];  //Unboxing
            string second = (string)arrayList[2]; //unbsning



            // 4. multiple datatypes are possible

            ArrayList arrayList1  = new ArrayList();
            arrayList1.Add(10);
            arrayList1.Add(20);
            arrayList1.Add("Hello");
            arrayList1.Add(false);


            //5.Looping
            foreach(object x in arrayList1)
            {
                //int third = (int)x;
                Console.WriteLine(x);
            }


            //var x = 10;
            //x = "hello";


            //object obj = 10;
            //obj = "hello";
            //obj.
            //object obj1 = "afad";



            //Performance

            ArrayList arrayList1000items = new ArrayList();
            for(int i = 0; i < 1000; i++)
            {
                arrayList1000items.Add(i);  //object
            }



          //________ obj  = arrayList1000items[10]



        }

    }
}
