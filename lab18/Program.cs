using System;
using System.Collections.Generic;
using System.Text;

namespace lab18
{
    class Program
 {

        static void Main(string[] args)
        {
            var list = new List(10);

            list.Insert("one");
            list.Insert("two");
            list.Insert("three");
            list.Insert("four");
            list.Insert("five");
            list.Insert("six");
            list.Insert("seven");
            list.Insert("eight");
            list.Insert("nine");
            
           

            Object myobj = new Object();
            myobj = "jas";
            Console.WriteLine(list.RemoveAt(8));
            Console.WriteLine(list.InsertAt(8, myobj));
            list.PrintReverse();
            


        }
    }
}
