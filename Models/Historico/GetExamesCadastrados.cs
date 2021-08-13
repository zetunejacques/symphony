using System.Collections.Generic;

namespace Symphony.Models
{
    public class GetExamesCadastrados
    {
        public string Mensagem { get; set; }
        public int Status { get; set; }
        public int CodigoLC { get; set; }
        public List<ExameCadastrado> DePara { get; set; }
    }

}