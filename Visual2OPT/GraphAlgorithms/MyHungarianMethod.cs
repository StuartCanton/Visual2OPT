using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphAlgorithms
{
    internal class MyHungarianMethod
    {
        private readonly int[,] _costMatrix;
        private int size;

        public MyHungarianMethod(int[,] costMatrix)
        {
            _costMatrix = costMatrix;
            size = _costMatrix.GetLength(0);



        }
        public int[] Run()
        {

            //step 1 substract row minima
            //step 2 subtract column minima
            //step 3 cover all zeros with a minimum number of lines
            //step 4 create additional zeros



            return new int[_costMatrix.GetLength(0)];
        }

        public void Step1()
        {
            //find row minima
            int[] minRowValue = new int[size];

            for (int i = 0; i < size; i++)
            {
                minRowValue[i] = _costMatrix[i, 0];
                for (int j = 1; j < size; j++)
                {
                    if (_costMatrix[i,j] < minRowValue[i]) minRowValue[i] = _costMatrix[i, j];
                }
            }

            //subtract row minima
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    _costMatrix[i, j] -= minRowValue[i];
                }
            }
        }
        public void Step2()
        {
            //find column minima
            int[] minColumnValue = new int[size];

            for (int i = 0; i < size; i++)
            {
                minColumnValue[i] = _costMatrix[0, i];
                for (int j = 1; j < size; j++)
                {
                    if (_costMatrix[j, i] < minColumnValue[i]) minColumnValue[i] = _costMatrix[j, i];
                }
            }

            //subtract column minima
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    _costMatrix[j, i] -= minColumnValue[i];
                }
            }
        }

        private int Minimum(int[] arr)
        {
            int min = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if(arr[i] < min)min = arr[i];
            }
            return min;
        }
    }
}
