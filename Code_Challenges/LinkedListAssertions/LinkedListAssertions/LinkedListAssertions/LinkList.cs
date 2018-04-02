using System;
using System.Collections.Generic;
using System.Text;
using LinkedListAssertions;

namespace LinkedListInsertions
{
    public class LinkList
    {

        private Node head;
        private Node current;
        public int Count;
    }

    public LinkedList()
    {
        head = new Node();
        current = head;
    }

}
