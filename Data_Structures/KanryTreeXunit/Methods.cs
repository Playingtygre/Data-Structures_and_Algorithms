using System;
using System.Collections.Generic;
using System.Text;
using K_aryTrees;
using Xunit;

namespace KanryTreeXunit
{
   public class MethodsXunitTest
    {
        /// <summary>
        /// Testing the BreathFirst Traversal
        /// </summary>
        [Fact]
        public void BreadthFirst()
        {   //ACT
            //Creating a new node 4
            byte[] arr = new byte[] {4};

            //adding the array of 4 to 4, 
            Node<byte> n = new Node<byte>(4, arr);
            Tree<byte> t = new Tree<byte>(n);
        
            //Setting up array[4,4]
            byte[] expected = new byte[] { 4, 4 };
            byte count = 0;

            Tree<byte>.Method iterAssert = node =>
            {
                //Assert
                Assert.Equal(expected[count], node.Value);
            };

        }


    }
}
