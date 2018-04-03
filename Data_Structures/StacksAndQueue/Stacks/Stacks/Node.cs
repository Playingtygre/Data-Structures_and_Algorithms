using System;
using System.Collections.Generic;
using System.Text;

namespace Stacks
{
    public class Node
    {
        // adding the abstraction Node class, Value and Nextt
        public int Value { get; set; }
        public Node Next { get; set; }
        public Node Tail { get; set; }
    }
}
