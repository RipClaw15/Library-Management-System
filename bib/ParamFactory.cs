using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bib
{
    public abstract class ParamFactory
    {
        private static string id;
        private static string titlu;

        public string Id { get; set; }

        public string Titlu { get; set; }
    }
}
