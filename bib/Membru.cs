namespace bib
{
    public class Membru : IComparare<string>
    {
        public string Id { get; set; }
        public string Nume { get; set; }
        public string Prenume { get; set; }

        
        public Membru(string id, string nume, string prenume)
        {
            Id = id;
            Nume = nume;
            Prenume = prenume;
        }

        public bool Compara(string id)
        {
            
            return Id.Equals(id);
        }

        
        public override string ToString()
        {
            return $"ID: {Id}, Nume: {Nume}, Prenume: {Prenume}";
        }
    }
}
