using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bib
{
    public interface IAbstractElemVisitor
    {
        void Visit(AbstractElem elem);
        void Visit(Carte carte);
        void Visit(Revista revista);

        void Visit(ElemCuTaxa elemCuTaxa);
        void Visit(ElemInSala elemInSala);
    }
}
