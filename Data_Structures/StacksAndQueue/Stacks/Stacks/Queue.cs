using System;
using System.Collections.Generic;
using System.Text;

namespace Stacks
{
    public class Queue
    {
        public Node Front { get; set; }

       
        public Queue (Node node)
        {
            node.Next = null;
            Front = node;
        }

        public void Enqueue(Node node)
        {
            Node runner = new Node();
            runner = Front;
            while (runner.Next != null)
            {
                runner = runner.Next;
            }
            runner.Next = node;
            node.Next = null;
        }

        public Node Dequeue()
        {
            Node pop = Front;
            Front = Front.Next;
            return pop;
        }

        public Node Peek() => Front;
    }
}//Bottom of the public void