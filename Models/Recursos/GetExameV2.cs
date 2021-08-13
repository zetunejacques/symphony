using System;
using System.Collections.Generic;

namespace Symphony.Models
{
    public class GetExameV2
    {
        public string Mensagem { get; set; }
        public int Status { get; set; }
        public DateTime DataHoraSolicitacao { get; set; }
        public DateTime DataHoraDownloadDocumento { get; set; }
        public int QuantidadeExames { get; set; }
        public List<ExameV2> exames { get; set; }
    }

}