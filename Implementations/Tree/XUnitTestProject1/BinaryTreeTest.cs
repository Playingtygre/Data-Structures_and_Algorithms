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
 
            List<int> expectedValues = new List<int> { 1, 2, 3, 4,  };
            List<int> actualValues = new List<int>();

            // Act
            actualValues = data.PreOrderTraversal(data.Root, actualValues);

            // Assert
            Assert.Equal(expectedValues, actualValues);
        }





        [Theory]
        [ClassData(typeof(TreeTestData))]
        public void InOrderTest(Tree<int> data)
        {
            //Arragne
            List<int> expectedValues = new List<int> { 3, 2, 4, 1 };
            List<int> actualValues = new List<int>();

            // act
            actualValues = data.InOrderTraversal(data.Root, actualValues);

            //assert
            Assert.Equal(expectedValues, actualValues);
        }

        [Theory]
        [ClassData(typeof(TreeTestData))]
        public void PostOrderTest(Tree<int> data)
        {
            //Arragne
            List<int> expectedValues = new List<int> { 3, 4, 2, 1 };
            List<int> actualValues = new List<int>();

            // act
            actualValues = data.PostOrderTraversal(data.Root, actualValues);

            //assert
            Assert.Equal(expectedValues, actualValues);
        }


    }
}
