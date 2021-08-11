using System.ComponentModel.DataAnnotations;

namespace Symphony.Domain
{
    public class ExamePredicaoMap
    {
        [Key]
        public int Id { get; set; }
        public string CodMat { get; set; }
        public string CodExm { get; set; }
        public string DescExm { get; set; }
        public string DescMat { get; set; }
        public double Confianca { get; set; }
        public ExamePredicaoMap()
        {
        }

    }
}