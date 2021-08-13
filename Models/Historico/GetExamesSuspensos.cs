using System.Collections.Generic;

namespace Symphony.Models
{
    public class GetExamesSuspensos
    {
        public int CodigoLC { get; set; }
        public List<RetornoExameSuspenso> Suspensos { get; set; }
    }

}