using System;
using System.Collections.Generic;
using System.Text;

namespace Stacks
{
    /* A PORTION OF THE CODE WAS GIVEN TO US BY AMANAD IVERSON*/

    public class Stack
    {
        public Node Top { get; set; }

        public Stack(Node node)
        {
            Top = node;
        }

        public void Push(Node node)
        {
            node.Next = Top;
            Top = node;
        }

        public Node Pop()
        {
            Node pop = Top;
            Top = Top.Next;
            return pop;
        }

        public Node Peek()
        {
            return Top;
        }
            

    }
}
