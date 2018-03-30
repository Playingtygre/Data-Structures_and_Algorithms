using System;

namespace LinkList
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");


            // watch videos from 3/23/18 this will give you a better understanding 


            //Calls pulbic Node class, which creates a new node get method, set method.
            Node node0 = new Node();
            Node node1 = new Node();
            Node node2 = new Node();
            Node node3 = new Node();
            Node node4 = new Node();
            Node node5 = new Node();

            //sets the next node to the mentioned above value.
            node0.Next = node1;
            node1.Next = node2;
            node2.Next = node3;
            node3.Next = node4;
            node4.Next = node5;
            node5.Next = null;

            //setting node value
            node1.value = 2;
            node2.value = 3;
            node3.value = 4;
            node4.value = 5;
            node5.value = 6;

            SinglyLinked sll = new SinglyLinked(node1); // If this is set later than node1, list starts there

            sll.PrintAllNodes(); // traverses the node, prints them all out

            sll.Find(3); // Traverses the node, prints out the parameter if found

            sll.AddAtEnd(11); // Adds new node and value to the end of the list.

            int dummy = sll.Add(1); // Adds new node and value to the start of the list.

            Console.WriteLine("Here's the list again");
            sll.PrintAllNodes(); // prints the list again to show it worked.
            Console.ReadLine();



        }
    }
}
