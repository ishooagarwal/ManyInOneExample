using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrossProjectDemo
{
    public class CustomLoops : IEnumerable
    {
        public Car s = new Car();
        //Car[] _cars = new Car { "Nissan", "VolksWagen" };
        public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public void PassByRef()
        {
            
            //Loopings obj = new Loopings();
            //var typ = obj.GetType().GetField("localvar",System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);
            //typ.SetValue(obj,"Not so much");

        }
    }
}
