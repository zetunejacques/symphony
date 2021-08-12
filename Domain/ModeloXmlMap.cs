using System;
using System.ComponentModel.DataAnnotations;

namespace Symphony.Domain
{
    public class ModeloXmlMap
    {
        [Key]
        public int Id { get; set; }
        public string CodMat { get; set; }
        public string CodExm { get; set; }
        public int CodigoFormato { get; set; }
        public DateTime UltimaLiberacao { get; set; }
        public string UnidadeProdutiva { get; set; }
        public string ExameNome { get; set; }
        public string MaterialNome { get; set; }
        public string SuperExame { get; set; }
        public string SuperExameVRBT { get; set; }
        public string SuperExameVRBTIndividualizado { get; set; }
        public DateTime DataAtualizacao { get; set; }
    }
}