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


            Console.WriteLine(" The hash table lools like {KeyPair} + {It's Value}");
            Console.WriteLine(newtabe.Contain("Key1"));
            Console.WriteLine(newtabe.Contain("Key2"));
            Console.WriteLine(newtabe.Contain("Key3"));


            var x = newtabe.ToString();
            Console.WriteLine(x);



            Console.ReadLine();


        }
    }
}
