using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bib
{
    public class ElemInSala : AbstractElem
    {
        private AbstractElem decoratedElem;
        private bool in_sala;

        public bool InSala
        {
            get { return in_sala; }
        }

        public ElemInSala(AbstractElem elem, bool in_sala)
            : base(elem.titlu, elem.id, elem.dataReturn, elem.ImprumutatDe, elem.retineri)
        {
            this.decoratedElem = elem;
            this.in_sala = in_sala;
        }

        public override string ToString()
        {
            return $"{base.ToString()}, Disponibil doar în sală: {in_sala}";
        }
        public override void Accept(IAbstractElemVisitor viz)
        {
            //obiectul vizitator primit ca parametru "viziteaza" obiectul curent
            viz.Visit(this);
        }
    }
}
