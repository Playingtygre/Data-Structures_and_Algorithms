using SinglyLinkedList;
using System;
using System.Collections.Generic;
using System.Text;

namespace SinglyLinkedList
{
  
        public class LinkedList
        {
            public Node Head { get; protected set; }

            public int Count;

            /// <summary>
            /// creates an instance of a Linked List
            /// </summary>
            public LinkedList(Node node)
            {
                Head = new Node
                {
                    Next = node
                };
                Count++;
            }

            /// <summary>
            /// add a new Node to the front/"Head" of the Linked List
            /// </summary>
            /// <param name="data">int type for the Value of the Node</param>
            public void Add(Node node)
            {
                node.Next = Head.Next;
                Head.Next = node;
                Count++;
            }

            /// <summary>
            /// checks the Linked List to see if the input node value
            /// exists in the Linked List
            /// </summary>
            /// <param name="data">int type of search value</param>
            /// <returns>the Node if it exists</returns>
            public Node Find(int data)
            {
                Node currentCheck = Head.Next;
                Node result = null;
                for (int i = 0; i < Count; i++)
                {
                    if (currentCheck.value == data)
                    {
                        result = currentCheck;
                    }
                    else
                    {
                        currentCheck = currentCheck.Next;
                    }
                }
                return result;
            }

            /// <summary>
            /// gets the length of the Linked List
            /// </summary>
            /// <returns>int type of the current length</returns>
            public int Length()
            {
                return Count;
            }

            public void Append(Node node)
            {
                Node curr = Head.Next;
                while (curr.Next != null)
                {
                    if (curr.Next.Next == null)
                    {
                        curr.Next.Next = node;
                        node.Next = null;
                        break;
                    }
                    else
                    {
                        curr = curr.Next;
                    }
                }
            }

            public void InsertBefore(int insert, int before)
            {
                Node newNode = new Node();
                newNode.value = insert;
                Node curr = Head.Next;
                while (curr.Next != null)
                {
                    if (curr.Next.value == before)
                    {
                        newNode.Next = curr.Next;
                        curr.Next = newNode;
                        break;
                    }
                    else
                    {
                        curr = curr.Next;
                    }
                }
            }

            public void InsertAfter(int insert, int after)
            {
                Node newNode = new Node();
                newNode.value = insert;
                Node curr = Head.Next;
                while (curr.Next != null)
                {
                    if (curr.Next.value == after)
                    {
                        newNode.Next = curr.Next;
                        curr.Next = newNode;
                        break;
                    }
                    else
                    {
                        curr = curr.Next;
                    }
                }
            }

        }
    
}
