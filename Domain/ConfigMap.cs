using System.ComponentModel.DataAnnotations;

namespace Symphony.Domain
{
    public class ConfigMap
    {
        [Key]
        public string Chave { get; set; }
        public string DescMat { get; set; }

        public ConfigMap()
        {
        }
    }

}