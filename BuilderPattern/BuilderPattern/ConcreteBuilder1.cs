using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderPattern
{
    public class ConcreteBuilder1 : Builder
    {
        private Product product = new Product();
        public override void BuildPart(string part)
        {
            product.Add(part);
        }

        public override Product GetProduct()
        {
            return product;
        }
    }
}
