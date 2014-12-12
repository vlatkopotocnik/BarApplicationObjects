

namespace BarObjekti
{
    public class Stol
    {
        public int StolId { get; set; }
        public int BrojStola { get; set; }

        public Stol()
        {
            
        }
        public Stol(int stolId, int brojStola)
        {
            StolId = stolId;
            BrojStola = brojStola;
        }
    }
}
