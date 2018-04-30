using System;

namespace K_aryTrees
{
    class Program
    {
        static void Main(string[] args)
        {
            
          

            Node<byte> n = new Node<byte>(10);
            Tree<byte> tree = new Tree<byte>(n);
            Node<byte> left = new Node<byte> (3, new byte[] { 5, 4, 2 });


            tree.Root.Children.Add(left);
            tree.Add(10, 7);
            tree.Add(7, 1);
            tree.Add(7, 7);
            tree.Add(7, 9);
            tree.Add(9, 9);
            Console.WriteLine("Pre Order traverse: ");

           


            Tree<byte>.Method render = x => Console.Write($"{x.Value} ");
            tree.PreOrderTraverse(render);
            Console.ReadKey();


            Console.WriteLine("The file will build and manipulate this tree:\n" +
             "        10        \n" +
             "      /   \\       \n" +
             "     3      7      \n" +
             "   / | \\  / | \\  \n" +
             "  5 4  2  1  7  9");
            Console.ReadKey();

        }
    }
}