using System;
using System.Collections.Generic;


namespace BinaryTree
{
    class Program
    {
        static void Main(string[] args)
        { 


            // Lets make a tree with the root at 1
            Tree<int> tree = new Tree<int>(1);

            // Lets then add a node value of 2 to the left
            Node<int> left = tree.Root.Left = new Node<int>(2);

            // lets then add a node value of  3 to the left 

            Node<int> leftLeft = left.Left = new Node<int>(3);

            //lets then add a node value of 4 to the right
            Node<int> leftRight = left.Right = new Node<int>(4);

            // lets then add a node value to that right
            Node<int> right = tree.Root.Right = new Node<int>(5);

          
            /* new instance of a list of nodes
             */

            List<int> values = new List<int>();

            // Show the results of all three traversal types

            /*  setting values to a new tree. using preOrder method adding the tree and its values Parameters of (node, values)
             *  
             */

            values = tree.PreOrderTraversal(tree.Root, values);
            Console.WriteLine("Pre-order Traversal:");
            Console.WriteLine($"[{string.Join(", ", values)}]");
            Console.WriteLine();
            values.Clear();


            /* setting values to a new tree. using InOrder method adding the tree and its values Parameters of (node, values)
             */
            values = tree.InOrderTraversal(tree.Root, values);
            Console.WriteLine("In-order Traversal:");
            Console.WriteLine($"[{string.Join(", ", values)}]");
            Console.WriteLine();
            values.Clear();

            /* setting values to a new tree. using PostOrder method adding the tree and its values Parameters of (node, values)
             */

            values = tree.PostOrderTraversal(tree.Root, values);
            Console.WriteLine("Post-order Traversal:");
            Console.WriteLine($"[{string.Join(", ", values)}]");

            Console.WriteLine();
            Console.WriteLine("Please press any key to continue...");
            Console.ReadKey();
        }
    }
}
