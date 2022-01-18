using SharedLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visual2OPT
{
    public class MinimumSpanningTree
    {
        private readonly PriorityQueue<Edge, int> _queue;
        private readonly int _size;
        private readonly SetUnionFactory _setUnionFactory;
        
        private SetUnion _setUnion;
        private Graph _graph; 

        public MinimumSpanningTree(Graph graph)
        {
            _graph = graph;
            _size = _graph.Nodes.Length;
            _queue = new PriorityQueue<Edge,int>(_size);
            _setUnionFactory = new SetUnionFactory();
            _setUnion = _setUnionFactory.GetSetUnion(_size);

        }
        public int[,] GetMSTFromEdges(Edge[] edges)
        {
            //_s = _s.Select(e => 0).ToArray();
            //_s[0] = 1;
            int[,] tree = new int[_size, _size];
            _queue.Clear();

            for (int i = 0; i < edges.Length; i++)
            {
                _queue.Enqueue(edges[i], edges[i].Distance);
            }


            while (_queue.Count > 9)
            {
                Edge v = _queue.Dequeue();
                int from = v.Start;
                int to = v.End;
                tree[from, to] = 1;
                tree[to, from] = 1;

                //Debug.Print($"{isCyclic(tree)}");
                //if (isCyclic(tree))
                //{
                //    tree[from, to] = 0;
                //    tree[to, from] = 0;
                //}

            }
            return tree;

        }

    }
}
