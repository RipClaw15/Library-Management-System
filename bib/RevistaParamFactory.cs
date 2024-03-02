using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bib
{
    public class RevistaParamFactory : ParamFactory
    {
        public RevistaParamFactory()
        {
            Console.WriteLine("Introduceti ID-ul revistei: ");
            Id = Console.ReadLine();
            Console.WriteLine("Introduceti titlul revistei: ");
            Titlu = Console.ReadLine();
        }
    }
}
