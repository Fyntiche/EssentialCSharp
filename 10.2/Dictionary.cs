using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10._2
{
    class Dictionary<T, R> : IMyDictionary<T>
    {
        Dictionary<T, R> dictionary = new Dictionary<T, R>();
        public T this[int index] => throw new NotImplementedException();

        public void Add(T keyValues)
        {
            throw new NotImplementedException();
        }

        public int Count()
        {
            return 0;
        }
    }
}
