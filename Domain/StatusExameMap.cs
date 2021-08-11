using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Symphony.Domain
{
    public class StatusExameMap
    {
        public int Id { get; set; }
        public string ChaveStatus { get; set; }
        public string DescricaoStatusExame { get; set; }
        public bool BloqueioExame { get; set; }
        public string MotivoBloqueio { get; set; }
        public List<ExameMap> Exames { get; set; }
        public StatusExameMap()
        {
            Exames = new List<ExameMap>();
        }

    }
}