using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stucts.Matrices
{
    class Matrices : BaseMatrix
    {
        protected void StartProcessing()
        {
            Matrices_Multiplication(mat, maty);
            Transpose_Matrix();
        }
    }
}
