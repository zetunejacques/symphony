using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Symphony.Domain
{
    public class MotivoSuspensaoMap
    {
        [Key]
        public int Id { get; set; }
        public string DescricaoMotivoSuspensao { get; set; }
        public List<ExameSuspensoMap> ExamesSuspensos { get; set; }
        public MotivoSuspensaoMap()
        {
            ExamesSuspensos = new List<ExameSuspensoMap>();
        }
    }
}