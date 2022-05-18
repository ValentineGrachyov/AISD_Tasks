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
        


        /// <summary>
        /// Методы для работы с структурой.
        /// </summary>
        /// <param name="L"></param>
        /// <param name="R"></param>
        /// <returns></returns>
        
        // Метод позволяющий объединять два декартовых дерева.
        public Treap Merge(Treap L, Treap R)
        {
            
        }

        // Метод для разделения дерева по ключу.
        public void Split(int x, Treap tree)
        {
                        
        }

        public Treap Add(int x, int y, Treap treap)
        {
            var lCopy = treap.LeftChild;
            var RCopy = treap.RightChild;
            var a = new Treap(x, y);
            Split(x, out treap.LeftChild, out treap.RightChild);
            return Merge(Merge(treap.LeftChild, a), treap.RightChild);
        }

        public Treap Remove(int x)
        {
            Treap l, m, r;
            Split(x ,out l,out r);
            r.Split(x + 1,out m,out r);
            return Merge(l, r);
        }

        // Обход дерева по упорядочиванию вершин.
        public void PrintTree(Treap treap)
        {
          if (treap != null)
          {
                PrintTree(treap.LeftChild);
                Console.Write($"{treap.x} => ");
                PrintTree(treap.RightChild);
          }
        }
    }
}
