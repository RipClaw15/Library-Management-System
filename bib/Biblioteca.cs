using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bib
{
    public class Biblioteca
    {
        private List<AbstractElem> listaElemente = new List<AbstractElem>();

        private ListaMembri listaMembri = ListaMembri.Instance();

        private static Biblioteca catalog;

        private static Biblioteca membri;

        private static Biblioteca singleton;
        private Biblioteca() { }
        public static Biblioteca Instance()
        {
            if (singleton == null) singleton = new Biblioteca();
            return singleton;
        }
        public void AdaugaElem(AbstractElem elem)
        {
            listaElemente.Add(elem);
            Console.WriteLine($"Element adaugat: {elem}");
        }
        public void AdaugaMembru(string id, string nume, string prenume)
        {
            listaMembri.InsereazaMembru(id, nume, prenume);
        }
        public void AdaugaRetinere(string elemId, string membruId)
        {
           
                AbstractElem elemToRetain = listaElemente.FirstOrDefault(elem => elem.id == elemId);

                if (elemToRetain == null)
                {
                    Console.WriteLine($"Element cu ID {elemId} nu a fost gasit.");
                    return;
                }

                
                if (elemToRetain.ImprumutatDe != null)
                {
                    Console.WriteLine($"Element c ID {elemId} este deja imprumutat de {elemToRetain.ImprumutatDe}.");
                    return;
                }

                
                if (elemToRetain.retineri > 0)
                {
                    Console.WriteLine($"Element cu ID {elemId} este deja retinut.");
                    return;
                }

                
                if (elemToRetain.ImprumutatDe != membruId)
                {
                    Console.WriteLine($"Element cu ID {elemId} este imprumutat de un alt membru ({elemToRetain.ImprumutatDe}).");
                    return;
                }

                
                elemToRetain.retineri++;
                Console.WriteLine($"Element c ID {elemId} retinut cu succes de {membruId}.");
            
        }
        public void AnuleazaRetinere()
        {

        }
        public void CautaMembru()
        {

        }
        public void GetElemImprumutate()
        {

        }
        public void GetTranzactii()
        {

        }
        public void ImprumutaElem(string elemId, string membruId)
        {
            AbstractElem elemToLoan = listaElemente.FirstOrDefault(elem => elem.id == elemId);

            if (elemToLoan == null)
            {
                Console.WriteLine($"Element cu ID {elemId} nu a fost gasit.");
                return;
            }

            Membru membru = ListaMembri.Instance().GetMembruById(membruId);

            if (membru == null)
            {
                Console.WriteLine($"Membru cu ID {membruId} nu a fost gasit.");
                return;
            }

            if (elemToLoan.ImprumutatDe != null)
            {
                Console.WriteLine($"Element cu ID {elemId} este deja imprumutat de {elemToLoan.ImprumutatDe}.");
                return;
            }

            elemToLoan.ImprumutatDe = membruId;
            Console.WriteLine($"Element cu ID {elemId} imprumutat cu succes de {membruId}.");
        }
        public void ReturneazaElem(string elemId)
        {
            AbstractElem elemToReturn = listaElemente.FirstOrDefault(elem => elem.id == elemId);

            if (elemToReturn == null)
            {
                Console.WriteLine($"Element cu ID {elemId} nu a fost gasit.");
                return;
            }

            if (elemToReturn.ImprumutatDe == null)
            {
                Console.WriteLine($"Element cu ID {elemId} nu a fost imprumutat.");
                return;
            }

            string membruId = elemToReturn.ImprumutatDe;
            Membru membru = ListaMembri.Instance().GetMembruById(membruId);

            if (membru == null)
            {
                Console.WriteLine($"Member cu ID {membruId} nu a fost gasit.");
                return;
            }

            elemToReturn.ImprumutatDe = null; 
            Console.WriteLine($"Element cu ID {elemId} returnat cu succes de membrul {membruId}.");
        }
        public void StergeElem(string id)
        {
            
            AbstractElem elementToDelete = listaElemente.FirstOrDefault(elem => elem.id == id);

            if (elementToDelete != null)
            {
               
                listaElemente.Remove(elementToDelete);
                Console.WriteLine($"Element cu ID {id} sters cu succes.");
            }
            else
            {
                Console.WriteLine($"Element cu ID {id} nu a fost gasit.");
            }
        }


        public List<AbstractElem> GetListaElemente()
        {
            return listaElemente;
        }
    }
}
