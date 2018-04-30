using System.Collections.Generic;

namespace K_aryTrees
{
    /*  Generics T tree
     */

    public class Tree<T>
    {

        /* This is the knary tree construtor 
         */
        // Setting up the generics <T > root 

        public Tree(Node<T> root)
        {
            //Root.<T> to Node.root
            Root = root;
        }

       

        //<T>root 
        public Tree(T rootValue)
        {
            //<T>.Root value set as value
            Root = new Node<T>() { Value = rootValue };
        }


        /* <T>.Root set
         */

        /* Setting up the properties of the <T> 
           */

        public Node<T> Root { get; set; }

        //
        public delegate void Method(Node<T> n);

        /*Traversing using PreOrder
         */

        public void PreOrderTraverse(Method func)
        {
            // find the root node
            func(Root);
            // append a child to the root node
            foreach (Node<T> n in Root.Children)
            {
                //<T>  creating a new tree
                Tree<T> t = new Tree<T>(n);
                t.PreOrderTraverse(func);
            }
        }


        // PostOrder Travesal brings in an argument of another method
        public void PostOrderTraverse(Method func)
        {

            //<T> A generics for Root-> children
            foreach (Node<T> n in Root.Children)
            {
                // adding children to the <T> generics
                Tree<T> t = new Tree<T>(n);
                t.PreOrderTraverse(func);
            }
            func(Root);
        }


        //Using queue for a for a traversal
        public void BreadthFirstTraverse(Method func)
        {
            
            Queue<Node<T>> q = new Queue<Node<T>>();
            q.Enqueue(Root);
            Node<T> current;
            while (q.TryDequeue(out current))
            {
                func(current);
                foreach (Node<T> n in current.Children)
                {
                    q.Enqueue(n);
                }
            }
        }


        /* Adding a node to the tree; 
         *  <T> is the generics to where to add.
         */

        public void Add(T target, T addition)
        {

            bool added = false;
            void AddConditionally(Node<T> current)
            {
                // at the current node.Value add the <T> node to the list 
                if (!added && current.Value.Equals(target))
                {
                    current.Children.Add(new Node<T> { Value = addition });
                    added = true;
                }
            }
            BreadthFirstTraverse(AddConditionally);
        }
    }
}