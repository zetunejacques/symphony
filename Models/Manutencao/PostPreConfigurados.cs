using System.Collections.Generic;
using Symphony.Models.Comum;

namespace Symphony.Models.Manutencao
{
    public class PostPreConfigurados
    {
        public Identificacao Identificacao { get; set; }
        public List<ManutencaoExameDePara> ExamesDePara { get; set; }
        public TermoAceite TermoDeAceite { get; set; }
    }
}