using System;
using System.Collections.Generic;
using System.Text;

namespace Stacks
{
    class Ques
    {
        //Creating a Node with an Object Constructor
        public Node Head { get; set; }
        public Node Tail { get; set; }


        //setting up queue node , Check the drawing 
        public Ques(Node node)
        {
            Head = node;
   
        }

        //Method that is adding node at the end
        public void Enqueue(Node node)
        {

            //node.Next = Head;
            //Head = node;

            node.Next = Tail;
            Tail = node;

            /*Head = node.next;
            Tail = node;*/

        }

        //Method for removing a node across
        public int Dequeue()
        {
            try
            /* This is setting up a tempoary node which sets the
             * Next.Node to the Tempoary node, if the Temoary node finds
             * null then this is the end of the queue list.
             */


            {   //setting a temporary node
                int value = Head.Value;
                // node head is the next value in line
                Node temp = Head.Next;
                //if the node head finds last one then  it returns the value.
                Head.Next = null;
                Head = temp;
                return value;
            }
            catch (Exception)
            {
                Console.WriteLine("This is the Bottom of the Queue");
                Console.ReadKey();
                throw;
            }
        }

        //Remember that you can only peek at the top of the node.
        public int Peek()
        {
            return Head.Value;
        }




    }//Bottom of the public void
}