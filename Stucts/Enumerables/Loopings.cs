using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrossProjectDemo
{
    internal class Loopings
    {
        private string localvar = "private var";
        public void ChangeDataOfReferenceType(ref Car car)
        {
            car.Name = "Nissan";
        }

        public void FirstLoopMethod()
        {
            List<int> enumerable = new List<int>();
            for (int i = 0; i <= 20; i++)
            {
                enumerable.Add(i);
            }
            IEnumerator<int> enumerator = enumerable.GetEnumerator();

            Console.WriteLine("FirstLoopMethod start...");
            while (enumerator.MoveNext())
            {
                object element = enumerator.Current;
                int num = (int)element;
                Console.Write(num+", ");
                if (num > 9)
                {
                    SecondLoopMethod(enumerator);
                }
                // you logic here
                // Perform your logic logic on the element
            }
        }

        private void SecondLoopMethod(IEnumerator<int> enumerator)
        {
            Console.WriteLine();
            Console.WriteLine("SecondLoopMethod start...");
            while (enumerator.MoveNext())
            {
                object element = enumerator.Current;
                int num = (int)element;
                Console.Write(num+", ");
                // Perform your logic logic on the element
            }
        }
    }
}
