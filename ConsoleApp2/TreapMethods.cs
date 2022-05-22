using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class TreapMethods
    {
        public Treap Merge(Treap L, Treap R)
        {
            if (L == null)
            { return R; }
            if (R == null)
            { return L; }


            if (L.y <= R.y)
            {
                var newTree = Merge(L, R.LeftChild);
                return new Treap(R.x, R.y, newTree, R.RightChild);
            }
            else
            {
                var newTree = Merge(L.RightChild, R);
                return new Treap(L.x, L.y, L.LeftChild, newTree);
            }
        }

        public Treap Split(Treap treap, int key, out Treap L, out Treap R )
        {
            L = null;
            R = null;

            if (treap == null) return null;
            if(treap.x < key)
            {
                var newTree = Split(treap.RightChild, key, out L, out R);                
                return L = new Treap(treap.x, treap.y, treap.LeftChild,newTree );
            }
            else
            {
                return  R = new Treap(treap.x,treap.y, Split(treap.LeftChild, key, out L, out R), treap.RightChild);
            }
        }

        public Treap Add(Treap treap, int x, int y)
        {
            Treap L = null;
            Treap R = null;
            Treap a = new Treap(x, y);
            Split(treap, x, out L, out R);
            var c = Merge(Merge(L, a), R);
            return c;            
        }

        public Treap Remove(Treap treap, int x)
        {
            Treap L = null;
            Treap R = null;
            Treap M = null;
            Split(treap, x-1 , out L, out R); 
            Split(treap.RightChild, x, out M, out R);
            return Merge(L, R);
            
            
        }

        public void PrintTree(Treap treap, string line = "")
        {
            if (treap != null)
            {
                PrintTree(treap.LeftChild, line);
                Console.Write($"{treap.x} => ");
                PrintTree(treap.RightChild, line);
            }
            
        }
    }
}
