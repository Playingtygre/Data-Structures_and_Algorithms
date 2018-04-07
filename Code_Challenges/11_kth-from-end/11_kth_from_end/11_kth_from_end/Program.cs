using Linked_List;
using System;
using System.Collections.Generic;

namespace Linked_List
{
    class Program

    /* Part of this code were given by Amanda Iverson in example lecuture
     *  Parts of this code were copied from Aurthur Allen
     *  Parts of this code were collaborated with Arthur Allen
     */ 
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!, This is our Kth in the List");

            // Declare the nodes
            Node node1 = new Node();
            Node node2 = new Node();
            Node node3 = new Node();
            Node node4 = new Node();
            Node node5 = new Node();
            Node node6 = new Node();
            Node node7 = new Node();

            // Link the nodes
            node1.Next = node2;
            node2.Next = node3;
            node3.Next = node4;
            node4.Next = node5;
            node5.Next = node6;
            node6.Next = node7;
            node7.Next = null;

            // Populate the nodes
            node1.Value = 1;
            node2.Value = 3;
            node3.Value = 8;
            node4.Value = 2;
            node5.Value = 2;
            node6.Value = 2;
            node7.Value = 2;

            // Instantiate the list
            SinglyLinked sll = new SinglyLinked(node1);

            Console.WriteLine("this is our singly-linked node list");
            Console.WriteLine("[1][3][8][7][6][5][9] -> HEAD");
            Console.WriteLine("Go ahead and type in a number to check its position");

            int number;

            ConsoleKeyInfo UserInput = Console.ReadKey();
            if (char.IsDigit(UserInput.KeyChar))
            {
                number = int.Parse(UserInput.KeyChar.ToString());
            }
            else
            {
                number = 0;
            }

            int k = number;

            Node node = sll.kthFromEnd(k);
            Console.WriteLine($"{k} is the {node.Value} node from the HEAD");
            //Console.WriteLine($"{node.Value} is the {k}th node from the HEAD");

            Console.ReadLine();
        }



    }
}
