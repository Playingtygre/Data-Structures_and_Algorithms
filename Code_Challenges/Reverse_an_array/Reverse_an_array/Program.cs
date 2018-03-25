using System;

namespace Reverse_an_array
{
    class Program
    {
        static void Main(string[] args)
        {
            //testing array
            int[] testarray = new int[] { 1, 2, 3, 4, 5 };


            //calls the method reverse array giving it an argument of test array
            //iterates thru the entire array printing out each number in the array using console.writeline
            ReverseArray(testarray);
            for (int i = 0; i < testarray.Length; i++)
            {
                Console.WriteLine(testarray[i]);
            }
            Console.ReadLine();
        }


        //method for iterating thru entire array 
        // setting thru the entire array subtracting the array index from one. dividing entire lenght by 2
        //declare a new array is then accepts decrimeted old array. 
        static Array ReverseArray(int[] input)
        {
            int newArray = 0;
            for (int i = input.Length - 1; i > input.Length / 2; i--)
            {
                newArray = input[(input.Length - 1) - i];
                input[(input.Length - 1) - i] = input[i];
                input[i] = newArray;
            }
            return input;
        }



    }

}
  
