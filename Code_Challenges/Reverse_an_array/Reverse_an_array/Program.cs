using System;

namespace Reverse_an_array
{
    class Program
    {
        static void Main(string[] args) 
        {

            ///input arrray
            int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };


            //takes the input array subtract one, keeps on doing that until its 0; 
            //starts a new empty string iterates until new emtpy string is filled with 
            //input array decrimating down.
            int length = array.Length - 1;
            string strRevser = null;
            while (length >= 0)
            {
                strRevser = strRevser + array[length];
                  length--;
            }

            Console.WriteLine();
            Console.WriteLine("Reverseis " + strRevser);
            Console.ReadLine();

          


        }   


    }
}
