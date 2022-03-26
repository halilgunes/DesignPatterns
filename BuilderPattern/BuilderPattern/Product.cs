using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BuilderPattern
{
    public class Product
    {
        private List<string> productComponents = new List<string>();

        public void Add(string part)
        {
            productComponents.Add(part);
        }

        public override string ToString()
        {
            StringBuilder val = new StringBuilder();
            if (productComponents.Any())
            {
                int i = 0;
                productComponents.ForEach(n =>
                {
                    i++;
                    val.Append($"{i.ToString()}. component's name : {n} {Environment.NewLine} ");
                });
            }
            return val.ToString();
        }
    }
}
