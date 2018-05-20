using System;

 namespace RaddixSort
{
   public class Program
    {
        /* Raddix Sort deals with using buckets and comparing various tens digit to each other.
         * 
         */

        static void Main(string[] args)
        {

            int[] arr = new int[] { 2, 5, -4, 11, 0, 18, 22, 60, 51, 6 };
            Console.WriteLine("\nOriginal array : ");
            foreach (var item in arr)
            {
                Console.Write(" " + item);
            }

            Sort(arr);
            Console.WriteLine("\nSorted array : ");
            foreach (var item in arr)
            {
                Console.Write(" " + item);
            }
            Console.WriteLine("\n");
            Console.ReadLine();
        }


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
        }

    }
}
