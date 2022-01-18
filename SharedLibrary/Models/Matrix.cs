using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedLibrary.Models
{
    public class Matrix
    {
        public int[,] Costs { get; set; }
        public int[,] Adjacencey { get; set; }
    }


    public class MatrixFactory
    {
        private readonly Random _random;

        public MatrixFactory(Random random)
        {
            _random = random;
        }

        private Matrix GetEmptyMatrix(int size)
        {
            Matrix matrix = new Matrix() { Costs = new int[size, size], Adjacencey = new int[size, size] };
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    matrix.Costs[i, j] = int.MaxValue;
                    matrix.Adjacencey[i, j] = 0;
                }
            }
            return matrix;
        }

        public Matrix GetMatrixFromEdges(Edge[] edges, Node[] nodes)
        {
            Matrix matrix = GetEmptyMatrix(nodes.Length);
            foreach(Edge edge in edges)
            {
                matrix.Costs[edge.Start, edge.End] = edge.Distance;
                matrix.Costs[edge.End, edge.Start] = edge.Distance;
                matrix.Adjacencey[edge.Start,edge.End] = 1;
            }
            return matrix;
        }


        public Matrix GetMatrixWithRandomCosts(Node[] Nodes)
        {
            int n = Nodes.Length;
            Matrix matrix = new Matrix() { Costs = new int[n,n], Adjacencey = new int[n,n]};
            matrix.Costs = MakeSymmetricMatrix(n);
            return matrix;
        }

        private int[,] GetMatrix(int size)
        {
            var result = new int[size, size];

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    result[i, j] = _random.Next(1, 10);
                }
            }
            return result;
        }
        private int[,] MakeSymmetricMatrix(int size)
        {
            var m = GetMatrix(size);
            for (int i = 0; i < size; i++)
            {
                for (int j = size - 1; j >= i; j--)
                {
                    if (i == j) m[i, j] = int.MaxValue;
                    else m[j, i] = m[i, j];
                }
            }
            return m;
        }
    }


    public static partial class MatrixExtensions
    {
        public static string CostToString(this Matrix matrix, Node[] Nodes)
        {
            var names = Nodes.Select(x => x.Name).ToArray();
            return MatrixToString(matrix.Costs, "c", names, int.MaxValue);
        }

        public static string AdjacencyToString(this Matrix matrix, Node[] Nodes)
        {
            var names = Nodes.Select(x => x.Name).ToArray();
            return MatrixToString(matrix.Adjacencey, "a", names, int.MaxValue);
        }

        public static bool IsAdjacent(this Matrix matrix, Edge edge)
        {
            return (matrix.Adjacencey[edge.Start, edge.End] == 1 || matrix.Adjacencey[edge.End, edge.Start] == 1) ;
        }
        private static string MatrixToString(int[,] matrix, string label, string[] Names, int limit)
        {
            StringBuilder sb = new();
            sb.Append("");
            sb.Append($"{label} = ");
            sb.Append(new string(' ', 3));
            //PrintColumnHeaders();
            for (int i = 0; i < Names.Length; i++)
            {
                sb.Append($"{Names[i]}    ");
            }
            sb.Append("\n    ");
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                if (i > 0)
                    sb.Append("    ");
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (j == 0) { sb.Append($"{Names[i]}{new string(' ',3)}"); };

                    if (matrix[i, j] == limit)
                        sb.Append("- \t");
                    else
                        sb.Append(matrix[i, j] + new string(' ',3));

                }
                sb.AppendLine();
            }
            return sb.ToString();
        }
    }
}
