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

        /* Theory testing of the PreOrder
         * 
         */

        [Theory]
        //typeof is being used to open the Tree<int>, generics list

        [ClassData(typeof(TreeTestData))]
        public void PreOrderTest(Tree<int> data)
        {
            // Arrange-> Creating the Node Value list
            List<int> expectedValues = new List<int> { 1, 2, 3, 4,  };
            //contructor for brining in a new tree <list>
            List<int> TestValues = new List<int>();

            // Act
            TestValues = data.PreOrderTraversal(data.Root, TestValues);

            // Assert
            Assert.Equal(expectedValues, TestValues);
        }





        [Theory]
        [ClassData(typeof(TreeTestData))]
        public void InOrderTest(Tree<int> data)
        {
            // Arrange-> Creating the Node Value list
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
            // Arrange-> Creating the Node Value list
            List<int> expectedValues = new List<int> { 3, 4, 2, 1 };
            List<int> actualValues = new List<int>();

            // act
            actualValues = data.PostOrderTraversal(data.Root, actualValues);

            //assert
            Assert.Equal(expectedValues, actualValues);
        }


    }
}
