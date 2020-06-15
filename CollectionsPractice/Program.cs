using System;
using System.Collections.Generic;

namespace CollectionsPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            //Three basic arrays
            int[] zeroThroughNine = new int[10];
            string[] names = {"Tim", "Martin", "Nikki", "Sara"};
            bool[] alternating = {true, false, true, false, true, false, true, false, true, false};

            //List of Flavors
            List<string> flavors = new List<string>();
            flavors.Add("Vanilla");
            flavors.Add("Chocolate Chip Cookie Dough");
            flavors.Add("Bubblegum");
            flavors.Add("Strawberry");
            flavors.Add("Cherry Garcia");

            Console.WriteLine(flavors.Count);

            Console.WriteLine(flavors[2]);
            flavors.RemoveAt(2);
            Console.WriteLine(flavors.Count);

            //User Info Dictionary
            Dictionary<string, string> favIceCream = new Dictionary<string, string>();
            for(int i = 0; i < names.Length; i++)
            {
                favIceCream.Add(names[i], flavors[i]);
            }

            foreach(var favs in favIceCream)
            {
                Console.WriteLine($"Name: {favs.Key} Ice Cream: {favs.Value}");
            }

        }
    }
}
