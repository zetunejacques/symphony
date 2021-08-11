using System.Collections.Generic;

namespace Symphony.Domain
{
    public class StatusLoteMap
    {
        public int Id { get; set; }
        public string ChaveStatus { get; set; }
        public string DescricaoStatusLote { get; set; }
        public List<LoteMap> Lotes { get; set; }

        public StatusLoteMap()
        {
            Lotes = new List<LoteMap>();
        }
    }

}