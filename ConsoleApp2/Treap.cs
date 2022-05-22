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
        
    }
}
