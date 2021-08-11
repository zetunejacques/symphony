using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Symphony.Domain
{
    public class SoftwareHouseMap
    {
        [Key]
        public int Id { get; set; }
        public string NomeSoftwareHouse { get; set; }
        public bool RetornarApenasExamesContratados { get; set; }
        public bool RetornarEmOrdemAlfabetica { get; set; }
        public List<LisMap> Lises { get; set; }
        public List<LoteMap> Lotes { get; set; }

        public SoftwareHouseMap()
        {
            Lises = new List<LisMap>();
            Lotes = new List<LoteMap>();
        }

    }

}