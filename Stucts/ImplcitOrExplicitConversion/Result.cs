using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stucts.ImplicitOrExplicitConversion
{
    public class Result
    {
        public Result()
        {
            ImplicitConvertion();
        }

        public void ImplicitConvertion()
        {
            ClassA objA = new Stucts.ImplicitOrExplicitConversion.ClassA();
            ClassB objB = new Stucts.ImplicitOrExplicitConversion.ClassB();

            objB.ClassVariable = "B class variabe";

            objA = objB;
        }
    }
}
