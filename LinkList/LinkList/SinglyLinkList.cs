using System;
using System.Collections.Generic;
using System.Text;
using LinkList;

namespace LinkList
{
    public class SinglyLinked
    {
        public Node Head { get; set; }

        //sets current Head to node, this is kinda of the runner
        public SinglyLinked(Node node)
        {
            Head = node;
        }

        //method for adding traversing the list.
        public int AddAtEnd(int value)
        {
            Node cur = Head;
            Node nodeLast = new Node();

           
            while (cur.Next != null)
            {
                cur = cur.Next; // get the next node
            }
            
            nodeLast.Next = null;
            cur.Next = nodeLast; 
            nodeLast.value = value;
            return value; 

            // Bottom for the method for traversing the end of the list 
        }
        
        //Method for adding another node
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
                Console.WriteLine($"current Node Value: {cur.value}");
                cur = cur.Next; //points to the next node 
            }
            Console.WriteLine($"Current Node Value: {cur.value}"); // Another call for cur.Value because the loop kicks out early
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