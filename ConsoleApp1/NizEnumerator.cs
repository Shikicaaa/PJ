using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class NizEnumerator<T> : IEnumerable<T>
    {
        T[] niz;
        int index = -1;
        public NizEnumerator(T[] niz)
        {
            this.niz = niz;
        }
        public bool MoveNext()
        {
            index++;
            return index < niz.Length;
        }
        public void Reset()
        {
            index = -1;
        }
        public T Current
        {
            get { return niz[index]; }
        }
    }
}
