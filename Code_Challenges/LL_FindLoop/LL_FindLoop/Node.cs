using System;
using System.Collections.Generic;
using System.Text;

namespace LL_FindLoop
{
    class Node
    {
        public static Node head { get; internal set; }

        public int Value { get; set; }
        public Node Next { get; set; } = null;
    }
}
