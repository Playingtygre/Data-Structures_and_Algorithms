using System;
using System.Collections.Generic;
using System.Text;

namespace Stacks
{

    public class Stack
    {
        // Creating the stack 
        public Node Head { get; set; }
        public Node Tail { get; set; }

        //Method for setting up the link
        public Stack(Node node)
        {
            Head = node;

        }

        //Method for push setting the tail
        public void Push(Node node)
        {
            node.Next = Head;
            Head = node;
        }

       
        //Method Pop, sets a tempoary node to head, then setting the next node to head.
        public int Pop()
        {
            try
            {
                Node tempoary = Head;
                Head = Head.Next;
                return tempoary.Value;
            }
            catch (Exception)
            {
                Console.WriteLine("bottom of the Stack");
                Console.ReadKey();
                throw;
            }
     
        }

        // Method that allows for Peek Method
        public int Peek()
        {
            return Head.Value;
        }


    }
}
