using System;

namespace Basic13
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintNumbers();
            PrintOdds();
            PrintSum();

            int[] intArray = {-3,5,7,-1,8,1};
            LoopArray(intArray);
            int max = FindMax(intArray);
            Console.WriteLine(max);
            GetAverage(intArray);

            int[] oddNums = OddArray();
            foreach(int num in oddNums)
            {
                Console.WriteLine(num);
            }

            int numGreater = GreaterThanY(intArray, 5);
            Console.WriteLine(numGreater);

            SquareArrayValues(intArray);

            EliminateNegatives(intArray);

            MinMaxAverage(intArray);

            ShiftValues(intArray);

            int[] newIntArray = {3,-1,5,3,-3};
            object[] objects = NumToString(newIntArray);
            foreach(var obj in objects)
            {
                Console.WriteLine(obj);
            }
        }

        public static void PrintNumbers()
        {
            for(int i = 1; i <= 255; i++) {
                Console.WriteLine(i);
            }
        }

        public static void PrintOdds()
        {
            for(int j = 1; j <= 255; j += 2)
            {
                Console.WriteLine(j);
            }
        }

        public static void PrintSum()
        {
            int sum = 0;
            for(int k = 0; k <= 255; k++)
            {
                sum += k;
                Console.WriteLine($"New Number: {k} Sum: {sum}");
            }
        }

        public static void LoopArray(int[] numbers)
        {
            foreach(int num in numbers)
            {
                Console.WriteLine(num);
            }
        }

        public static int FindMax(int[] numbers)
        {
            int max = 0;
            foreach(int num in numbers)
            {
                if(num > max)
                {
                    max = num;
                }
            }
            Console.WriteLine(max);
            return max;
        }

        public static void GetAverage(int[] numbers)
        {
            int sum = 0;
            foreach(int num in numbers)
            {
                sum += num;
            }
            Console.WriteLine((float)sum / numbers.Length);
        }

        public static int[] OddArray()
        {
            int[] oddNums = new int[128];
            int j = 0;
            for(int i = 1; i <= 255; i++)
            {
                if(i % 2 != 0)
                {
                    oddNums[j] = i;
                    j++;
                }
            }

            return oddNums;
        }

        public static int GreaterThanY(int[] numbers, int y)
        {
            int numGreater = 0;
            foreach(int num in numbers)
            {
                if(num > y)
                {
                    numGreater += 1;
                }
            }
            return numGreater;
        }

        public static void SquareArrayValues(int[] numbers)
        {
            foreach(int num in numbers)
            {
                Console.WriteLine(Math.Pow(num, 2));
            }
        }

        public static void EliminateNegatives(int[] numbers)
        {
            for(int i = 0; i < numbers.Length; i++)
            {
                if(numbers[i] < 0)
                {
                    numbers[i] = 0;
                }
            }
        }

        public static void MinMaxAverage(int[] numbers)
        {
            int min = numbers[0];
            int max = numbers[0];
            int sum = 0;
            foreach(int num in numbers)
            {
                if(num < min)
                {
                    min = num;
                }
                if(num > max)
                {
                    max = num;
                }
                sum += num;
            }
            Console.WriteLine($"Min: {min}");
            Console.WriteLine($"Max: {max}");
            Console.WriteLine($"Average {(float)sum / numbers.Length}");
        }

        public static void ShiftValues(int[] numbers)
        {
            for(int i = 0; i < numbers.Length - 1; i++)
            {
                numbers[i] = numbers[i+1];
            }
            numbers[numbers.Length-1] = 0;
        }

        public static object[] NumToString(int[] numbers)
        {
            object[] newArray = new object[numbers.Length];
            for(int i = 0; i < numbers.Length; i++)
            {
                if(numbers[i] < 0)
                {
                    newArray[i] = "Dojo";
                }
                else
                {
                    newArray[i] = numbers[i];
                }
            }

            return newArray;
        }

    }
}
