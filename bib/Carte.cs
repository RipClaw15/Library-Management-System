using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bib
{
    public class Carte : AbstractElem
    {
        private string autor;
        public string Autor { get; set; }

        public Carte(string titlu, string id, string dataReturn, string imprumutatDe, int retineri, string autor)
            : base(titlu, id, dataReturn, imprumutatDe, retineri)
        {         
            this.autor = autor;          
        }

        public override string ToString()
        {
            return $"{base.ToString()}, Autor: {autor}";
        }
        public override void Accept(IAbstractElemVisitor viz)
        {
            //obiectul vizitator primit ca parametru "viziteaza" obiectul curent
            viz.Visit(this);
        }
    }
}
