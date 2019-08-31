using Stucts.ReflectionHelper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stucts.Matrices
{
    class Matrix : Matrices
    {
        public void Process()
        {
            this.StartProcessing();
        }
        public Matrix()
        {
            ReflectionHelp.Instance.GetMethodNames(this);
        }

        public void SpiralTraverse_A_Matrix()
        {
            SetVariables(mat);

            for (int i = 0; ElementCounter <= TotalLength; i++)
            {
                SingleRow_MultiColumn_Traverse(i);

                if (startSpiral)
                {
                    FixColumnTravel(rowLength, i + 1);
                    ReverseTravel(rowLength, maxRows);
                    UpwardTravel(maxRows, i);

                    columnStarter++;
                    iterationDone++;
                }
            }
        }

        private void FixColumnTravel(int x, int i)
        {
            for (int j = x - 1; i < maxRows; i++)
            {
                Console.Write(mat[i, j] + ",");
                ElementCounter++;
            }
            rowLength = rowLength - 1;
            maxRows = maxRows - 1;
        }

        private void ReverseTravel(int x, int y)
        {
            for (int i = x - 1; i >= iterationDone; i--)
            {
                Console.Write(mat[y, i] + ",");
                ElementCounter++;
            }
        }

        private void UpwardTravel(int x, int y)
        {
            for (int i = x - 1; i > iterationDone; i--)
            {
                Console.Write(mat[i, y] + ",");
                ElementCounter++;
            }
        }
    }
}
