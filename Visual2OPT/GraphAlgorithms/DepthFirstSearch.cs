using SharedLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visual2OPT.GraphAlgorithms
{
    internal class DepthFirstSearch
    {

        public DepthFirstSearch(Edge[] MST)
        {
            Console.WriteLine("Yo");
            Console.WriteLine(MST.Length);
            Console.WriteLine(MST[0].EdgeToString());//start

            int maxNum = 0;
            
            foreach(Edge e in MST)
            {
                Console.WriteLine($"Start:{e.Start},End:{e.End}");
                //Console.WriteLine($"{(char)(e.Start + 65)}");
                if(e.Start>maxNum)maxNum = e.Start;
                if(e.End>maxNum)maxNum = e.End;
            }

            //var vertices = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            var vertices = Enumerable.Range(0, maxNum+1).ToList();
            Console.WriteLine("Vertices:"+vertices.Count);
            //var edges = new[]{Tuple.Create(1,2), Tuple.Create(1,3),
            //    Tuple.Create(2,4), Tuple.Create(3,5), Tuple.Create(3,6),
            //    Tuple.Create(4,7), Tuple.Create(5,7), Tuple.Create(5,8),
            //    Tuple.Create(5,6), Tuple.Create(8,9), Tuple.Create(9,10)};

            var edgesList = new List<Tuple<int,int>>();
            foreach (Edge e in MST)
            {
                edgesList.Add(Tuple.Create(e.Start, e.End));
            }

            var graph = new Graph<int>(vertices, edgesList.ToArray());
            var algorithms = new Algorithms();

            Console.WriteLine("DFS");
            var result = algorithms.DFS(graph, 2).Select(e => $"{(char)(e + 65)}");
            //Console.WriteLine(string.Join(", ", algorithms.DFS(graph, 2)));
            Console.WriteLine(string.Join(", ", result));
            //# 1, 3, 6, 5, 8, 9, 10, 7, 4, 2
            Console.WriteLine("+++++++++++++++++++++++++++++++++++++++");



        }
    }

    public class Algorithms
    {
        public HashSet<T> DFS<T>(Graph<T> graph, T start)
        {
            var visited = new HashSet<T>();

            if (!graph.AdjacencyList.ContainsKey(start))
                return visited;

            var stack = new Stack<T>();
            stack.Push(start);

            while (stack.Count > 0)
            {
                var vertex = stack.Pop();

                if (visited.Contains(vertex))
                    continue;

                visited.Add(vertex);

                foreach (var neighbor in graph.AdjacencyList[vertex])
                    if (!visited.Contains(neighbor))
                        stack.Push(neighbor);
            }

            return visited;
        }
    }
}
