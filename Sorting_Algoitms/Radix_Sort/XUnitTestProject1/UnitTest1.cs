using System;
using Xunit;
using static RaddixSort.Program;


namespace XUnitTestProject1
{
    public class UnitTest1
    {

        [Theory]
        [InlineData(new int[6] { 2, 10, 21, 63, 548, 987 }, new int[6] { 2, 10, 21, 63, 548, 987 })]
        [InlineData(new int[] { 1, 2, 3 }, new int[] { 1, 2, 3 })]

        public void RaddixSortTest(int[] testArray, int[] resultArray)
        {

            Assert.Equal(resultArray, testArray);
        }

        [Fact]
        public void RaddixSort()
        {
            int[] testArray = new int[3] { 100, 50, 80 };
 

        }


    }
}
