﻿using System;
using System.Collections.Generic;
using System.Text;

namespace LL_FindLoop
{
  class LinkedList
    {

        /* Portions of this code were copied from Kevin Farrow */

        //THIS IS THE SINGLEY LINKED LIST
        public class SinglyLinkedList
        {
            // SETTING THE NODE HEAD TO EMPTY
            public Node head = null;
            private int[] v;

            public SinglyLinkedList(int[] v)
            {
                this.v = v;
            }

            // CREATING A NEW NODE BY SETTING THE CURRENT
            public void Add(int value)
            {
                // IN THE OBJECT CONSTRUCTOR CREATES NEW NODE FROM NODE CLASS
                Node newNode = new Node();
                // SETTING THE NEW NODE TO THE HEAD 
                newNode.Next = head;
                // SETTING THE NEW NODE TO THE VALUE OF
                newNode.Value = value;
                // SWITCHING THE HEAD TO THE NEW NODE
                head = newNode;
            }


            // THIS METHOD FINDS THE TARGET VALUE OF A NODE
            public Node Find(int target)
            {
                //IF THE NODE IS NOT NULL PROCCED TO NEXT
                Node step = head;
                while (step.Next != null)
                {
                    if (step.Value == target)
                    {
                        return step;
                    }
                    step = step.Next;
                }
                return head;
            }

            // METHOD TO ADD INTERGERS TO VALUE OF NODE.NEXT 
            public void AddToEnd(int newValue)
            {
                Node runner = head;
                Node newNode = new Node();
                while (runner.Next != null)
                {
                    runner = runner.Next;
                }
                runner.Next = newNode;
                newNode.Next = null;
                newNode.Value = newValue;
            }

            //METHOD TO INSERT NODE
            public void InsertAfter(int targetValue, int newValue)
            {
                Node newNode = new Node();
                newNode.Value = newValue;
                Node targetNode = Find(targetValue);
                newNode.Next = targetNode.Next;
                targetNode.Next = newNode;
            }

            // METHOD TO PRINT ENTIRE NOT AS LONG AS THE NODE.NEXT IS NOT NULL
            public string PrintToString()
            {
                StringBuilder sb = new StringBuilder("");

                Node step = head;
                while (step.Next != null)
                {
                    sb.Append($"{step.Value} ");
                    step = step.Next;
                }
                sb.Append($"{step.Value} ");
                return sb.ToString();
            }

            public bool hasLoop()
            {
                int lemgth = ListLength();
                bool hasLoop = false;
                Node runner = new Node();
                runner.Next = head;
                for (int i = 0; i < lemgth; i++)
                {
                    if (runner.Next == null) hasLoop = true;
                }
                return hasLoop;
            }

            public int ListLength()
            {
                Node runner = new Node();
                runner.Next = head;
                int length = 0;
                while (runner.Next != null)
                {
                    length++;
                    runner = runner.Next;
                }
                return length;
            }

            /* Portions of this code were copied from Kevin Farrow */
        }

    }
}
