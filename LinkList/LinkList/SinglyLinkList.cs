using System;
using System.Collections.Generic;
using System.Text;
using LinkList;

namespace LinkList
{
    public class SinglyLinked
    {
        public Node Head { get; set; }

        
        public SinglyLinked(Node node)
        {
            Head = node;
        }

        public int AddAtEnd(int value)
        {
            Node cur = Head; // start of node list
            Node nodeLast = new Node(); // To be a new last node on the list

            // traverse the node
            while (cur.Next != null)
            {
                cur = cur.Next; // get the next node
            }
            // Now cur is the last node on the list
            nodeLast.Next = null; //  Point last node to null.  Necessary for making system know that this node exists.  Otherwise you'll get an "Object reference not set to an instance of an object" error
            cur.Next = nodeLast; // Point former last node to new last node
            nodeLast.value = value; // Populate last node.
            return value; // Only necessary for testing.  This particular data doesn't do anything.  It just writes to a list.

        }
        
        public int Add(int value)
        {
            Node node0 = new Node(); // To be the first node on the list

            node0.Next = Head; // Point new node to the Head
            Head = node0; // Point Head to new node
            node0.value = value; // Populate first node

            return value; // Only necessary for testing.  This particular data doesn't do anything.  It just writes to a list.
        }

      
        public void PrintAllNodes()
        {
            Node cur = Head; // start of node list
            // traverse the node
            while (cur.Next != null)
            {
                Console.WriteLine($"cur.Value: {cur.value}");
                cur = cur.Next; // get the next node
            }
            Console.WriteLine($"cur.Value: {cur.value}"); // Another call for cur.Value because the loop kicks out early
        }


        public void Find(int query)
        {
            Node cur = Head; // start of node list
            // traverse the node
            while (cur.Next != null)
            {
                if (cur.value == query)
                    Console.WriteLine($"I found {query}!");
                cur = cur.Next; 
            }
            if (cur.value == query) 
                Console.WriteLine($"I found {query}!");
        }


    }

}