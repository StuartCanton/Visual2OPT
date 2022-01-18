using GraphAlgorithms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visual2OPT
{
    internal class TestHungarian2
    {
        private readonly Random _random;

        public TestHungarian2(Random random)
        {
            const int SIZE = 10;
            _random = random;
            //var matrix = generateMatrix(SIZE);
            int[,] matrix = exampleMatrix();


            printMatrix(matrix);

            //var algorithm = new HungarianMethod(matrix);
            var algorithm = new MyHungarianMethod(matrix);

            algorithm.Step1();
            printMatrix(matrix);

            algorithm.Step2();
            printMatrix(matrix);

            var result = algorithm.Run();
            printArray(result);
            

        }


        private int[,] exampleMatrix()
        {
            int[,] matrix = new int[4, 4];
            matrix[0, 0] = 82;matrix[0, 1] = 83;matrix[0, 2] = 69;matrix[0, 3] = 92;           
            matrix[1, 0] = 77;matrix[1, 1] = 37;matrix[1, 2] = 49;matrix[1, 3] = 92;           
            matrix[2, 0] = 11;matrix[2, 1] = 69;matrix[2, 2] = 5; matrix[2, 3] = 86;           
            matrix[3, 0] = 8; matrix[3, 1] = 9; matrix[3, 2] = 98;matrix[3, 3] = 23;

            return matrix;
        }

        private int[,] generateMatrix(int size)
        {
            var matrix = new int[size, size];

            //var rnd = new Random();
            for (int i = 0; i < size; i++)
                for (int j = 0; j < size; j++)
                    matrix[i, j] = _random.Next() % size;

            return matrix;
        }

        private void printMatrix(int[,] matrix)
        {
            Console.WriteLine("Matrix:");
            var size = matrix.GetLength(0);
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                    Console.Write("{0,5:0}", matrix[i, j]);
                Console.WriteLine();
            }
        }

        private void printArray(int[] array)
        {
            Console.WriteLine("Array:");
            var size = array.Length;
            for (int i = 0; i < size; i++)
                Console.Write("{0,5:0}", array[i]);
            Console.WriteLine();
        }
    }
}
