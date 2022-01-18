using SharedLibrary.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visual2OPT
{
    internal class MinimumSpanningTreeOld
    {
        private readonly PriorityQueue<Edge,int> _queue;
        private readonly int _size;
        private int[] _s;
        public string LastQueue { get; set; }
        public MinimumSpanningTreeOld(Matrix am)
        {
            _size = am.Costs.GetLength(0);
            _s = new int[_size];
            _queue = new PriorityQueue<Edge,int>();
            //am.Adjacencey = GetMSTFromEdges(
        }

        public int[,] GetMSTFromEdges(Edge[] edges)
        {
            _s = _s.Select(e=>e=0).ToArray();
            _s[0] = 1;
            int[,] tree = new int[_size, _size];
            _queue.Clear();

            for (int i = 0; i < edges.Length; i++)
            {
                _queue.Enqueue(edges[i], edges[i].Distance);
            }

            LastQueue = _queue.QueueToString();

            //while (_queue.Count != 0)
            //{
            //    Edge v = _queue.Dequeue();
            //    int from = v.Start;
            //    int to = v.End;
            //    if (_s[from] == 1 && _s[to] == 0 || _s[from] == 0 && _s[to] == 1)
            //    {
            //        tree[from, to] = 1;
            //        tree[to, from] = 1;
            //    };
            //    _s[to] = 1;
            //}

            while (_queue.Count > 9)
            {
                Edge v = _queue.Dequeue();
                int from = v.Start;
                int to = v.End;
                tree[from, to] = 1;
                tree[to, from] = 1;

                //Debug.Print($"{isCyclic(tree)}");
                if (isCyclic(tree))
                {
                    tree[from, to] = 0;
                    tree[to, from] = 0;
                }

            }
            return tree;

        }
        private List<List<int>> adj;
        // This function is a variation of DFSUtil() in
        // https://www.geeksforgeeks.org/archives/18212
        private bool isCyclicUtil(int i, bool[] visited,bool[] recStack)                                      
        {
            Debug.Print($"i:{i},visted[i]:{visited[i]},recStack[i]:{recStack[i]}");
            // Mark the current node as visited and
            // part of recursion stack
            if (recStack[i])return true;
            if (visited[i])return false;
                
            visited[i] = true;
            recStack[i] = true;
            List<int> children = adj[i];

            foreach (int c in children)
                if (isCyclicUtil(c, visited, recStack)) 
                {
                    Debug.Print("here");
                    return true;
                }
            ;
                    
            recStack[i] = false;

            return false;
        }

        // Returns true if the graph contains a
        // cycle, else false.
        // This function is a variation of DFS() in
        // https://www.geeksforgeeks.org/archives/18212
        private bool isCyclic(int[,] graph)
        {
            adj = new List<List<int>>(_size);
            for (int i = 0; i < _size; i++)
                adj.Add(new List<int>());

            for (int i = 0; i < graph.GetLength(0); i++)
            {
                for (int j = 0; j < graph.GetLength(1); j++)
                {
                    adj[i].Add(graph[i, j]);
                }
            }
            //Debug.Print(adj.PrintToString());
            // Mark all the vertices as not visited and
            // not part of recursion stack
            bool[] visited = new bool[_size];
            bool[] recStack = new bool[_size];


            // Call the recursive helper function to
            // detect cycle in different DFS trees
            for (int i = 0; i < _size; i++)
            {
                Debug.Print($"Outer Loop i:{i}");
                if (isCyclicUtil(i, visited, recStack))
                {

                    return true;
                }
            }

                    
            return false;
        }


        //private bool isCyclic(int[,] graph)
        //{
        //    //dfs of graph

        //}


        //public string QueueToString(PriorityQueue<Edge, int> queue)
        //public string QueueToString()
        //{
        //    StringBuilder sb = new();
        //    PriorityQueue<Edge, int> result = new();
        //    result.EnqueueRange(_queue.UnorderedItems);

        //    while (result.TryDequeue(out Edge item, out int priority))
        //    {
        //        string start = $"{(char)(item.Start+65)}";
        //        string end = $"{(char)(item.End + 65)}";
        //        sb.AppendLine($"Item : {start}:{end}. Priority Was : {priority}");
        //    }
        //    return sb.ToString();
        //}

    }
}
