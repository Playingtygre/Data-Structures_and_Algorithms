using System;
using Xunit;
using XUnitTestShiftArray;
using ShiftArray;

namespace XUnitTestShiftArray
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            Assert.Equal(1, ShiftArray.Program.InsertShfitArray(new int[] { 1, 2, 3 }, 2));

        }


       /* [Theory]
        public void TestInsertShiftArray(int[] array, int x, int[] expectedArray)
        {
            Assert.Equal(expectedArray, Program.InsertShiftArray(testArray, testValue));
        }*/

    }
}
