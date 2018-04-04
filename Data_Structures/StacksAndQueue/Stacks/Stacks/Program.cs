using System;
using Stacks;

namespace Stacks
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Stacked Node list");
           //Stack();
           Queue();

          
        }


        // Setting up values for node list, Rememer the get set : methods
        /*
        public static void Stack()
        {
            Node node0 = new Node() { Value = 4 };
            Node node1 = new Node() { Value = 5 };
            Node node2 = new Node() { Value = 6 };
            Node node3 = new Node() { Value = 7 };

            // setting a constructor function up for a new stack setting (node0)
            Stack examplestack = new Stack(node0);

            Console.WriteLine("This is the example stack  [4]  node0 ; has a value of 4");
            //Peeking at the top of the stack because there is only one that we set.
            Console.WriteLine(examplestack.Peek());
            Console.ReadLine();
        
            //Creating a new Constructor, trying the push method;
            Stack examplePush = new Stack (node0);

            Console.WriteLine("Adding [5] [6] [7]  to the stack");
            examplestack.Push(node1);
            examplestack.Push(node2);
            examplestack.Push(node3);

            Console.WriteLine("Push/Adding itme to the top of [4] ");
            Console.WriteLine(examplestack.Peek());
            Console.ReadLine();

            Console.WriteLine("Now lets remove 2 nodes");
            examplestack.Pop();
            examplestack.Pop();
            Console.WriteLine(examplestack.Peek());
            Console.ReadLine();
            Console.WriteLine(" End of example stack : [4] [5]");
            Console.ReadLine();
            
        }*/

        public static void Queue()
        {
            //setting up a Queue values using a constructor function
            Node node0 = new Node() { Value = 1 };
            Node node1 = new Node() { Value = 2 };
            Node node2 = new Node() { Value = 3 };
            Node node3 = new Node()  {Value = 4 };

            // only 1 node in the queue
            Ques exampleQueue = new Ques(node0);
            Console.WriteLine("lets do a Queue  Example [1] ");
            Console.WriteLine("Lets peform a Enqueue ; [1]  <-[4] ");

            //Enqueue in the chain
            Console.WriteLine(exampleQueue.Peek());

            exampleQueue.Enqueue(node1);
            exampleQueue.Enqueue(node2);
            exampleQueue.Enqueue(node3);

            Console.WriteLine("AWSOME WE STUCK [4] NEXT TO [1], REMEMBER PEEK METHOD CAN ONLY SEE 1 NODE AT A TIME");
            Console.WriteLine(exampleQueue.Peek());
            Console.ReadLine();

            Console.WriteLine("LETS REMOVE THE [4] WITH A DEQUEUE");
            exampleQueue.Dequeue();
            Console.WriteLine("NEATO WE ONLY HAVE [1] NOW");
            Console.WriteLine(exampleQueue.Peek());
            Console.ReadLine();

        }


        /*
        Stack stack = new Stack(node0);

        //Knocks off the tope of the node list
        stack.Push(node1);
            stack.Push(node2);

            Console.WriteLine(stack.Peek().Value);
            Console.ReadLine();
            */

    }//Bottom of Main
}
