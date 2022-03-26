using System;
using System.Collections.Generic;
using System.Text;

namespace PrototypePattern
{
    [Serializable]
    public class Account : PrototypeBase<Account>
    {
        public string Name { get; set; }
        public string SurName { get; set; }
        public int Age { get; set; }

        public override string ToString()
        {
            return $"Hesap Sahibi Adı Soyadı: {Name} {SurName} ve Yaşı: {Age}";
        }
        
    }
}

