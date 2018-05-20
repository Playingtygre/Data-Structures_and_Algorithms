using System;
using System.Collections.Generic;

namespace RaddixSortMethod
{
   public class Program
    {
        /* Raddix Sort deals with using buckets and comparing various tens digit to each other.
         * 
         */


        public static void Main(string[] args)
        {


            int[] array =  new int[7] { 7, 5, 3, 6, 76, 45, 32 };

            foreach (int item in array)
            {
                Console.WriteLine(item);
            }

            int[] sortedArray = RadixSort(array);

            Console.WriteLine(sortedArray);

        }

            public static int[] RadixSort(int[] array)
            {
                bool isFinished = false;
                int digitPosition = 0;

                List<Queue<int>> buckets = new List<Queue<int>>();
                InitializeBuckets(buckets);

                while (!isFinished)
                {
                    isFinished = true;

                    foreach (int value in array)
                    {
                        int bucketNumber = GetBucketNumber(value, digitPosition);
                        if (bucketNumber > 0)
                        {
                            isFinished = false;
                        }

                        buckets[bucketNumber].Enqueue(value);
                    }

                    int i = 0;
                    foreach (Queue<int> bucket in buckets)
                    {
                        while (bucket.Count > 0)
                        {
                            array[i] = bucket.Dequeue();
                            i++;
                        }
                    }

                    digitPosition++;
                }

                return array;
            }

            public static int GetBucketNumber(int value, int digitPosition)
            {
                int bucketNumber = (value / (int)Math.Pow(10, digitPosition)) % 10;
                return bucketNumber;
            }

            private static void InitializeBuckets(List<Queue<int>> buckets)
            {
                for (int i = 0; i < 10; i++)
                {
                    Queue<int> q = new Queue<int>();
                    buckets.Add(q);
                }
            }

        






        /*/ This is another implemtation of Raddix Sort
       public static void Sort(int[] arr)
        {
            //Declare variables i and j
            int i, j;
            // temp variable which would be the length of the array
            int[] tmp = new int[arr.Length];
            // iterate thru the array at the last index
            for (int shift = 31; shift > -1; --shift)
            {
                // let variable j set to zero
                j = 0;

                //let us iterate thru the entire array 
                for (i = 0; i < arr.Length; ++i)
                {
                    // if the array has a index not a zero then shift
                    bool move = (arr[i] << shift) >= 0;

                    // if the index is zero move the array
                    if (shift == 0 ? !move : move)

                        //Move the array at index
                        arr[i - j] = arr[i];
                    // move the temp variable across
                    else
                        tmp[j++] = arr[i];
                }
               Array.Copy(tmp, 0, arr, arr.Length - j, j);
            }
        }*/

    }
}
