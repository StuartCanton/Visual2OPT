using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedLibrary.Models
{
    public class Graph
    {
        public Node[] Nodes { get; set; }
        public List<Edge> Edges { get; set; }
        public Matrix Matrix { get; set; }
        public bool IsDirected { get; set; }
        public int[] Degree { get; set; } //outdegree of each node
    }

    public class GraphFactory
    {
        private readonly Random _random;
        private readonly NodeFactory _nodeFactory;
        private readonly EdgeFactory _edgeFactory;
        private readonly MatrixFactory _matrixFactory;

        public GraphFactory(Random random)
        {
            _random = random;
            _nodeFactory = new NodeFactory(_random);
            _edgeFactory = new EdgeFactory(_random);
            _matrixFactory = new MatrixFactory(_random);

        }

        public Graph GetGraph(int size)
        {
            Graph graph = new();
            graph.Nodes = _nodeFactory.GetNodes(size);
            graph.Edges = _edgeFactory.GetEdges(graph.Nodes).ToList();
            graph.Matrix = _matrixFactory.GetMatrixFromEdges(graph.Edges.ToArray(), graph.Nodes);

            return graph;
        }



    }
    public static class GraphExtensions
    {
        public static bool IsAdjacent(this Graph graph, Edge edge)
        {
            return (graph.Matrix.IsAdjacent(edge));
        }

        public static Edge[] MST(this Graph graph)
        {

            //edges into the queue
            //nodes into the setUnion

            int size = graph.Nodes.Length;
            Edge[] edges = graph.Edges.ToArray();
            List<Edge> result = new List<Edge>();
            PriorityQueue<Edge, int> _queue = new();
            SetUnionFactory _setUnionFactory = new();
            SetUnion setUnion = _setUnionFactory.GetSetUnion(size);

            int[,] tree = new int[size, size];
            _queue.Clear();

            for (int i = 0; i < edges.Length; i++)
            {
                _queue.Enqueue(edges[i], edges[i].Distance);
            }

            while (_queue.Count > 0)
            {
                Edge v = _queue.Dequeue();
                int from = v.Start;
                int to = v.End;
                if (setUnion.IsSameComponent(from, to)) continue;

                setUnion.UnionSets(from, to);
                v.isVisible=true;
                result.Add(v);
            }


            return result.ToArray();
        }
    }

}
