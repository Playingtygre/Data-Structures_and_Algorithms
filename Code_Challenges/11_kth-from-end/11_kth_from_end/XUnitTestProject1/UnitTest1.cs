using System;
using Xunit;
using Linked_List;
using System.Collections.Generic;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void CanFindKth()
        {
            Node node1 = new Node(new int[] {1,2,3,4 });
            Assert.Equal(2, node1.kthFromEnd(2));
        }

        [Theory]
        [InlineData(new int[] { 1, 3, 8, 2 }, 3)]

        public void ReturnKth(int[], int k)
        {

        }

       /* [Fact]
        public void CanFindThirdFromEnd()
        {
            LinkedList l = new LinkedList(new int[] { 1, 5, 3, 6, 2, 9, 11 });
            Node expect = ex.Head;
            
        }*/
    }
}
