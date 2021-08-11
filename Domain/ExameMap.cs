using System.ComponentModel.DataAnnotations;

namespace Symphony.Domain
{
    public class ExameMap
    {
        [Key]
        public int Id { get; set; }
        public LoteMap Lote { get; set; }
        public string CodExmLab { get; set; }
        public string CodMatLab { get; set; }
        public string DescExmLab { get; set; }
        public StatusExameMap StatusExame { get; set; }

        public ExameMap()
        {
        }
    }
}