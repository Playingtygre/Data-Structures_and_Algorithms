using System;

namespace HashTable
{
    class Program
    {
        static void Main(string[] args)
        {
            HashTables newtabe = new HashTables();
            newtabe.Add("Key1", "Value1");
            newtabe.Add("Key2", "Value2");
            newtabe.Add("Key3", "Value3");

            Console.WriteLine(" The hash table looks like {KeyPair} + {It's Value}");
            Console.WriteLine("Let us add 3 Keys and see whats inside of them");

            Console.WriteLine(newtabe.Contain("Key1"));
            Console.WriteLine(newtabe.Contain("Key2"));
            Console.WriteLine(newtabe.Contain("Key3"));


            Console.ReadLine();


        }
    }
}
