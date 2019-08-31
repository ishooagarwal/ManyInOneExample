using Stucts.CreationalPatterns.AbstractFactory.AbstractFactories;
using Stucts.CreationalPatterns.AbstractFactory.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stucts.CreationalPatterns.AbstractFactory.Concrete
{
    // Concrete Factories produce a family of products that belong to a single
    // variant. The factory guarantees that resulting products are compatible.
    // Note that signatures of the Concrete Factory's methods return an abstract
    // product, while inside the method a concrete product is instantiated.
    class ConcreteFactory1 : IAbstractFactory
    {
        public IAbstractProductA CreateProductA()
        {
            return new ConcreteProductA1();
        }

        public IAbstractProductB CreateProductB()
        {
            return new ConcreteProductB1();
        }
    }
}
