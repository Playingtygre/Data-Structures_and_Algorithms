using System;
using System.Collections.Generic;
using System.Linq;

namespace MergeSort
{
    class Program
    {
        /* Merge Sorting involves spiting the array up several times until the you can
         * no longer split; then you start merging them together comparing
         * each individual number until they are merged back into one hence the name
         * Merge Sorting.
         * 
         */

        static void Main(string[] args)
        {
            List<int> Unsort = new List<int>();
            List<int> sorted;

            Random random = new Random();

            Console.WriteLine("Original array");
            for (int i = 0; i < 10; i++)
            {
                Unsort.Add(random.Next(0, 10));
                Console.Write(Unsort[i] + "");
            }

            Console.WriteLine();

            sorted = MergeSort(Unsort);

            Console.WriteLine("Sorted array");

            foreach (int x in sorted)
            {
                Console.Write(x + "");
            }

            Console.WriteLine("\n")
                ;



            Console.WriteLine("Hello World!");


        }


        //Lets take in a clean List of items, and a unsorted list
        public static List<int> MergeSort(List<int> Unsort)
        {
            if (Unsort.Count <= 1)
                return Unsort;

            List<int> left = new List<int>();
            List<int> right = new List<int>();

            int middle = Unsort.Count / 2;

            for (int i = 0; i < middle; i++)
            {
                left.Add(Unsort[i]);
            }

            for (int i = middle; i < Unsort.Count; i++)
            {
                right.Add(Unsort[i]);
            }

            left = MergeSort(left);
            right = MergeSort(right);
            return Merge(left, right);

        }

        public static List<int> Merge(List<int> left, List<int> right)
        {
            List<int> result = new List<int>();

            while (left.Count > 0 || right.Count > 0)
            {
                if (left.Count > 0 && right.Count > 0)
                {
                    if (left.First() <= right.First())
                    {
                        result.Add(left.First());
                        result.Remove(left.First());
                    }

                    else
                    {
                        result.Add(right.First());
                        result.Remove(right.First());
                    }
                }

                else if (left.Count > 0)
                {
                    result.Add(left.First());
                    left.Remove(left.First());
                }
                else if (right.Count > 0)
                {
                    result.Add(right.First());
                    right.Remove(right.First());
                }


            }

            return result;
        }

    }

}
     

