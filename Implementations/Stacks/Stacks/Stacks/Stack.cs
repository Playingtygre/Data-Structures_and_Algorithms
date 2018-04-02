using System;
using System.Collections.Generic;
using System.Text;

namespace Stacks
{

    public class Stack
    {

        public Node Head { get; set; }
        public Stack(Node node)
        {
            Head = node;

        }

        public void Push(Node node)
        {
            node.Next = Head;
            Head = node;
        }

        //pulling a value from the top of the stack
        public void Pop(Node node)
        {
            if (Head == null)
            {
                Console.WriteLine("you are at the bottom of the stack");
                return;
            }
            Console.WriteLine("Item popped is {0}", Head.Next);
            Head = node.Next;
        }

        public Node Peek() => Head;
    }
}
