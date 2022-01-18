using SharedLibrary.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Visual2OPT
{
    internal class CostMatrix
    {
        private readonly int _n;
        private readonly int _m = int.MaxValue;
        private readonly Random _random;
        private readonly MatrixFactory _matrixFactory;
        private readonly EdgeFactory _edgeFactory;
        public Matrix Matrix { get; private set; }
        //public int[,] Cost { get; set; }
        //public Node[] Nodes { get; set; }
        public Edge[] Edges { get; set; }
        public string[] Labels { get; set; }
        public string DisplayCosts { get; set; }

        public CostMatrix(Node[] Nodes,Random random)
        {
            _n = Nodes.Length;
            _random = random;
            _matrixFactory = new MatrixFactory(_random);
            //_edgeFactory = new EdgeFactory();
            Matrix = _matrixFactory.GetMatrixWithRandomCosts(Nodes);
            //Cost = new int[_n, _n];
            //Nodes = _nodeFactory.GetNodes(_n;
            Labels = Nodes.Select(x=>x.Name).ToArray();
            Edges = _edgeFactory.GetEdges(Nodes);

            DisplayCosts = Matrix.CostToString(Nodes);

        }

        private int?[,] GetMatrixFromEdges(Node[] Nodes)
        {
            int size = Nodes.Length;
            var result = new int?[size, size];
            int? nullableValue= null;

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    //result[i, j] = Edges.Where(e=>e.Start==i && e.End==j)?.FirstOrDefault()?.Distance;
                    nullableValue = Edges.Where(e => e.Start == i && e.End == j)?.FirstOrDefault()?.Distance;
                    result[i, j] = nullableValue;
                }
            }
            return result;
        }

        //private int[,] RemoveNulls(int?[,] matrix)
        //{
        //    int[,] result = new int[matrix.GetLength(0), matrix.GetLength(1)];
        //    for (int i = 0; i < matrix.GetLength(0); i++)
        //    {
        //        for (int j = 0; j < matrix.GetLength(1); j++)
        //        {
        //            if(matrix[i, j] == null) result[i, j] = 99;
        //            else result[i, j] = (int) matrix[i, j];

        //        }
        //    }
        //}


        //private void DebugArray(string[] arr)
        //{
        //    for (int i = 0; i < arr.Length; i++)
        //    {
        //        Debug.Print(arr[i]);
        //    }
        //}

    }
}
