using System;
using System.Collections.Generic;
using System.Text;

namespace kth_from_end
{
    public class Node
    {
        /*Just like in the videos creating a node and setting its 
         * value, and next to each other.
        */
        public int Value { get; set; }
        public Node Next { get; set; } = null;

        public Node(int value)
        {
            Value = value;
        }

        public Node(int value, Node next)
        {
            Next = next;
            Value = Value;
        }

    }
}
