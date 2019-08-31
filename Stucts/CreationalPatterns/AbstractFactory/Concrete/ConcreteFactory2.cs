using Stucts.CreationalPatterns.AbstractFactory.AbstractFactories;
using Stucts.CreationalPatterns.AbstractFactory.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stucts.CreationalPatterns.AbstractFactory.Concrete
{
    // Each Concrete Factory has a corresponding product variant.
    class ConcreteFactory2 : IAbstractFactory
    {
        public IAbstractProductA CreateProductA()
        {
            return new ConcreteProductA2();
        }

        public IAbstractProductB CreateProductB()
        {
            return new ConcreteProductB2();
        }
    }
}
