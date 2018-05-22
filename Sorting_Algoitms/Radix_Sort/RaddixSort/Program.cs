using System;
using System.Collections.Generic;

namespace RaddixSortMethod
{
   public class Program
    {
        /* Radix Sort deals with using buckets and comparing various tens digit to each other.
         * 
         */


        public static void Main(string[] args)
        {


            //Setting array constructor

            int[] array =  new int[7] { 7, 5, 3, 6, 76, 45, 32 };

            //Lets iterate thru the array then perform radix sort on it.
            foreach (int item in array)
            {
                Console.WriteLine(item);
            }

            //This is similar to recursion
            int[] sortedArray = RadixSort(array);

            Console.WriteLine(sortedArray);

        }

            //Radix Sort takes in array[]

            public static int[] RadixSort(int[] array)
            {
                bool isFinished = false;
                int digitPosition = 0;

                //object constructor of bucket
                List<Queue<int>> buckets = new List<Queue<int>>();
                InitializeBuckets(buckets);


                //Sits array into buckets
                while (!isFinished)
                {
                    isFinished = true;
                    
                    
                    //Every value must belong in a bucket
                    foreach (int value in array)
                    {
                        int bucketNumber = GetBucketNumber(value, digitPosition);
                        if (bucketNumber > 0)
                        {
                            isFinished = false;
                        }

                        //When finally sorted enqueue all values
                        buckets[bucketNumber].Enqueue(value);
                    }


                    //How many bucket values there are dequeue them.
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

                //Bu
            public static int GetBucketNumber(int value, int digitPosition)
            {
                int bucketNumber = (value / (int)Math.Pow(10, digitPosition)) % 10;
                return bucketNumber;
            }

             //Bucket creator only has 10 buckets to star off, adds buckets into the queue
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
