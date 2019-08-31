using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stucts.ImplicitOrExplicitConversion
{
    public class ClassA
    {
        public string ClassVariable = string.Empty;

        public ClassA()
        {

        }

        public static implicit operator ClassA(ClassB b)
        {
            ClassA obj = new Stucts.ImplicitOrExplicitConversion.ClassA();
            obj.ClassVariable = b.ClassVariable;
            return obj;
        }
    }
}
