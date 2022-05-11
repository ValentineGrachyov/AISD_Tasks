using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Treap
    {
        public int x;
        public int y;

        public Treap LeftChild;
        public Treap RightChild;
        
        

        public Treap(int x, int y, Treap LeftChild = null, Treap RightChild = null)
        {
            this.x = x;
            this.y = y;
            this.LeftChild = LeftChild;
            this.RightChild = RightChild;
        }
        


        //Методы
        public Treap Merge(Treap L, Treap R)
        {
            if(L == null)
                return R;

            if(R == null)
                return L;

            if(L.y < R.y)
            {
                var newR = Merge(L.RightChild, R);
                return new Treap(L.x,L.y,L.LeftChild,newR);
            }
            else
            {
                var newL = Merge(L, R.LeftChild);
                return new Treap(R.x,R.y,newL,R.RightChild);
            }


        }

        public void Split(int x, out Treap L, out Treap R)
        {
            Treap newTree = null;
            if (this.x <= x)
            {
                if (RightChild == null)
                    R = null;
                else
                    RightChild.Split(x, out newTree, out R);
                L = new Treap(this.x, y, LeftChild, newTree);
            }
            else
            {
                if (LeftChild == null)
                    L = null;
                else
                    LeftChild.Split(x, out L, out newTree);
                R = new Treap(this.x, y, newTree, RightChild);
            }
        }

        public Treap Add(int x)
        {
            Treap l, r;
            Split(x, out l, out r);
            return Merge(Merge(l,r),r);
        }

        public Treap Remove(int x)
        {
            Treap l, m, r;
            Split(x - 1,out l,out r);
            r.Split(x - 1,out m,out r);
            return Merge(l, r);
        }

        public void Print(Treap treap)
        {
          if (treap != null)
          {
                Print(treap.LeftChild);
                Console.WriteLine(treap.x);
                Print(treap.RightChild);
          }

        }
    }
}
