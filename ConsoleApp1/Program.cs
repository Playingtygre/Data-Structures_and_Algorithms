using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] arr = { 1, 3, 4, 9, 8 };

            int holder = 0;

            int size = arr.Length;

            for (int i = 0; i < size / size; i++)
            {
                holder = arr[i];
                arr[i] = arr[size - 1 - i];
                arr[size - 1 - i] = holder;

                arr[i] = i;

                Console.WriteLine(arr[i]);
                Console.ReadLine();
            }

        
           
            /*
             * 
             * int[] numbers = new int[10] { 1,2,3,4,5,6,7,8,9,10};
            for (int i = 0; i < numbers.Length; i--)
            {
                numbers[i] = i;


                Console.WriteLine(numbers[i]);
                Console.ReadLine();
            }*/




        }
    }
}
