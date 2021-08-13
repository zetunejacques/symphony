using System.Collections.Generic;
using Symphony.Models.Comum;
namespace Symphony.Models.Envio
{
    public class PostDe
    {
        public Identificacao Identificacao { get; set; }
        public List<EnvioExame> Exames { get; set; }
        public TermoAceite TermoDeAceite { get; set; }

    }
}