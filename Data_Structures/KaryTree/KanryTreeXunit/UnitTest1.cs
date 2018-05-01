using System;
using Xunit;
using K_aryTrees;

namespace KanryTreeXunit
{
    public class UnitTest1
    {
        /// <summary>
        /// Testing to see if Creating a node Works.
        /// </summary>

        [Fact]
        public void MakeANode()
        {
            // Act
            Node<int> node2 = new Node<int>();
            //Assert 
            Assert.NotNull(node2.Children);
        }

        /// <summary>
        /// Testing to See if Creating a tree and adding it to the node
        /// </summary>

        [Fact]
        public void CanMakeTree()
        {
            // act
            Tree<int> t = new Tree<int>(5);
            //assert
            Assert.NotNull(t.Root);
        }

        /// <summary>
        /// Testing to see if Adding a Node Works
        /// </summary>
        
        [Fact]
        public void CanAdd()
        {

            //ACT 
            byte[] arr = new byte[] { 5, 4, 2 };
            Node<byte> n = new Node<byte>(10, arr);
            Tree<byte> t = new Tree<byte>(n);

            //add a 7 node to 10 
            t.Add(10, 7);

            byte[] test = new byte[] { 10, 7, 5, 4, 2 };
            // empty byte counter to compare
            byte count = 0;
    
            // assert
            Tree<byte>.Method iterAssert = node =>
            {
                Assert.Equal(test[count], node.Value);
            };
 
        }
    }
}
