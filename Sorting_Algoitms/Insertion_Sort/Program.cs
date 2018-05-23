using System;

namespace Insertion_Sort
{
    public class Program
    {
       public static void Main(string[] args)
        {
            int[] number = new int[5] { 2, 5, -4, 11, 0,};
            Console.WriteLine("\n input Array:");
            PrintIntegerArry(number);

            Console.WriteLine("\n Sorted Array Elements");
            PrintIntegerArry(InsertionSort(number));

            Console.ReadLine();
        }

        public static int[] InsertionSort(int[] inputArray)
        {
            for (var item = 0; item < inputArray.Length - 1; item++)
            {

                for (int j = item + 1; j > 0; j--)
                {
                    if (inputArray[j - 1] > inputArray[j])
                    {
                        int temp = inputArray[j - 1];
                        inputArray[j - 1] = inputArray[j];
                        inputArray[j] = temp;
                    }

                }

            }
            return inputArray;
        }

        public static void PrintIntegerArry(int[] array)
        {
            foreach (int i in array)
            {
                Console.WriteLine(i.ToString() + "");
            }

        }



    }//Bottom of Class
}
