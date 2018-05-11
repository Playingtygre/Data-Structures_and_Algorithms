using System;
using Xunit;
using QuickSort;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Theory]

        [InlineData(new int[] { 7, 3, 1 },
             new int[] { 1, 3, 7 })]

        [InlineData(new int[] { 5, -5, 0, 3 },
             new int[] { -5, 0, 3, 5, })]

        [InlineData(new int[] { 34, 19, 42, -9, 2018, 0, 2005, 77, 2099 },
             new int[] { -9, 0, 19, 34, 42, 77, 2005, 2018, 2099 })]


        public void Quick_Sort(int[] unsortedArray, int[] expectedArray)
        {
            // Act
            int[] sortedArray = Program.Quick_Sort(unsortedArray);

            // Assert
            Assert.Equal(expectedArray, sortedArray);
        }

    }
}
