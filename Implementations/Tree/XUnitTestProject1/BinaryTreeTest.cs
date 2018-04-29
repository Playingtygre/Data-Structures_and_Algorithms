using System;
using System.Collections.Generic;
using System.Text;
using BinaryTree;
using BinaryTreeTest;
using Xunit;

namespace XUnitTestProject1
{
   public  class BinaryTreeTest
    {

        [Theory]
        [ClassData(typeof(TreeTestData))]
        public void PreOrderTest(Tree<int> data)
        {
            // Arrange
            // Reference TreeTestData.GetEnumerator()
            List<int> expectedValues = new List<int> { 1, 2, 3, 8, 9, 4, 5, 6, 7 };
            List<int> actualValues = new List<int>();

            // Act
            actualValues = data.PreOrderTraversal(data.Root, actualValues);

            // Assert
            Assert.Equal(expectedValues, actualValues);
        }
    }
}
