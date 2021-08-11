using System;
using System.ComponentModel.DataAnnotations;

namespace Symphony.Domain
{
    public class TokenMap
    {
        [Key]
        public int Id { get; set; }
        public string ChaveToken { get; set; }
        public DateTime DataExpiracao { get; set; }
        public string ValorToken { get; set; }
        public TokenMap()
        {

        }
    }
}