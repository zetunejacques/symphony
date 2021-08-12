using System.ComponentModel.DataAnnotations;

namespace Symphony.Domain
{
    public class DeParaMaterialMap
    {
        [Key]
        public int Id { get; set; }
        public string DescMatLab { get; set; }
        public string DescMatReal { get; set; }

    }
}