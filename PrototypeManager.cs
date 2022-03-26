using System;
using System.Collections.Generic;
using System.Text;

namespace PrototypePattern
{
    [Serializable]
    public class PrototypeManager
    {
        public List<Account> Accounts
        {
            get
            {
                return new List<Account> {
                  new Account {Name = "Halil",SurName="Güneş",Age=42},
                  new Account {Name = "Meryem",SurName="Güneş",Age=35},
                  new Account {Name = "Demet Asya",SurName="Güneş",Age=8}
                };
            }
        }

        public void TestAcountsClone()
        {
            var listAccount = Accounts;
            var oldAccount = listAccount[0];
            var newAccount = oldAccount.Clone();
            newAccount.Age = 44;
            Console.WriteLine(oldAccount);
            Console.WriteLine(newAccount);
        }

        public void TestAccountsDeepClone()
        {
            var listAccount = Accounts;
            var oldAccount = listAccount[1];
            var newAccount = oldAccount.DeepClone();
            newAccount.Age = 36;
            Console.WriteLine(oldAccount);
            Console.WriteLine(newAccount);
        }

    }
}
