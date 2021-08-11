using System.ComponentModel.DataAnnotations;

namespace Symphony.Domain
{
    public class LoteErroMap
    {
        [Key]
        public int Id { get; set; }
        public LoteMap Lote { get; set; }
        public string TextoErro { get; set; }

        public LoteErroMap()
        {
        }
    }
}