using System;
using System.Collections.Generic;
using System.Text;


namespace KnaryTree
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
            /*Remember if no left Node Exists then
             *  this will cause a switch*/
            if (node.LeftChild != node)
            {
                InOrder(node.LeftChild);
            }


            Console.WriteLine(node.Value);
            /*Remember is the node ends at the right 
            then kicks out and displays node value*/
            if (node.RightChild != null)
            {
                InOrder(node.RightChild);
            }

            Console.WriteLine(node.Value);

        }

        // THIS IS THE TRAVERSAL LIST  
        public void PreOrder(Node node)
        {
            Console.WriteLine(node.Value);
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

            Console.WriteLine(node.Value);
        }






    } //Bottom of the Tree Class
}