using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrossProjectDemo.Accessibility
{
    internal class Loopings
    {
        private string localvar = "private var";
        public void ChangeDataOfReferenceType(ref Car car)
        {
            car.Name = "Nissan";
        }
    }
}
