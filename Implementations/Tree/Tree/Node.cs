using System;
using System.Collections.Generic;
using System.Text;

namespace BinaryTree
{
    /* Node <T> - setting up a generic list of nodes
     */

   public class Node <T>
    {

        /* Remember Binary trees have either Left or right node
         */

        public Node<T> Left { get; set; }


        /*  Remember Binary trees have either Left or right node
         */

        public Node<T> Right { get; set; }

        /* T stands for Value of the node
         */

        public T Value { get; set; }

        /* Setting up Node  <T> value, as a generics later on
         */

        public Node(T value)
        {
            Value = Value;
        }

    }
}
