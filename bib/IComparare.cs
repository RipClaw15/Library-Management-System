using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bib
{
    public interface IComparare<K>
    {
        bool Compara(K id);
    }
}
