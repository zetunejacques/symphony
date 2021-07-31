using System;
using System.ComponentModel.DataAnnotations;

namespace Models
{
    public class Lote
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "O número do lote é obrigatório")]
        [MinLength(12, ErrorMessage = "O número do lote deve ter 12 caracteres")]
        [MaxLength(12, ErrorMessage = "O número do lote deve ter 12 caracteres")]
        [RegularExpression("^(0|[1-9][0-9]*)$", ErrorMessage = "O número do lote deve conter apenas algarismos")]
        //[IsNumeric(ErrorMessage = "O número do lote deve conter apenas algarismos")]
        public string NumeroLote { get; set; }

        [Required(ErrorMessage = "O status do lote é obrigatório")]
        public int StatusLote { get; set; }
        public StatusLote Status { get; set; }

        [Required(ErrorMessage = "O código do LC é obrigatório")]
        [MinLength(1, ErrorMessage = "O código do LC deve ter entre 1 e 6 caracteres")]
        [MaxLength(6, ErrorMessage = "O código do LC deve ter entre 1 e 6 caracteres")]
        [RegularExpression("^(0|[1-9][0-9]*)$", ErrorMessage = "O código do LC deve conter apenas algarismos")]
        //[IsNumeric(ErrorMessage = "O código do LC deve conter apenas algarismos")]
        public string CodigoLC { get; set; }

        [Required(ErrorMessage = "O nome do laboratório Conveniado é obrigatório")]
        [MinLength(1, ErrorMessage = "O nome do Laboratório Conveniado deve ter entre 1 e 100 caracteres")]
        [MaxLength(100, ErrorMessage = "O nome do Laboratório Conveniado deve ter entre 1 e 100 caracteres")]
        public string LaboratorioConveniado { get; set; }

        [Required(ErrorMessage = "O CNPJ é obrigatório")]
        [MinLength(14, ErrorMessage = "O CNPJ deve ter entre 14 e 18 caracteres")]
        [MaxLength(18, ErrorMessage = "O CNPJ deve ter entre 14 e 18 caracteres")]
        public string CNPJ { get; set; }

        [Required(ErrorMessage = "O nome do usuário é obrigatório")]
        [MinLength(1, ErrorMessage = "O nome do usuário deve ter entre 1 e 100 caracteres")]
        [MaxLength(100, ErrorMessage = "O nome do usuário deve ter entre 1 e 100 caracteres")]
        public string NomeUsuario { get; set; }

        [Required(ErrorMessage = "O cargo do usuário é obrigatório")]
        [MinLength(1, ErrorMessage = "O cargo do usuário deve ter entre 1 e 100 caracteres")]
        [MaxLength(100, ErrorMessage = "O cargo do usuário deve ter entre 1 e 100 caracteres")]
        public string CargoUsuario { get; set; }

        [Required(ErrorMessage = "O nome da software house é obrigatório")]
        [MinLength(3, ErrorMessage = "O nome da software house deve ter entre 3 e 60 caracteres")]
        [MaxLength(60, ErrorMessage = "O nome da software house deve ter entre 3 e 60 caracteres")]
        public string SoftwareHouse { get; set; }

        [Required(ErrorMessage = "O nome do LIS é obrigatório")]
        [MinLength(3, ErrorMessage = "O nome do LIS deve ter entre 3 e 60 caracteres")]
        [MaxLength(60, ErrorMessage = "O nome do LIS deve ter entre 3 e 60 caracteres")]
        public string LIS { get; set; }

        [Required(ErrorMessage = "O e-mail é obrigatório")]
        [DataType(DataType.EmailAddress, ErrorMessage = "O endereço de e-mail informado não é válido")]
        public string Email { get; set; }

        [Required(ErrorMessage = "O tipo de envio é obrigatório")]
        [RegularExpression("API|XML", ErrorMessage = "O tipo de envio deve ser API ou XML")]
        public string TipoEnvio { get; set; }

        [Required(ErrorMessage = "A data de inserção é obrigatória")]
        [DataType(DataType.DateTime, ErrorMessage = "A data de inserção não é uma data válida")]
        public DateTime DataInsercao { get; set; }

        [Required(ErrorMessage = "A data de previsão de retorno é obrigatória")]
        [DataType(DataType.DateTime, ErrorMessage = "A data de previsão de retorno não é uma data válida")]
        public DateTime PrevisaoRetorno { get; set; }

        [Required(ErrorMessage = "O termo de aceite é obrigatório")]
        public string TermoDeAceite { get; set; }
        public string TextoErro { get; set; }
    }

    // [AttributeUsage(AttributeTargets.Property, AllowMultiple = false, Inherited = false)]
    // public class IsNumericAttribute : ValidationAttribute
    // {
    //     public override bool IsValid(object value)
    //     {
    //         var inputValue = value as string;
    //         return int.TryParse(inputValue, out _);
    //     }
    // }

}