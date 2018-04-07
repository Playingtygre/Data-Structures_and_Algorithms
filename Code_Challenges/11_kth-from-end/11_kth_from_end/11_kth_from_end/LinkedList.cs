using System;
using System.Collections.Generic;
using System.Text;

namespace Linked_List
{
    public class SinglyLinked
    {
        public Node Head { get; set; }

        public SinglyLinked(Node node)
        {
            Head = node;
        }

        public void PrintAllNodes()
        {
            Node cur = Head;
                             
            while (cur.Next != null)
            {
                Console.WriteLine($"This is the {cur.Value}Current Value ");
                cur = cur.Next;
            }
            Console.WriteLine($"cur.Value: {cur.Value}");
        }

        public Node kthFromEnd(int k)
        {
            Node cur = Head; 

            try
            {
                int length = 0; 
                while (cur.Next != null)
                {
                   
                    length++;
                    cur = cur.Next; 
                }
                length++; 
               
                cur = Head; 
                for (int i = 0; i < (length - k - 1); i++)
                {
                    cur = cur.Next;
                }
                if (k > length)
                    throw new System.ArgumentException("k is greater than length of list");
                return cur;
            }

            catch (Exception)
            {

                Console.WriteLine("k is greater than length of list");
            }
            return cur;

        }

    }
}
