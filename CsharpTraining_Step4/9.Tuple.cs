using System;

namespace TupleNamespace
{
    class ExampleTuple
    {

        static void Main()
        {

            //Example basic
            Tuple<int,string, string>  data =  Tuple.Create(1, "John" , "Bangolore");
            Tuple<string> data1 =  Tuple.Create("Banoglore");


            Console.WriteLine(data.Item1);
            Console.WriteLine(data.Item2);
            Console.WriteLine(data1.Item1);

            //return type (int ID , string Name , string Locatoin)

            //Value type tuple
            (int ID , string Name , string Locatoin) student =   (1, "John", "Bangolore");  //Tuple
            Console.WriteLine(student.ID);
            Console.WriteLine(student.Name);
            Console.WriteLine(student.Locatoin);

            //int myID =   getID();
            //Console.WriteLine(myID);
            (int ID, string Name, string Locatoin) refemployee = ExampleTuple.employee();
            Console.WriteLine(refemployee.ID);
            Console.WriteLine(refemployee.Name);
            Console.WriteLine(refemployee.Locatoin);

            //Destructure the tuple


            // i am getting 1 value so now do the actitltiy to set 2 
            int eid = empid();  
            if (eid == 1)
            {
                eid = 2;
            }

            var (id,name,location) = (eid, "John", "Bangolore");  //Tuple
            Console.WriteLine(id);
            Console.WriteLine(name);
            Console.WriteLine(location);

        }



        //return type --> int
        static int getID()
        {
            return 1;
        }


        static (int ID, string Name, string Locatoin) employee()
        {
            int empid = 1;
            string empname = "John";
            string location = "Bangolore";
            return (empid, empname, location);
        }



        /// <summary>
        ///  empid method returns the single value
        /// </summary>
        /// <returns>int</returns>
        static int empid()
        {

            // connecting to the databse 

            // connectiotn to the respecive table

            // get the value

            return 101;
        }


    }
}
