using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bib
{
    public class ElemCuTaxa : AbstractElem
    {
        private int taxa;
        private AbstractElem decoratedElem;


        public ElemCuTaxa(AbstractElem elem, int taxa)
            : base( elem.titlu, elem.id, elem.dataReturn, elem.ImprumutatDe, elem.retineri)
        {
            this.decoratedElem = elem;
            this.taxa = taxa;
        }
        public override string ToString()
        {
            return $"{base.ToString()}, Taxa: {taxa}";
        }

        public override void Accept(IAbstractElemVisitor viz)
        {
            //obiectul vizitator primit ca parametru "viziteaza" obiectul curent
            viz.Visit(this);
        }
    }
}
