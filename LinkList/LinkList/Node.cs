using System;
using System.Collections.Generic;
using System.Text;

namespace LinkList
{
    public class Node
    {

        // This is the get set method, program.cs pulls from this list for Node Value, and Node Next. 
        public int value { get; set; }
        public Node Next { get; set; }
    }
}
