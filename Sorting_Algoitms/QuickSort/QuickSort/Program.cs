using System;

namespace QuickSort
{

    /*Quick Sort is a divide and Conquer Procedure.
     * 
     */

    public class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 2, 5, -4, 11, 0, 18, 22, 67, 51, 6 };

            Console.WriteLine("Original array : ");
            foreach (var item in arr)
            {
                Console.Write(" " + item);
            }
            Console.WriteLine();

            Quick_Sort(arr, 0, arr.Length - 1);

            Console.WriteLine();
            Console.WriteLine("Sorted array : ");

            foreach (var item in arr)
            {
                Console.Write(" " + item);
            }
            Console.WriteLine();
        

             Console.ReadLine();
        }

        /* Quick Sort takes in an array, and has a left and right pointer
         *
         */

        public static void Quick_Sort(int[] arr, int left, int right)
        {
            //Anything to the left of the  Quick sort
            if (left < right)
            {
                int pivot = Partition(arr, left, right);

                if (pivot > 1)
                {
                    Quick_Sort(arr, left, pivot - 1);
                }
                if (pivot + 1 < right)
                {
                    Quick_Sort(arr, pivot + 1, right);
                }
            }

           
          

        }

        /*Partition takes in an array and has a left and right pointer
         * 
         */

        public static int Partition(int[] arr, int left, int right)
        {
            int pivot = arr[left];
            while (true)
            {
                //Moving pointers twoard each other
                while (arr[left] < pivot)
                {
                    left++;
                }
                //Moving pivot points for swapping  
                while (arr[right] > pivot)
                {
                    right--;
                }

                //Swap Values and moving left and right pointer
                if (left < right)
                {
                    if (arr[left] == arr[right]) return right;

                    int temp = arr[left];
                    arr[left] = arr[right];
                    arr[right] = temp;


                }

                else
                {
                    //returing the partion point
                    return right;
                }
            }
        }




    }
}
