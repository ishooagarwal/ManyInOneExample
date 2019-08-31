using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrossProjectDemo
{
    public class Car : IEnumerable
    {
        private string name = string.Empty;
        //public string assemblyQlfdNm = string.Empty;
        public string Name {
            get { return name; }
            set { name = value; }
        }

        public Car()
        {
            //assemblyQlfdNm = typeof(Loopings).AssemblyQualifiedName;
        }

        public dynamic ReturnObject()
        {
            return new CustomLoops();
        }

        public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public static implicit operator Car(string b)
        {
            Car obj = new Car();
            obj.Name = b;
            return obj;
        }

        public void Caller(object obj, int x)
        {
            Loopings xy = (Loopings)obj;
        }

    }
}
