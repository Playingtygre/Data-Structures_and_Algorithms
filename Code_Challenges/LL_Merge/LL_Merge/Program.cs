using SinglyLinkedList;
using System;

namespace SinglyLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("It is Linked List ACTION TIME!!!!!");
            Node newNode = new Node  { value = 1 };
            Node newNode2 = new Node { value = 5 };
            Node newNode3 = new Node { value = 10 };
            Node newNode4 = new Node { value = 15 };
            Node newNode5 = new Node { value = 20 };
            Node newNode6 = new Node { value = 25 };
            Node newNode7 = new Node { value = 30 };
            Node newNode8 = new Node { value = 35 };


            LinkedList first = new LinkedList(newNode);

            Console.WriteLine("This is the current Linked List Head value");
            Console.WriteLine(first.Head.Next.value);

            // Add a new node
            first.Add(newNode2);

            Console.WriteLine("This is the current Linked List Head value");
            Console.WriteLine(first.Head.Next.value);

            // add the rest of the nodes
            first.Add(newNode3);
            first.Add(newNode4);
            first.Add(newNode5);
            Console.WriteLine();

            Console.Write("HEAD ->");
            Node curr = first.Head.Next;
            for (int i = 0; i < first.Length(); i++)
            {
                Console.Write(" " + curr.value + " ->");
                curr = curr.Next;
            }
            Console.Write(" NULL");



            LinkedList second = new LinkedList(newNode6);
            second.Add(newNode7);
            second.Add(newNode8);


            MergeLists(first, second);
            Console.ReadLine();

        }


        //commented out for Singly Linked List Submission
        public static Node MergeLists(LinkedList first, LinkedList second)
        {
            LinkedList baseList;
            LinkedList secondList;
            if (first.Length() >= second.Length())
            {
                baseList = first;
                secondList = second;
            }
            else
            {
                baseList = second;
                secondList = first;
            }

            Node curr = baseList.Head.Next;
            Node temp = curr.Next;
            Node feedNode = secondList.Head.Next;
            do
            {
                curr.Next = feedNode;
                curr = curr.Next;
                curr.Next = temp;
                temp = temp.Next;
                curr = curr.Next;
                feedNode = feedNode.Next;
                if (feedNode == null)
                {
                    curr.Next = temp;
                    temp = temp.Next;
                    curr = curr.Next;
                }

            } while (curr.Next != null);
            return baseList.Head;
        }



    }
    
}
