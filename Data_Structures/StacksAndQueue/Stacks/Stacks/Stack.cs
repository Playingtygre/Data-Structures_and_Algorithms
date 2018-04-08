using System;
using System.Collections.Generic;
using System.Text;

namespace Stacks
{
    /* A PORTION OF THE CODE WAS GIVEN TO US BY AMANAD IVERSON*/
    /* Parts of this code were copied from Kevin Farrow*/
    public class Stack
    {
        public Node Top { get; set; }

        public Stack(Node node)
        {
            Top = node;
        }
        //method for addin a node to the head
        public void Push(Node node)
        {
            node.Next = Top;
            Top = node;
        }
        //method to take a node from the head
        public Node Pop()
        {
            Node pop = Top;
            Top = Top.Next;
            return pop;
        }

        //method to look at stack on the top/head
        public Node Peek()
        {
            return Top;
        }
            

    }
}
