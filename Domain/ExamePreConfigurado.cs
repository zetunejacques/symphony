using System.ComponentModel.DataAnnotations;

namespace Symphony.Domain
{
    public class ExamePreConfiguradoMap
    {
        [Key]
        public int Id { get; set; }
        public LoteMap Lote { get; set; }
        public string CodExmLab { get; set; }
        public string CodMatLab { get; set; }
        public string DescExmLab { get; set; }
        public string DescMat { get; set; }
        public string CodMat { get; set; }
        public string CodExm { get; set; }
        public string DescExm { get; set; }

        public ExamePreConfiguradoMap()
        {
        }
    }
}