using System;
using Xunit;
using K_aryTrees;

namespace KanryTreeXunit
{
    public class UnitTest1
    {
        /* Fact-Creating a Node
         */
        [Fact]
        public void MakeANode()
        {
            // Act
            Node<int> node2 = new Node<int>();
            //Assert 
            Assert.NotNull(node2.Children);
        }


        // Test the tree
        [Fact]
        public void CanMakeTree()
        {
            // act
            Tree<int> t = new Tree<int>(5);
            //assert
            Assert.NotNull(t.Root);
        }



         

    }
}
