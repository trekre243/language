using System;

namespace Fundamentals1
{
    class Program
    {
        static void Main(string[] args)
        {
            //print out all the numbers form 1 to 255
            for(int i = 1; i <= 255; i++)
            {
                Console.WriteLine(i);
            }

            //the values from 1 to 100 that are divisble by 3 or 5 but not both
            for(int j = 1; j <= 100; j++)
            {
                if((j % 3 == 0 || j % 5 == 0) && !(j % 3 == 0 && j % 5 == 0))
                {
                    Console.WriteLine(j);
                }
            }

            //Fizz: 3, Buzz: 5, FizzBuzz: 3 and 5
            for(int k = 1; k <= 100; k++)
            {
                if(k % 3 == 0 && !(k % 5 == 0))
                {
                    Console.WriteLine("Fizz");
                }
                else if(k % 5 == 0 && !(k % 3 == 0))
                {
                    Console.WriteLine("Buzz");
                }
                else if(k % 3 == 0 && k % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else
                {
                    Console.WriteLine(k);
                }
            }
        }
    }
}
