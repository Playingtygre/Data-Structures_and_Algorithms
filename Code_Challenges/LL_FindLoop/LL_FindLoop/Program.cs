using System;
using LL_FindLoop;
using static LL_FindLoop.LinkedList;

namespace LL_FindLoop
{
    class Program
    {
            /* Portions of this code were copied from Kevin Farrow */

      public static void Main(string[] args)
        {


            //Creating Object Constructor called testone

            SinglyLinkedList ll = new SinglyLinkedList(new int[] {1,2,3,4,5});
            Node current = ll.head;
            while (current != null)
            {
                current = current.Next;
            }

            Console.WriteLine(ll.hasLoop());
            Console.WriteLine(ll);
            
            /*
            SinglyLinkedList testListOne = new SinglyLinkedList();
            //adding nodes inside of linked list
            testListOne.Add(1);
            testListOne.Add(2);
            testListOne.Add(3);
            testListOne.Add(4);
            testListOne.Add(3);
            
            Console.WriteLine((testListOne.hasLoop()));
            Console.ReadLine();

            //creating Object constructor called testtwo
            SinglyLinkedList testListTwo = new SinglyLinkedList();
            Node current = testListTwo.head;
            while (current.Next != null)
            {
                current = current.Next;
            }
            current.Next = testListTwo.head.Next;
            //adding nodes inside of linked list
            testListTwo.Add(6);
            testListTwo.Add(7);
            testListTwo.Add(8);
            testListTwo.Add(9);

            Console.WriteLine(testListTwo.hasLoop());
            /*
            SinglyLinkedList();

            word = new SinglyLinkedList();
            word.Add(1);
            word.Add(1);
            word.Add(1);
            word.Add(1);
            word.Add(1);
            Console.WriteLine(word.hasLoop());


            SinglyLinkedList LoopList = new SinglyLinkedList();
            LoopList.Add(1);
            Node looope = GetLooope2(LoopList);
            LoopList.Add(2);
            LoopList.Add(3);
            LoopList.Add(4);
            LoopList.Add(5);
            LoopList.Add(3);
            LoopList.head = looope;

            Node runner = new Node();
            {
                runner.Next = Node.head;
            }

            Console.WriteLine(LoopList.PrintToString());
            Console.WriteLine((LoopList.hasLoop()));
            Console.ReadLine();

            int lemgth = ListLength();
            bool hasLoop = false;
            Node runner = new Node();
            runner.Next = head;
            for (int i = 0; i < lemgth; i++)
            {
                if (runner.Next == null) hasLoop = true;
            }
            return hasLoop;

            /* Portions of this code were copied from Kevin Farrow */
        }

        private static void GetLooope2(SinglyLinkedList LoopList)
        {
            LoopList.InsertAfter(1, 2);
        }

        private static void GetLooope1(SinglyLinkedList LoopList)
        {
            GetLooope(LoopList);
        }

        private static void GetLooope(SinglyLinkedList LoopList)
        {
            LoopList.Add(3);
        }

    }
}
