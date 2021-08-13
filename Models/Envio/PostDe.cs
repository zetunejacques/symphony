using System.Collections.Generic;

namespace Symphony.Models
{
    public class PostDe
    {
        public Identificacao Identificacao { get; set; }
        public List<EnvioExame> Exames { get; set; }
        public TermoAceite TermoDeAceite { get; set; }

    }
}