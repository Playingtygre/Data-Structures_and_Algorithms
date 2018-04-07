using SinglyLinkedList;
using System;


namespace SinglyLinkedList
{
    class Program
    {
        /* Portions of this code were copied from Kevin Farrow */

        public static void Main(string[] args)
        {

            //Creating Object Constructor called testone

            SinglyLinkedList testListOne = new SinglyLinkedList();
            //adding nodes inside of linked list
            testListOne.Add(1);
            testListOne.Add(2);
            testListOne.Add(3);
            testListOne.Add(4);
            testListOne.Add(5);

            //creating Object constructor called testtwo
            SinglyLinkedList testListTwo = new SinglyLinkedList();
            //adding nodes inside of linked list
            testListTwo.Add(6);
            testListTwo.Add(7);
            testListTwo.Add(8);
            testListTwo.Add(9);

            Console.WriteLine("Here is Singly Link List one");
            Console.WriteLine(testListOne.PrintToString());
            Console.WriteLine("Here is singly link list two");
            Console.WriteLine(testListTwo.PrintToString());

            Console.WriteLine("Merging of two lists");
            testListOne.MergeLists(testListTwo);
            Console.WriteLine(testListOne.PrintToString());
            Console.ReadLine();
            /* Portions of this code were copied from Kevin Farrow */
        }
    }
}
