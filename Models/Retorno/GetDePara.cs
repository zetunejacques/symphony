using System.Collections.Generic;

namespace Symphony.Models
{
    public class GetDePara
    {
        public string NumeroLote { get; set; }
        public int CodigoLC { get; set; }
        public List<RetornoDePara> DePara { get; set; }
        public List<RetornoExameSuspenso> Suspensos { get; set; }
    }
}