using System;
using System.Collections.Generic;

namespace Puzzles
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] randNums = RandomArray();
            foreach(int num in randNums)
            {
                Console.WriteLine(num);
            }

            for(int i = 0; i < 5; i++)
            {
                Console.WriteLine(TossCoin());
            }

            List<string> longNames = ShuffleNames();
            foreach(string name in longNames)
            {
                Console.WriteLine(name);
            }

        }

        public static int[] RandomArray()
        {
            const int NUMRANDS = 10;
            const int MIN = 5;
            const int MAX = 25;

            Random rand = new Random();

            int[] randInts = new int[NUMRANDS];
            for(int i = 0; i < NUMRANDS; i++)
            {
                randInts[i] = rand.Next(MIN, MAX + 1);
            }
            
            return randInts;
        }

        public static string TossCoin()
        {
            Random rand = new Random();
            Console.WriteLine("Tossing a Coin!");
            int flip = rand.Next(2);
            return flip == 0 ? "Heads" : "Tails";
        }

        public static List<string> ShuffleNames()
        {
            List<string> names = new List<string>();
            names.Add("Trevor");
            names.Add("Steve");
            names.Add("Sara");
            names.Add("Roberto");

            Random rand = new Random();

            for(int i = 0; i < 10; i++)
            {
                for(int j = 0; j < names.Count; j++)
                {
                    int swapLoc = rand.Next(names.Count);
                    string temp = names[swapLoc];
                    names[swapLoc] = names[j];
                    names[j] = temp;
                }
            }

            foreach(var name in names)
            {
                Console.WriteLine(name);
            }

            List<string> newList = new List<string>();
            foreach(string name in names)
            {
                if(name.Length > 5)
                {
                    newList.Add(name);
                }
            }

            return newList;
        }
    }
}
