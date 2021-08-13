using System;
using System.ComponentModel.DataAnnotations;

namespace Symphony.Domain
{
    public class TermoAceiteMap
    {
        [Key]
        public int Id { get; set; }
        public string Versao { get; set; }
        public DateTime DataAtualizacao { get; set; }
        public string TextoTermo { get; set; }

        public TermoAceiteMap()
        {
        }
    }

}