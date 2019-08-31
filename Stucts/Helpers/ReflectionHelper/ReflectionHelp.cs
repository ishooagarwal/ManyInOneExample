using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using Stucts.BaseInterface;

namespace Stucts.ReflectionHelper
{
    /// <summary>
    /// Reflection Help class to help with things tat require metadata of types
    /// </summary>
    class ReflectionHelp : IReflectionHelper
    {
        private static IReflectionHelper _instance = _instance = new ReflectionHelp();
        private SortedDictionary<Type, Dictionary<int, string>> methodNames = new SortedDictionary<Type, Dictionary<int, string>>();

        private ReflectionHelp()
        {

        }

        public SortedDictionary<Type, Dictionary<int, string>> MethodNames
        {
            get
            {
                return methodNames;
            }
            set
            {
                methodNames = value;
            }
        }

        public static IReflectionHelper Instance
        {
            get { return _instance; }
        }


        /// <summary>
        /// Get all methods in a class based on Key
        /// </summary>
        /// <param name="T">Key : Type of class</param>
        public virtual void GetMethodNames(IExpireHelper type)
        {
            Type T = type.GetType();
            Dictionary<int, string> methodDict = new Dictionary<int, string>();
            MethodInfo[] methods = T.GetMethods();

            if (!MethodNames.ContainsKey(T) || type.Expire)
            {
                for (ushort i = 0; i < methods.Length; i++)
                {
                    methodDict.Add(i, methods[i].Name);
                }
            }

            if (!MethodNames.ContainsKey(T))
            {
                MethodNames.Add(T, methodDict);
            }
            else if (methodDict.Count > 0)
            {
                MethodNames[T] = methodDict;
            }
        }

        /// <summary>
        /// Expire dictionary for specific key
        /// </summary>
        /// <param name="T">Key : Type of class</param>
        public void ExpireForKey(Type T)
        {
            MethodNames.Remove(T);
        }

        /// <summary>
        /// Expire dictionary for all keys
        /// </summary>
        /// <param name="T">Key : Type of class</param>
        public void Expire(Type T)
        {
            MethodNames = null;
            MethodNames = new SortedDictionary<Type, Dictionary<int, string>>();
        }
    }
}
