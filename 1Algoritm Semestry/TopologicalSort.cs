using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1Algoritm_Semestry
{    
        public class Graph
        {
            // переменная для подсчета количества итераций.
            private int count = 0;

            // Номер вершины.
            private int V;

            // Лист смежных вершин.
            private List<List<int>> adj;

            // Конструктор.
            public Graph(int v)
            {
                V = v;
                adj = new List<List<int>>(v);
            for (int i = 0; i < v; i++)
                adj.Add(new List<int>());
            }

            // Функция по добавлению смежной вершины в граф.
            public void AddEdge(int v, int w) { adj[v].Add(w); }

            // Рекурсивная функция по вызову Топологической сортировки.
            public void TopologicalSortUtil(int v, bool[] visited,
                                     Stack<int> stack)
            {

                // Помечаем посещенные вершины
                visited[v] = true;

                // Если у вершины есть смежные с ней,
                // то рекурсивно вызывается сорировка для них 
                foreach (var vertex in adj[v])
                {
                    if (!visited[vertex])
                        TopologicalSortUtil(vertex, visited, stack);
                }

                // Записывает посещенную вершину в стек.
                stack.Push(v);
                count++;

            }

            // Функция Топологической сортировки, рекурсивно использует
            public void TopologicalSort()
            {
                Stack<int> stack = new Stack<int>();

                // Все вершины по умолчанию не посещены
                var visited = new bool[V];

                // Рекурсивно вызывается алгоритм топологической сортировки
                for (int i = 0; i < V; i++)
                {
                    if (visited[i] == false)
                        TopologicalSortUtil(i, visited, stack);
                }
                Console.WriteLine(count);

            // Вывод вершин стека в порядке упорядочивания
                foreach (var vertex in stack)
                {
                    Console.Write(vertex + " "  );                
                }
            
            }
        }
}
