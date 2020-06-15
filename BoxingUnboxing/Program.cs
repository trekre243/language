using System;
using System.Collections.Generic;

namespace BoxingUnboxing
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create an empty list of "object" type
            List<object> list = new List<object>();

            //Add the following values to the list
            list.Add(7);
            list.Add(28);
            list.Add(-1);
            list.Add(true);
            list.Add("chair");

            //loop through the list and print out all the values
            foreach(var val in list)
            {
                Console.WriteLine(val);
            }

            //Add all values that are int type and output the sum
            int sum = 0;
            foreach(var val in list)
            {
                if(val is int)
                {
                    sum += (int)val;
                }
            }
            Console.WriteLine(sum);
        }
    }
}
