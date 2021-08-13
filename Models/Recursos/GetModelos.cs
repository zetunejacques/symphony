using System;
using System.Collections.Generic;

namespace Symphony.Models
{
    public class GetModelos
    {
        public string Mensagem { get; set; }
        public int Status { get; set; }
        public DateTime DataHoraSolicitacao { get; set; }
        public DateTime DataHoraDownloadDocumento { get; set; }
        public int QuantidadeExames { get; set; }
        public List<ModeloXml> exames { get; set; }
    }

}