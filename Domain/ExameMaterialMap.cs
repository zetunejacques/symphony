using System.ComponentModel.DataAnnotations;

namespace Symphony.Domain
{
    public class ExameMaterialMap
    {
        [Key]
        public int Id { get; set; }
        public string CodMat { get; set; }
        public string CodExm { get; set; }
        public string DescMatReal { get; set; }
    }
}