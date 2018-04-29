using System;
using System.Collections.Generic;
using System.Text;

namespace BinaryTree
{
    public class Node<T>
    {
        /*  Remember Binary trees have either Left or right node
       */
        public Node<T> Left { get; set; }
        public Node<T> Right { get; set; }


      //* Setting up Node<T> value, as a generics later on
        public T Value { get; set; }


        /* Setting up Node  <T> value, as a generics later on
        */
        public Node(T value)
        {
            Value = value;
        }
    }
}