using System;
using Xunit;
using static RaddixSortMethod.Program;


namespace XUnitTestProject1
{
    public class UnitTest1
    {

        [Theory]
        [InlineData(new int[] { 2, 10, 21, 63, 548, 987 }, new int[] { 2, 10, 21, 63, 548, 987 })]
        [InlineData(new int[] { 1, 2, 3 }, new int[] { 1, 2, 3 })]
        [InlineData(new int[] { 10, 20, 30, 4, 5, 100 }, new int[] { 4, 5, 10, 20, 30, 100 })]
        [InlineData(new int[] { 10, 548, 63, 21, 987, 2 }, new int[] { 2, 10, 21, 63, 548, 987 })]

        public void RaddixSortTest(int[] testArray, int[] resultArray)
        {

            Assert.Equal(resultArray, RadixSort(testArray));
        }

     


    }
}
