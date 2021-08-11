using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Symphony.Domain
{
    public class LoteMap
    {
        public int Id { get; set; }
        public string NumeroLote { get; set; }
        public StatusLoteMap StatusLote { get; set; }
        public int CodigoLC { get; set; }
        public string LaboratorioConveniado { get; set; }
        public string CNPJ { get; set; }
        public string NomeUsuario { get; set; }
        public string CargoUsuario { get; set; }
        public LisMap Lis { get; set; }
        public string Email { get; set; }
        public string TipoEnvio { get; set; }
        public DateTime DataInsercao { get; set; }
        public DateTime PrevisaoRetorno { get; set; }
        public DateTime DataConclusao { get; set; }
        public DateTime DataResgate { get; set; }
        public string TermoAceite { get; set; }
        public List<ExameMap> Exames { get; set; }
        public List<LoteErroMap> Erros { get; set; }
        public List<ExamePreConfiguradoMap> ExamesPreConfigurados { get; set; }


        public LoteMap()
        {
            Exames = new List<ExameMap>();
            Erros = new List<LoteErroMap>();
            ExamesPreConfigurados = new List<ExamePreConfiguradoMap>();
        }
    }
}