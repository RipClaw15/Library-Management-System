using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bib
{
    class Catalog : ElemList<AbstractElem, string>
    {
        private static Catalog singleton;
        private Catalog() { }
        public static Catalog Instance()
        {
            if (singleton == null) singleton = new Catalog();
            return singleton;
        }


        public void CautaElem()
        {

        }

        public void GetElem()
        {

        }

        public void InsereazaElem()
        {

        }

        public void StergeElem()
        {

        }
    }
}
