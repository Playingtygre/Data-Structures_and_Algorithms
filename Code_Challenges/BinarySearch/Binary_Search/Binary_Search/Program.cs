using System;

namespace Binary_Search
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //This a list of numbers//
            int[] sampleArray = { 1, 2, 3, 4 };
            //This is the target number 
            int sampleValue = 4;

            Console.WriteLine(BinarySearch(sampleArray, sampleValue));
            Console.ReadLine();
        }

        // Method takes in array and a value//
        public static int BinarySearch(int[] array, int value)
        {
            int result = -2;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == value)
                {
                    result = i;
                }
            }

            return result;
        }

    }
}
