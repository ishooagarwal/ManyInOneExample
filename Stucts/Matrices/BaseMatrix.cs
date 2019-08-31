using Stucts.BaseInterface;
using System;

namespace Stucts.Matrices
{
    public class BaseMatrix : IExpireHelper
    {
        protected int maxRows = 0;
        protected int TotalLength = 0;
        protected int rank = 0;
        protected int rowLength = 0;
        protected int columnStarter = 0;
        protected int ElementCounter = 0;
        protected int iterationDone = 0;
        protected bool startSpiral = false;

        protected int[,] maty = new int[4, 3] {
            { 0,1,2},
            { 3,4,5},
            { 6,7,8},
            { 9,10,11}
        };

        protected int[,] mat = new int[3, 4] {
            { 0, 1, 20 ,30},
            { 2, 3, 21 ,31},
            { 4, 5, 22 ,32}
        };

        //{ 0, 1, 20 ,30,40,50},
        //    { 2, 3, 21 ,31,41,51},
        //    { 4, 5, 22 ,32,42,52},
        //    { 6, 7, 23 ,33,43,53},
        //    { 8, 9, 24 ,34,44,54},
        //    { 10, 11, 25 ,35,45,55},
        //    { 12, 13, 26 ,36,46,56},
        //    { 14, 15, 27 ,37,47,57},
        //    { 16, 17, 28 ,38,48,58},
        //    { 18, 19, 29 ,39,49,59}

        public bool Expire { get; set; }

        public void SetVariables(int[,] matx)
        {
            TotalLength = matx.Length;
            rank = matx.Rank;
            maxRows = matx.GetLength(0);
            rowLength = TotalLength / maxRows;
        }

        protected virtual void SingleRow_MultiColumn_Traverse(int i)
        {
            for (int j = columnStarter; j < rowLength; j++)
            {
                Console.Write(mat[i, j] + ",");
                ElementCounter++;
                startSpiral = true;
            }
        }

        protected virtual void Matrices_Multiplication(int[,] mat1, int[,] mat2)
        {
            SetVariables(mat1);
            rowLength = mat2.GetLength(0);
            int col = mat2.Length / rowLength;

            int[,] resultMat = new int[maxRows, col];

            for (int k = 0; k < maxRows; k++)
            {
                for (int i = 0; i < maxRows; i++)
                {
                    for (int j = 0; j < col; j++)
                    {
                        resultMat[k, i] = (mat1[k, j] * mat2[j, i]) + resultMat[k,i];
                    }
                    Console.Write(resultMat[k,i] + ",");
                }
                Console.WriteLine();
            }
        }

        protected virtual void Transpose_Matrix()
        {
            SetVariables(mat);
            int[,] resultMat = new int[rowLength, maxRows];

            for (int i = 0; i < maxRows; i++)
            {
                for (int j = 0; j < rowLength; j++)
                {
                    resultMat[j, i] = mat[i, j];
                }
            }
            PrintMatrix(resultMat);
        }

        public void PrintMatrix(int[,] printableMat)
        {
            SetVariables(printableMat);
            for (int i = 0; i < maxRows; i++)
            {
                for (int j = 0; j < rowLength; j++)
                {
                    Console.Write(printableMat[i,j]+", ");
                }
                Console.WriteLine();
            }
        }
    }
}
