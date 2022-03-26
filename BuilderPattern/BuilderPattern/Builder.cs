using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderPattern
{
    public abstract class Builder 
    {
        public abstract void BuildPart(string part);
        public abstract Product GetProduct();

    }
}

