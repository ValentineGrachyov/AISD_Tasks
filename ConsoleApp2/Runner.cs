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
            Treap L = null;
            Treap R = null;
            var test = new TreapMethods();
            var a = new Treap(4, 4, new Treap(3, 2), new Treap(7, 1));
            var b = new Treap(2, 8, new Treap(1, 7), new Treap(6, 5));
            var c =  test.Merge(a, b);            
            c = test.Add(c, 8, 1);            
            test.PrintTree(c);
            Console.ReadLine();
        }
    }
}
