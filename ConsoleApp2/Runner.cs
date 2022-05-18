using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public static class Runner
    {
        public static void Run()
        {
            var a = new Treap(7, 10,
                new Treap(4, 6,new Treap(2, 4, new Treap(0, 3,null,null), new Treap(3, 3, null, null)), new Treap(6, 2, new Treap(5, 1, null, null), null)),
                new Treap(13, 8, new Treap(9, 7, null, new Treap(11, 3, null, null)), new Treap(14, 4, null, null)));

            //a.Split(7,out a.LeftChild,out a.RightChild);

            a.Add(3,1, a);
            //a.Remove(4);
            a.PrintTree(a);
            Console.ReadLine();
        }
    }
}
