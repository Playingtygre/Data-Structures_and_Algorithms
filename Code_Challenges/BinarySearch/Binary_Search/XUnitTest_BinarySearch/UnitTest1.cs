using System;
using Xunit;
using Binary_Search;
using static Binary_Search.Program;

namespace XUnitTest_BinarySearch
{
    public class UnitTest1
    {
        // Create an array and set a value
        [Fact]
        public void CanReturn1()
        {
            // Assert.Equal("1", Program.BinarySearch(new int[] { 1, 2, 3, 4 }, 5, 2) );
            //Assert.Equal("1", binary_serach.Program.BinarySearch(new int[5] {1,2,3}, 2) );
            //remember that passing it two paramaters; passing it an array of 3;
            Assert.Equal(1, Binary_Search.Program.BinarySearch(new int[3] { 1, 2, 3 }, 2));
            /// end of can return 1
            /// 

            Assert.Equal(1, Binary_Search.Program.BinarySearch(new int[3] { 1, 2, 3 }, 2));


        }


        [Theory]
        [InlineData(new int[6] { 4, 8, 15, 16, 23, 42 }, 15)]

        [InlineData(new int[] { 1, 2, 3, 4, 5 }, 3)]

        [InlineData(new int[] { 6, 7, 8, 9, }, 8)]

        [InlineData(new int[] { 9, 10, 11, 12 }, 8)]


        public void CanReturnNum(int[] array, int value)
        {
            Assert.Equal(2, BinarySearch(array, value));
        }



    }
}
