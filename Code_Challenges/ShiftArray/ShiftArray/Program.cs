using System;

namespace ShiftArray
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //int[] testArray = new int[] { };
            int[] array = { 1, 2, 4, 5 }; // Original array
            int x = 3;

            InsertShfitArray(array, x);

            Console.ReadKey();
     
        }


        public static void InsertShfitArray (int[]array, int x)
        {
            //Declare a new array, setting it to the old array with additional index 
            int[] newArray = new int[array.Length + 1]; 
            
            //Loops thru the original index, if index.
            for (int i = 0; i < newArray.Length; i++)
            {
                //if index is less than half of new array length set new index
                if (i < (newArray.Length / 2)) 
                {
                    newArray[i] = array[i]; 
                }
                // however if this is untrue split new array length  and 
                //set array length in half
                else if (i > (newArray.Length / 2)) 
                {
                    newArray[i] = array[i - 1]; 
                }
                // if index is half of new array set the value to that array.

                else if (i == newArray.Length / 2)
                {
                    newArray[i] = x;
                }
            }

            Console.WriteLine("Input Array");
            Console.WriteLine("New Array item: {0}", x);

            for (int i = 0; i < array.Length; i++)
            {
                //displays ever index of input array
                Console.WriteLine(array[i]);
            }

            //displays newer array.
            Console.WriteLine(" Output Array:");
            for (int i = 0; i < newArray.Length; i++)
            {
                Console.WriteLine(newArray[i]);
            }
            Console.ReadLine();


        }


    }
}
