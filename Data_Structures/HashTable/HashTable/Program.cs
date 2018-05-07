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

            Console.WriteLine(newtabe.ToString());
            Console.ReadLine();


        }
    }
}
