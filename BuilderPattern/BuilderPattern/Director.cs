using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderPattern
{
    public class Director
    {
        public void Construct(Builder builder,List<string> parts)
        {
            parts.ForEach(n => builder.BuildPart(n));
            Console.WriteLine((builder.GetProduct()).ToString());
        }
    }
}
