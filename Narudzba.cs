using System;

namespace BarObjekti
{
    [Serializable]
    public class Narudzba
    {
        public int ArtiklId;
        public string Naziv;
        public int Kolicina;

        public Narudzba(int artiklId, string naziv, int kolicina)
        {
            ArtiklId = artiklId;
            Naziv = naziv;
            Kolicina = kolicina;
        }

        
    }
}
