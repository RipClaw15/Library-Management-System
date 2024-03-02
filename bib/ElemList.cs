using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bib
{
    public class ElemList<T, K> where T : IComparare<K>
    {
        protected List<T> Lista { get; set; }

        public ElemList()
        {
            Lista = new List<T>();
        }
    }
}
