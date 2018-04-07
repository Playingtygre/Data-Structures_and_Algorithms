using System;
using Xunit;
using SinglyLinkedList;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Theory]

        [InlineData(new int[] { 1, 3, 2 }, new int[] { 5, 9 }, new int[] { 1, 5, 3, 9, 2 })]
        [InlineData(new int[] { 1, 3}, new int[] { 5, 9, 4 }, new int[] { 1, 5, 3, 9, 4 })]
        [InlineData(new int[] { 1, 3 }, new int[] { 5, 9, 8 }, new int[] { 1, 5, 3, 9, 8 })]


        public void MergeLists(int[] inputList1, int[] inputList2, int[]OutputList)
        {

        }

    }
}
