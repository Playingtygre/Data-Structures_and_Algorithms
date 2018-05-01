using System;
using System.Collections.Generic;
using System.Text;
using K_aryTrees;
using Xunit;

namespace KanryTreeXunit
{
   public class MethodsXunitTest
    {
        [Fact]
        public void BreadthFirst()
        {
            byte[] arr = new byte[] {4};
            Node<byte> n = new Node<byte>(4, arr);
            Tree<byte> t = new Tree<byte>(n);
        
            byte[] expected = new byte[] { 4, 4 };
            byte count = 0;

            Tree<byte>.Method iterAssert = node =>
            {
                Assert.Equal(expected[count], node.Value);
            };

        }


    }
}
