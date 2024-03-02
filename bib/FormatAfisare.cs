using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bib
{
    public class FormatAfisare : IAbstractElemVisitor
    {
        public void Visit(AbstractElem elem)
        {
            
        }
        public void Visit(Carte carte)
        {
            Console.WriteLine($"Carte: {carte.id}, {carte.titlu}, {carte.Autor}, " +
                $"{carte.dataReturn}, {carte.ImprumutatDe}, {carte.retineri} ");
        }

        public void Visit(Revista revista) 
        {
            Console.WriteLine($"Revista: {revista.id}, {revista.titlu}, {revista.Autor}, " +
                $"{revista.dataReturn}, {revista.ImprumutatDe}, {revista.retineri} ");
        }

        public void Visit(ElemCuTaxa elemCuTaxa)
        {
            Console.WriteLine(elemCuTaxa.ToString());
        }

        public void Visit(ElemInSala elemInSala) 
        {
            Console.WriteLine(elemInSala.ToString());
        }
    }
}
