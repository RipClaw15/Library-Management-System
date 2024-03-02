using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bib
{
    public class AbstractElemFactory
    {
        private static AbstractElemFactory singleton;
        private AbstractElemFactory() { }
        public static AbstractElemFactory Instance()
        {
            if (singleton == null) singleton = new AbstractElemFactory();
            return singleton;
        }

        public const string CARTE = "CARTE";
        public const string CARTE_SALA = "CARTE_SALA";
        public const string CARTE_SALA_TAXA = "CARTE_SALA_TAXA";
        public const string CARTE_TAXA = "CARTE_TAXA";
        public const string REVISTA = "REVISTA";
        public const string REVISTA_SALA = "REVISTA_SALA";
        public const string REVISTA_SALA_TAXA = "REVISTA_SALA_TAXA";
        public const string REVISTA_TAXA = "REVISTA_TAXA";


        public AbstractElem CreazaElemConcret(string tip, string titlu, string id, string autor = null, bool doarInSala = false, int taxa = 0)
        {
            switch (tip)
            {
                case CARTE:
                    return new Carte(titlu, id, null, null, 0, autor);
                case CARTE_SALA:
                    return new ElemInSala(new Carte(titlu, id, null, null, 0, autor), true);
                case CARTE_SALA_TAXA:
                    return new ElemCuTaxa(new ElemInSala(new Carte(titlu, id, null, null, 0, autor), true), 10);
                case CARTE_TAXA:
                    return new ElemCuTaxa(new Carte(titlu, id, null, null, 0, autor), 10);
                case REVISTA:
                    return new Revista(titlu, id, null, null, 0, autor);
                case REVISTA_SALA:
                    return new ElemInSala(new Revista(titlu, id, null, null, 0, autor), true);
                case REVISTA_SALA_TAXA:
                    return new ElemCuTaxa(new ElemInSala(new Revista(titlu, id, null, null, 0, autor), true), 10);
                case REVISTA_TAXA:
                    return new ElemCuTaxa(new Revista(titlu, id, null, null, 0, autor), 10);
                default:
                    throw new ArgumentException("Invalid elemType");
            }
        }
        /*creaza carte
        public ParamFactory CreazaElemConcret(string id, string titlu, string autor)
        {
            
            return new CarteParamFactory { Id = id, Titlu = titlu , Autor = autor};
        }

        //creaza revista
        public ParamFactory CreazaElemConcret(string id, string titlu)
        {
            
            return new RevistaParamFactory { Id = id , Titlu = titlu};
        }
        */
    }
}
