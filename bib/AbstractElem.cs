using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bib
{
    public abstract class AbstractElem : IComparare<string>
    {
        public string titlu;
        public string id;
        public string dataReturn;
        private string imprumutatDe;
        public int retineri;
        public string ImprumutatDe
        {
            get { return imprumutatDe; }
            set { imprumutatDe = value; }
        }
        public AbstractElem(string titlu, string id, string dataReturn, string imprumutatDe, int retineri)
        {
            this.titlu = titlu; 
            this.id = id;
            this.dataReturn = dataReturn;
            this.imprumutatDe = imprumutatDe;
            this.retineri = retineri;
        }
        public bool Compara(string id)
        {
            throw new NotImplementedException();
        }
        public override string ToString()
        {
            return $"Id: {id}, Titlu: {titlu}";
        }
        public virtual void Accept(IAbstractElemVisitor viz)
        {
            //obiectul vizitator primit ca parametru "viziteaza" obiectul curent
            viz.Visit(this);
        }
    }
}
