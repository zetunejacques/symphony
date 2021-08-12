using System;
using System.ComponentModel.DataAnnotations;

namespace Symphony.Domain
{
    public class ExameV2Map
    {
        [Key]
        public int Id { get; set; }
        public string CodMat { get; set; }
        public string CodExm { get; set; }
        public string Exame { get; set; }
        public DateTime DataAtualizacao { get; set; }
    }
}