using System;
using System.ComponentModel.DataAnnotations;

namespace Symphony.Models
{
    public class StatusExame
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatório")]
        [MaxLength(60, ErrorMessage = "Este campo deve conter entre 3 e 60 caracteres")]
        [MinLength(3, ErrorMessage = "Este campo deve conter entre 3 e 60 caracteres")]
        public string Descricao { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatório")]
        [MaxLength(60, ErrorMessage = "Este campo deve conter entre 3 e 60 caracteres")]
        [MinLength(3, ErrorMessage = "Este campo deve conter entre 3 e 60 caracteres")]
        public string Chave { get; set; }

        //[Range(typeof(bool), "true", "false", ErrorMessage = "Esse campo dever ser true ou false")]
        //[RegularExpression("true|false", ErrorMessage = "Esse campo dever ser true ou false")]
        public bool BloqueioExame { get; set; }

        [MaxLength(60, ErrorMessage = "Este campo deve conter entre 3 e 60 caracteres")]
        public string MotivoBloqueio { get; set; }
    }
}