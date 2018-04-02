using System;
using LinkedListAssertions;
using LinkedListInsertions;

namespace LinkedListAssertions
{
    public class Program
    {
        static void Main(string[] args)
        {
            LinkList test = new LinkList();

            Node node0 = new Node();
            Node node1 = new Node();

            node0.Next = node1;
            node1.Next = null;

            Console.WriteLine(LinkList);
        }


    }
}
