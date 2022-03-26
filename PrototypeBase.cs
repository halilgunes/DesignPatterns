using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;

namespace PrototypePattern
{
    [Serializable]
    public abstract class PrototypeBase<T> where T : class
    {
        public T DeepClone()
        {
            T returnValue = null;
            using (MemoryStream ms = new MemoryStream())
            {
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(ms, this);
                ms.Seek(0, SeekOrigin.Begin);
                returnValue = (T)bf.Deserialize(ms);
                ms.Close();
            }
            return returnValue;
        }

        public T Clone()
        {
            return (T)this.MemberwiseClone();
        }

    }
}
