namespace bib
{
    class ListaMembri : ElemList<Membru, string>
    {
        private static ListaMembri singleton;

        private ListaMembri() { }

        public static ListaMembri Instance()
        {
            if (singleton == null) singleton = new ListaMembri();
            return singleton;
        }

        public void InsereazaMembru(string id, string nume, string prenume)
        {
           
            Membru membru = new Membru(id, nume, prenume);
            Lista.Add(membru);
        }

        public void CautaMembru(string id)
        {
            Membru membruGasit = Lista.Find(m => m.Compara(id));
            if (membruGasit != null)
            {
                Console.WriteLine($"Membru gasit: {membruGasit}");
            }
            else
            {
                Console.WriteLine("Membru nu a fost gasit.");
            }
        }

        public void GetMembri()
        {
            
            foreach (var membru in Lista)
            {
                Console.WriteLine(membru.ToString());
            }
        }

        public Membru GetMembruById(string id)
        {
            
            return Lista.Find(m => m.Compara(id));
        }
    }
}
