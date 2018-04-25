using System;
using System.Collections.Generic;
using System.Text;

namespace Knary
{
    public class Node
    {
    
        public string Value { get; set; }
        public List<Node> Children { get; set; }
        public Node Next { get; set; }
        public Node()
        {
            Children = new List<Node>();
        }

    }
}
