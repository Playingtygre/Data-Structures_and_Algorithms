using System;
using System.Collections.Generic;
using System.Text;

namespace BinaryTree
{
    public class Tree<T>
    {
        /* This is a Generics list of tree nodes inside
         */

        public Node<T> Root { get; set; }

        /* Accessing the node values using the tree <T> Generics
         */

        public Tree(T rootValue)
        {
            Root = new Node<T>(rootValue);
        }

        /*  PreOrderTraversal -> lets bring in the nodes and the values
        */

        public List<T> PreOrderTraversal(Node<T> node, List<T> values)
        {
            values.Add(node.Value);


            // PreOrder is left first if a Node is Found access that value
            if (node.Left != null)
            {
                PreOrderTraversal(node.Left, values);
            }

            // PreOrder is then followed by Right node if found access that node value
            if (node.Right != null)
            {
                PreOrderTraversal(node.Right, values);
            }

            return values;
        }

        /*  InOrderTraversal -> lets bring in the nodes and the values
        */
        public List<T> InOrderTraversal(Node<T> node, List<T> values)
        {
            //Lets access the node to the left and its current values
            if (node.Left != null)
            {
                InOrderTraversal(node.Left, values);
            }

            values.Add(node.Value);

            // Let us access values to the right
            if (node.Right != null)
            {
                InOrderTraversal(node.Right, values);
            }

            return values;
        }


        /*  PostOrderTraversal -> lets bring in the nodes and the values
         */
        public List<T> PostOrderTraversal(Node<T> node, List<T> values)
        {
            // if the node values to the left have values lets add
            if (node.Left != null)
            {
                PostOrderTraversal(node.Left, values);
            }

            // if the node values on the right lets add
            if (node.Right != null)
            {
                PostOrderTraversal(node.Right, values);
            }

            values.Add(node.Value);

            return values;
        }

    }//Bottom of the Tree Class
}