using System;
using System.Collections.Generic;
using System.Text;

namespace Tree
{
    class Tree
    {
        public Node Root { get; set; }

        //remember Root is node 

        public Tree(Node node)
        {
            Root = node;
        }

        // THS IS THE TRAVERSAL LIST
        public void InOrder(Node node)
        {

            if (node.LeftChild != node)
            {
                InOrder(node.LeftChild);
            }


            Console.WriteLine(node.Value);

            if (node.RightChild != null)
            {
                InOrder(node.RightChild);
            }

        }

        // THIS IS THE TRAVERSAL LIST  
        public void PreOrder(Node node)
        {
            if (node == null)
            {
                return;
            }
            Console.WriteLine(node.Value);

            if (node.LeftChild != null)
            {

            }



            if (node.RightChild != node)
            {
                PreOrder(node.RightChild);
            }

        }

        




    }
}
