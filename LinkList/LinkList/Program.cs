using System;

namespace LinkList
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");


            // watch videos from 3/23/18 this will give you a better understanding 

            Node node0 = new Node();
            Node node1 = new Node();

            node0.Next = node1;
            node1.Next = null;

        }
    }
}
