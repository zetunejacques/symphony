using FluentValidation;
using Microsoft.AspNetCore.Mvc;


namespace Symphony.Models
{
    [Route("v1/exame")]
    public class Exame
    {
        public int Id { get; set; }
        public int IdLote { get; set; }
        public string CodExmLab { get; set; }
        public string CodMatLab { get; set; }
        public string DescExmLab { get; set; }
    }
    public class ExameValidator : AbstractValidator<Exame>
    {
        public ExameValidator()
        {
            RuleFor(p => p.CodExmLab).NotEmpty().WithName("CodExmLab").MinimumLength(3).MaximumLength(50);
        }
    }
}