using System;
using Xunit;
using largest_product;
using static largest_product.Program;

namespace XUnitTestProject_largestProduct
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            int[,] inputArray = new int[,]
            {
                { 1, 3 },
                { 3, 7 },
                { 5, 5 },
                { 0, 1 },
                { -3, 10 }
            };

            Assert.Equal(25, Program.LargestProduct(inputArray));
        }

        [Fact]
        public void Test2()
        {
            int[,] inputArray = new int[,]
            {
                { 1, 2 },
                { 3, 4 },
                { 5, 6 },
                { 7, 8 },
                { 9, 10 }
            };

            Assert.Equal(90, Program.LargestProduct(inputArray));
        }

        [Fact]
        public void Test3()
        {
            int[,] inputArray = new int[,]
            {
                { 1, 1 },
                { 2, 2 },
                { 3, 3 },
                { 4, 4 },
                { 5, 5 }
            };

            Assert.Equal(25, Program.LargestProduct(inputArray));
        }


    }



}
