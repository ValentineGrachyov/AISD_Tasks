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
            var a = new Treap(5, 15,
                    new Treap(3, 13, new Treap(2, 10)),
                    new Treap(6, 14));

            a.Split(5,out a.LeftChild,out a.RightChild);

            a.Add(8);
            a.Print(a);
            Console.ReadLine();
        }
    }
}
