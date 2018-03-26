using System;

namespace largest_product
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int[,] sampleArray = new int[,] { { 1, 2 }, { 3, 4 }, { 5, 6 }, { 7, 8 } };
            string answer = LargestProduct(sampleArray).ToString();
            Console.WriteLine(answer);
            Console.ReadKey();
        }


        public static int LargestProduct(int[,] arr)
        {
            //declaring the product to zero
            int product = 0;

            //iterates thru the first loop to find all the integers 
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                // iterates thru the secont loop to find the second number
                for (int a = 0; a < arr.GetLength(1) - 1; a++)
                {
                   //if else statement if current [a,i] are compared with prevous loop
                    if (arr[i, a] * arr[i, a + 1] > product)
                    {
                        // since the next set of numbers is larger change product.
                        product = arr[i, a] * arr[i, a + 1];
                    }

                }
            }
            return product;
        }

    }
}