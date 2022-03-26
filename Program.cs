using System;

namespace PrototypePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            PrototypeManager pm = new PrototypeManager();
            pm.TestAcountsClone();
            pm.TestAccountsDeepClone();
        }
    }
}
