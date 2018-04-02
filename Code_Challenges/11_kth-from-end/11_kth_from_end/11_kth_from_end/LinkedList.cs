using System;
using System.Collections.Generic;
using System.Text;

namespace kth_from_end
{
    public class LinkedList
    {
        public Node Head { get; set; }
        public LinkedList(int value)
        {
            Head = new Node(value);
        }

        //method to add an array of values to a linked list
        public LinkedList(int [] values)
        {
            LinkedList l = new LinkedList(values[0]);
            for (int i = 1; i < values.Length; i++)
            {
                l.Add(values[i]);
            }
            Head = l.Head;
        }
        //method to add values to nodes
        public void Add(int value)
        {
            Node addition = new Node(value);
            Node old = Head;
            addition.Next = old;
            Head = addition;
        }

        // method to find a value by looking for and index
        public int Find(int value)
        {
            int index = 0;
            Node current = Head;
            do
            {
                if (current.Value == value)
                {
                    return index;
                }
                index++;
                current = current.Next;
            } while (current.Next != null);
            return -1;
        }

        //Method to count the entire length of the Node using a
        //for loop
        public int Length()
        {
            Node current = Head;
            int count = 1;
            while (current.Next != null)
            {
                count++;
                current = current.Next;
            }
            return count;
        }



    }
}
