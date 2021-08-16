using System.Collections.Generic;

namespace Symphony.Models
{
    public class GetLotes
    {
        public string Mensagem { get; set; }
        public int Status { get; set; }
        public int CodigoLC { get; set; }
        public List<ConsultaLote> Lotes { get; set; }
    }
}