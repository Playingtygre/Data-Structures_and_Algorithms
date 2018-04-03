using System;
using Stacks;

namespace Stacks
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            


            Node node0 = new Node() { Value = 4 };
            Node node1 = new Node() { Value = 5 };
            Node node2 = new Node() { Value = 6 };

            Stack stack = new Stack(node0);
            
            //Knocks off the tope of the node list
            stack.Push(node1);
            stack.Push(node2);

            Console.WriteLine(stack.Peek().Value);
            Console.ReadLine();
        }
    }
}
