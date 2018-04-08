using System;
using System.Collections.Generic;
using System.Text;

namespace Stacks
{
    public class Queue
    {
        /* Parts of this code were copied from Kevin Farrow*/
        public Node Front { get; set; }

       
        public Queue (Node node)
        {
            node.Next = null;
            Front = node;
        }

        //pushed into the stack from the back
        public void Enqueue(Node node)
        {
            Node tail = new Node();
            tail = Front;
            while (tail.Next != null)
            {
                tail = tail.Next;
            }
            tail.Next = node;
            node.Next = null;
        }

        //Taken from the nodes at the front.
        public Node Dequeue()
        {
            Node pop = Front;
            Front = Front.Next;
            return pop;
        }

        //Method for looking at the Front
        public Node Peek() => Front;
    }
}//Bottom of the public void