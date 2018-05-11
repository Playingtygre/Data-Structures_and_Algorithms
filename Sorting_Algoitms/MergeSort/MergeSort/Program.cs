using System;
using System.Collections.Generic;
using System.Linq;

 namespace MergeSort
{
    public class Program
    {
        /* Merge Sorting involves spiting the array up several times until the you can
         * no longer split; then you start merging them together comparing
         * each individual number until they are merged back into one hence the name
         * Merge Sorting. There is a recursive aspect to this implementation that is much better than expected.
         * 
         */

        public static void Main(string[] args)
        {

            Console.WriteLine("Hello World!");


            int[] promo = { 8, 9, 10, 5 };

            foreach (int n in MergeSort(promo))
            {
                Console.WriteLine($"{n}");

            }

            Console.ReadKey();

        }

        /* This might be the quickest implementation of the recursive 
         */


        public static int[] MergeSort(int[] arr)
        {

            // Implements an recursive call 
            // Sends back the array if only one index[1] is found
            // This must be utilized when each index reaches zero.
            if (arr.Length == 1)
            {
                return arr;
            }

            // 
            int[] first = new int[(arr.Length + 1) / 2];
            //
            int[] last = new int[(arr.Length / 2)];

            //Copy takes in an arrangement of overload, which 
            Array.Copy(arr, first, first.Length);
            Array.Copy(arr, first.Length, last, 0, last.Length);

            first = MergeSort(first);
            last = MergeSort(last);

            int f = 0;
            int l = 0;
            for (int i = 0; i < arr.Length; i++)
            {

                /* Comparing and contrasting portion if the first.lenght is less than then keep 
                 * 
                 *  [8, 9, 10, 5] -> first row
                 * 
                 * [8] [9] [10][5] - >next row 
                 * 
                 */

                if (first.Length > f && last.Length > l)
                {
                    if (first[f] < last[l])
                    {
                        arr[i] = first[f];
                        f++;
                    }
                    else
                    {
                        arr[i] = last[l];
                        l++;
                    }
                }

                /* If found empty add the items from empty array back to array[]
                 */

                else if (first.Length > f)
                {
                    arr[i] = first[f];
                    f++;
                }
                else
                {
                    arr[i] = last[l];
                    l++;
                }
            }

            //Return sorted Lists
            return arr;
        }


    }


}

        





















        //Lets take in a clean List of items, and a unsorted list
        /*
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

        }*/




        /*
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
        }*/

 

