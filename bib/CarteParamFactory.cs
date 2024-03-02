using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bib
{
    public class CarteParamFactory : ParamFactory
    {
        private static string autor;
        public string Autor
        {
            get { return autor; }
            set { autor = value; }
        }


        public CarteParamFactory()
        {
            Console.WriteLine("Introduceti ID-ul cartii: ");
            Id = Console.ReadLine();
            Console.WriteLine("Introduceti titlul cartii: ");
            Titlu = Console.ReadLine();
            Console.WriteLine("Introduceti autorul cartii: ");
            Autor = Console.ReadLine();
        }
    }
}
