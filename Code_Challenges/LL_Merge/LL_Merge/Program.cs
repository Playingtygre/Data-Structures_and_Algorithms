using SinglyLinkedList;
using System;


namespace SinglyLinkedList
{
    class Program
    {

        public static void Main(string[] args)
        {

            SinglyLinkedList testList = new SinglyLinkedList();
            testList.Add(1);
            testList.Add(2);
            testList.Add(3);
            testList.Add(4);
            testList.Add(5);
            Console.WriteLine(testList.Find(3).Value);
            Console.ReadLine();
            Console.WriteLine(testList.PrintToString());
            Console.WriteLine();
            testList.AddToEnd(0);
            Console.WriteLine(testList.PrintToString());
            Console.ReadLine();
           // testList.InsertBefore(3, 10);
            Console.WriteLine(testList.PrintToString());
            Console.ReadLine();
            testList.InsertAfter(3, 12);
            Console.WriteLine(testList.PrintToString());
            Console.ReadLine();
            Console.WriteLine(testList.ListLength());
            Console.ReadLine();
            //Console.WriteLine(testList.kthFromEnd(3).Value);
            Console.ReadLine();


  

            SinglyLinkedList testListOne = new SinglyLinkedList();
            testListOne.Add(1);
            testListOne.Add(2);
            testListOne.Add(3);
            testListOne.Add(4);
            testListOne.Add(5);

            SinglyLinkedList testListTwo = new SinglyLinkedList();
            testListTwo.Add(6);
            testListTwo.Add(7);
            testListTwo.Add(8);
            testListTwo.Add(9);

            Console.WriteLine("here are the two strings");
            Console.WriteLine(testListOne.PrintToString());
            testListTwo.PrintToString();

            Console.WriteLine("Merging of two lists");
            testListOne.MergeLists(testListTwo);
            Console.WriteLine(testListOne.PrintToString());
            Console.ReadLine();



        }
    }
}
