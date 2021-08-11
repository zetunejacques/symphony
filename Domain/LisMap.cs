using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Symphony.Domain
{
    public class LisMap
    {
        [Key]
        public int Id { get; set; }
        public string DescricaoLis { get; set; }
        public SoftwareHouseMap SoftwareHouse { get; set; }
        public List<LoteMap> Lotes { get; set; }

        public LisMap()
        {
            Lotes = new List<LoteMap>();
        }
    }
}