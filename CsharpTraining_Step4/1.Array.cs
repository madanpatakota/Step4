using System;


namespace ArraysCode
{
    //Type Safety

    class ArrayExample
    {
        static void Main()
        {

            // 1. TypesSafety
            int[] arr = new int[2];  // Array with Int
            arr[0] = 10;  //as the Integer
            arr[1] = 20;


            //2. Array Fixed Size.
            int[] arr1 = new int[2];  // Array with Int
            arr[0] = 10;
            arr[1] = 20;
            //arr[2] = 30;  //Index Out of Range Exception

            
            //No Boxing
            int Third = arr[0];  //10


            //4.Multidata Types not possible
            int[] arr2 = new int[2];
            //arr2[0] = false;
            //arr2[1] = "Hello";


            //5.Looping
            int[] arr3 = new int[4];
            arr3[0] = 10;
            arr3[1] = 20;
            arr3[2] = 30;
            arr3[3] = 40;

            foreach(int x in arr3){
                Console.WriteLine(x);
            }

        }
    }



}
