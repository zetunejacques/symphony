using System.ComponentModel.DataAnnotations;
using Models;

namespace LoteExame
{
    public class LoteExame
    {
        [Key]
        public int Id { get; set; }
        public int IdLote { get; set; }
        public Lote Lote { get; set; }

        [Required(ErrorMessage = "A descrição do material é obrigatória")]
        [MinLength(1, ErrorMessage = "A descrição do material deve ter entre 1 e 100 caracteres")]
        [MaxLength(100, ErrorMessage = "A descrição do material deve ter entre 1 e 100 caracteres")]
        public string DescMatLab { get; set; }

        [Required(ErrorMessage = "O código do exame é obrigatório")]
        [MinLength(1, ErrorMessage = "O código do exame deve ter entre 1 e 20 caracteres")]
        [MaxLength(20, ErrorMessage = "O código do exame deve ter entre 1 e 20 caracteres")]
        public string CodExmLab { get; set; }

        [Required(ErrorMessage = "A descrição do exame é obrigatória")]
        [MinLength(3, ErrorMessage = "A descrição do exame deve ter entre 3 e 256 caracteres")]
        [MaxLength(256, ErrorMessage = "A descrição do exame deve ter entre 3 e 256 caracteres")]
        public string DescExmLab { get; set; }
        public int StatusExame { get; set; }
        public StatusExame Status { get; set; }

    }
}