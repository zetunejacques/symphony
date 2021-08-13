using System.Collections.Generic;

namespace Symphony.Models
{
    public class PostPreConfigurados
    {
        public Identificacao Identificacao { get; set; }
        public List<ManutencaoExameDePara> ExamesDePara { get; set; }
        public TermoAceite TermoDeAceite { get; set; }
    }
}