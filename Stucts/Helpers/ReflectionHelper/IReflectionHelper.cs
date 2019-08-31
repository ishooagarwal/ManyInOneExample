using Stucts.BaseInterface;
using System;
using System.Collections.Generic;

namespace Stucts.ReflectionHelper
{
    interface IReflectionHelper
    {
        SortedDictionary<Type, Dictionary<int, string>> MethodNames
        {
            get;
        }

        void GetMethodNames(IExpireHelper T);
    }
}
