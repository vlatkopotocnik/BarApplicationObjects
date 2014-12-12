

namespace BarObjekti
{
    public class Artikl
    {
        public int ArtiklId { get; set; }
        public string Naziv { get; set; }
        public string ImagePath { get; set; }

        public override string ToString()
        {
            return Naziv;
        }
    }
}
