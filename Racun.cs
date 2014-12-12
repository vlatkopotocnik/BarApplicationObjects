using System;

namespace BarObjekti
{
    public class Racun
    {
        public int RacunId { get; set; }
        public int KonobarId { get; set; }
        public int StolId { get; set; }

        public DateTime Vrijeme { get; set; }

        public Racun(int kId, int sId)
        {
            KonobarId = kId;
            StolId = sId;
            Vrijeme = DateTime.Now;
        }

    }
}
