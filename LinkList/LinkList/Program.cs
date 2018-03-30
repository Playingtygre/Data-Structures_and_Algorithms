using System;
using LinkList;


namespace LinkList
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is a Linked list");

            // Declare the nodes
            Node node1 = new Node();
            Node node2 = new Node();
            Node node3 = new Node();
            Node node4 = new Node();

            // Link the nodes
            node1.Next = node2;
            node2.Next = node3;
            node3.Next = node4;
            node4.Next = null;

            // Populate the nodes
            node1.value = 2;
            node2.value = 3;
            node3.value = 4;
            node4.value = 5;

            //This is the start of the singly node list.
            SinglyLinked sll = new SinglyLinked(node1);

            // SinglyLinked List Prints all nodes 
            sll.PrintAllNodes();

            // Traverses the node, prints out the parameter if found
            sll.Find(4); 

            sll.AddAtEnd(11); // Adds new node and value to the end of the list.

            int dummy = sll.Add(1); // Adds new node and value to the start of the list.

            Console.WriteLine("Show Current List");
            // prints the list again to show it worked.
            sll.PrintAllNodes(); 
            Console.ReadLine();
        }


    }
}