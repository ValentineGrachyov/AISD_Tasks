using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _1Algoritm_Semestry
{
    class Program
    {
        static void Main(string[] args)
        {            
            Graph g = new Graph(10_000);

                File.ReadAllLines(@"C:\Программирование\AISD_Tasks\1Algoritm Semestry\Graph.txt")
                    .Select(x => Array.ConvertAll(x.Split(','), int.Parse))
                    .ToList()
                    .ForEach(x => g.AddEdge(x[0], x[1]));        

            Console.WriteLine("Following is a Topological "
                              + "sort of the given graph");

            Stopwatch stopwatch = new Stopwatch();

            stopwatch.Start();

            // Function Call
            g.TopologicalSort();

            stopwatch.Stop();

            Console.WriteLine($"\n{stopwatch.ElapsedMilliseconds}");
            Console.ReadLine();
        }
    }
}
