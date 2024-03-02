using System;

namespace bib
{
    class Program
    {
   static void Main()
        {
            Biblioteca biblioteca = Biblioteca.Instance();
            while (true)
            {
                Console.WriteLine("1. Adauga Element");
                Console.WriteLine("2. Adauga Membru");
                Console.WriteLine("3. Sterge Element");
                Console.WriteLine("4. Visita Element");
                Console.WriteLine("5. Imprumuta Element");
                Console.WriteLine("6. Returneaza Element");
                Console.WriteLine("5. Retine Element");
                Console.WriteLine("0. Exit");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        AdaugaElement(biblioteca);
                        break;
                    case "2":
                        AdaugaMembru(biblioteca);
                        break;
                    case "3":
                        StergeElement(biblioteca);
                        break;
                    case "4":
                        VisitElements(biblioteca);
                        break;
                    case "5":
                        ImprumutaElem(biblioteca);
                        break;
                    case "6":
                        ReturneazaElem(biblioteca);
                        break;
                    case "7":
                        RetinereElem(biblioteca);
                        break;
                    case "0":
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }
        static void RetinereElem(Biblioteca biblioteca)
        {
            Console.WriteLine("Retinere Elem");

            Console.WriteLine("Introduce ID-ul elementului de rezervat:");
            string elemIdToReserve = Console.ReadLine();

            Console.WriteLine("Introduce ID-ul membrului care doreste sa rezerve:");
            string membruIdReserving = Console.ReadLine();

            biblioteca.AdaugaRetinere(elemIdToReserve, membruIdReserving);
        }

        static void ReturneazaElem(Biblioteca biblioteca)
        {
            Console.WriteLine("Returneaza Element");
            Console.WriteLine("Introduce ID-ul elementului de returnat:");
            string elemIdToReturn = Console.ReadLine();

            biblioteca.ReturneazaElem(elemIdToReturn);
        }

        static void ImprumutaElem(Biblioteca biblioteca)
        {
            Console.WriteLine("Imprumuta element");
            Console.WriteLine("Introduce ID-ul elementului de imprumutat:");
            string elemIdToLoan = Console.ReadLine();

            Console.WriteLine("Introduce ID-ul membrului care imprumuteaza:");
            string membruId = Console.ReadLine();

            biblioteca.ImprumutaElem(elemIdToLoan, membruId);
        }

        static void VisitElements(Biblioteca biblioteca)
        {

            IAbstractElemVisitor visitor = new FormatAfisare();

            List<AbstractElem> listaElemente = biblioteca.GetListaElemente();

            foreach (var element in listaElemente)
            {
               
                element.Accept(visitor);
            }

        }

        static void AdaugaElement(Biblioteca biblioteca)
        {
            Console.WriteLine("Select type of element:");
            Console.WriteLine("1. CARTE");
            Console.WriteLine("2. CARTE_SALA");
            Console.WriteLine("3. CARTE_SALA_TAXA");
            Console.WriteLine("4. CARTE_TAXA");
            Console.WriteLine("5. REVISTA");
            Console.WriteLine("6. REVISTA_SALA");
            Console.WriteLine("7. REVISTA_SALA_TAXA");
            Console.WriteLine("8. REVISTA_TAXA");

            string elementType = Console.ReadLine();

            Console.WriteLine("Introduce ID:");
            string id = Console.ReadLine();

            Console.WriteLine("Introduce Titlu:");
            string titlu = Console.ReadLine();

            Console.WriteLine("Introduce Autor:");
            string autor = Console.ReadLine();

            
            AbstractElemFactory elemFactory = AbstractElemFactory.Instance();

            
            AbstractElem element = elemFactory.CreazaElemConcret(elementType, titlu, id, autor);

            
            biblioteca.AdaugaElem(element);

            Console.WriteLine("Element adaugat cu succes!");
        }

        static void AdaugaMembru(Biblioteca biblioteca)
        {
            Console.WriteLine("Introduce Membru ID:");
            string membruID = Console.ReadLine();

            Console.WriteLine("Introduce Nume:");
            string nume = Console.ReadLine();

            Console.WriteLine("Introduce Prenume:");
            string prenume = Console.ReadLine();

            biblioteca.AdaugaMembru(membruID, nume, prenume);
            Console.WriteLine("Membru adaugat cu succes!");
        }

        static void StergeElement(Biblioteca biblioteca)
        {
            Console.WriteLine("Introduce ID-ul elementului de sters:");
            string elementID = Console.ReadLine();
            biblioteca.StergeElem(elementID);
        }

    }
}
