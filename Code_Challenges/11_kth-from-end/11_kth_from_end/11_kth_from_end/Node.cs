using System;
using System.Collections.Generic;
using System.Text;

namespace Linked_List
{
    public class Node
    {
        private int[] v;

        public Node(int[] v)
        {
            this.v = v;
        }

        public int Value { get; set; }
        public Node Next { get; set; }
    }
}
