using BinaryTree;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace BinaryTreeTest
{
    class TreeTestData : IEnumerable<object[]>
    {
        /* Public Enumerator is set to an empty array object
         */

        public IEnumerator<object[]> GetEnumerator()
        {

            // Lets Construct a new tree 

            Tree<int> tree = new Tree<int>(1);

            Node<int> left = tree.Root.Left = new Node<int>(2);
            Node<int> leftLeft = left.Left = new Node<int>(3);
            Node<int> leftRight = left.Right = new Node<int>(4);
           

            yield return new object[] { tree };
        }


        // Lets us use the Enum function to go thru the list of Enumerators.

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}