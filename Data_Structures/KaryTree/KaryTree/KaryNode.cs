using System;
using System.Collections.Generic;
using System.Text;

namespace K_aryTrees
{
    /*  Node <T> will be a generics list
     */

    public class Node<T>
    {
        /// <summary>
        /// Knary Tree; Root node has children
        /// </summary>
 
        public Node()
        {
            // Setting up Constuctor to the generics list.
            Children = new List<Node<T>>();
        }

        /*  Node with an argument of generics list, its children will be
         *  the generics list. Setting
        */
        public Node(T value)
        {
            Children = new List<Node<T>>();
            Value = value;
        }

        /* An public node with all the children, this will take in a parameter
         * with array of T and its children.
         */

        public Node(T value, T[] children)
        {
            Children = new List<Node<T>>();
            foreach (T val in children)
            {
                Children.Add(new Node<T>(val));
            }
            Value = value;
        }

        public T Value { get; set; }
        public List<Node<T>> Children { get; set; }
    }
}