using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10._2
{
    interface IMyDictionary<T>
    {
        void Add(T keyValues);

        T this[int index] { get; }

        int Count();
    }
}
