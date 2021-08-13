using System;

namespace Symphony.Models
{
    public class GetToken
    {
        public string Mensagem { get; set; }
        public int Status { get; set; }
        public string Token { get; set; }
        public DateTime DataCriacao { get; set; }
        public DateTime DataExpiracao { get; set; }
    }
}