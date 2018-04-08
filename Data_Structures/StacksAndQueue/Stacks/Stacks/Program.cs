using System;
using Stacks;

namespace Stacks
{
    class Program
    {
        /* Parts of this code base is attributed to Kevin Farrow */
        static void Main(string[] args)
        {
            Console.WriteLine("Stacked Node list");
            Stack testStack = new Stack(new Node() { Value = 5 });
            testStack.Push(new Node() { Value = 20 });
            testStack.Push(new Node() { Value = 10 });
            Console.WriteLine("Bottom of stack -> [5][20][10] <- Top of Stack");
            Console.WriteLine("REMEMBER WE CAN ONLY LOOK AT ONE NODE AT A TIME");
            Console.WriteLine("LAST NODE PASSED IN WAS 10");
            //Looking at 10
            Console.WriteLine(testStack.Peek().Value);
            testStack.Pop();
            testStack.Push(new Node() { Value = 30});
            Console.WriteLine(testStack.Peek().Value);


            Console.WriteLine("Queue Node list");
            Queue testQueue = new Queue(new Node() { Value = 5 });
            testQueue.Enqueue(new Node() { Value = 10 });
            testQueue.Enqueue(new Node() { Value = 20 });
            Console.WriteLine("Front of stack -> [5][20][10] <- Tail of Stack");
            Console.WriteLine("REMEMBER WE CAN ONLY LOOK AT ONE NODE AT A TIME");
            Console.WriteLine("LAST NODE PASSED IN WAS 10");
            Console.ReadLine();

        }//Bottom of Main

    }
}
