using System;

namespace Symphony.Models
{
    public class ConsultaLote
    {
        public string NumeroLote { get; set; }
        public int Statuslote { get; set; }
        public string DescricaoStatusLote { get; set; }
        public DateTime DataInsercao { get; set; }
        public DateTime PrevisaoRetorno { get; set; }
        public int QuantidadeExames { get; set; }

    }

}