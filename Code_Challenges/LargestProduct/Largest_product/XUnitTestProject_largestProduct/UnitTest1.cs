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
    }



}
