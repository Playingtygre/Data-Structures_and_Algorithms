using System;
using System.Collections.Generic;
using System.Text;

namespace HashTable
{
    public class HashTables
    {

        /* Remember that the Hash Tables are Key-Pair, Values
         */

            // Link List is a doubly link list [{key},{value}]
        private LinkedList<Node>[] Table;

        //int of Hashtable has Prime Factor
        private int primeFactor = 599;


        //Lets create a new hash constructor with a doubly linked list 
        public HashTables()
        {
            Table = new LinkedList<Node>[1024]; 
            // table on instantiation
        }


        //Method for 
        public int GetHash(string key)
        {
            int hash = 0; 
            //Setting the hash start value to 0

            foreach (char item in key) hash += item;
            // for-each loop which takes {key} {item} adding {item}
            // So looks like [{key}-{item}-{item}]

            //Convert the string into an int

            hash = hash * primeFactor % Table.Length;
            // 0 = 0 X 599

            return hash;
        }

        public void Add(string key, string value)
        {
            Node newEntry = new Node() { Value = value, Key = key }; 
            //Object constructor to Store both key and value to ref later

            key = key.ToLower(); 
            //Normalize the key pairs

            int index = GetHash(key);
            // setting up index to the Key of hash
            //get our index to put the value into

            
            if (Table[index] == null)
            // Checks to see if we are at the end of the table
            {
                Table[index] = new LinkedList<Node>();
                //insert into the end the the table 
                Table[index].AddFirst(newEntry);
                //
            }
            else Table[index].AddFirst(newEntry);
            //New node entry point
        }


        /* Search method for finding things in our Hash Table
         */

        public string Contains(string key)
        {
            key = key.ToLower();
            //sets the key to normalize
            int index = GetHash(key);
            // 
            if (Table[index] == null) return null;
            foreach (Node node in Table[index])
            {
                if (node.Key.ToLower() == key) return node.Value;
            }

            return null; 
            //If we hashed out to something but it dosen't contain our key
        }


    }
}
