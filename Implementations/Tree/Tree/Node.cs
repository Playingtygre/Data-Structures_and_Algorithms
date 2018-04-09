using System;
using System.Collections.Generic;
using System.Text;

namespace Tree
{
    class Node
    {
        //Remember that nodes have left and right children.
        public int Value { get; set; } // this can also be data
        // Pointers to the data Left and Right
        public Node LeftChild { get; set; }
        public Node RightChild { get; set; }
    }
}
