using System.ComponentModel.DataAnnotations;

namespace Symphony.Domain
{
    public class ExameSuspensoMap
    {
        [Key]
        public int Id { get; set; }
        public MotivoSuspensaoMap MotivoSuspensao { get; set; }
        public string DetalhesMotivoSuspensao { get; set; }
        public ExameSuspensoMap()
        {
        }
    }
}