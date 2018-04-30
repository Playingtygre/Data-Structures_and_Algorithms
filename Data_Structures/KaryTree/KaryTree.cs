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

        /*Traversing recursively
         */

        public void PreOrderTraverse(Method func)
        {
            func(Root);
            foreach (Node<T> n in Root.Children)
            {
                Tree<T> t = new Tree<T>(n);
                t.PreOrderTraverse(func);
            }
        }

        public void PostOrderTraverse(Method func)
        {
            foreach (Node<T> n in Root.Children)
            {
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

        public void Add(T target, T addition)
        {
            bool added = false;
            void AddConditionally(Node<T> current)
            {
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