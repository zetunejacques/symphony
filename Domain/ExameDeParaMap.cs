using System.ComponentModel.DataAnnotations;

namespace Symphony.Domain
{
    public class ExameDeParaMap
    {
        [Key]
        public int Id { get; set; }
        public string DescMat { get; set; }
        public string CodMat { get; set; }
        public string CodExm { get; set; }
        public string DescExm { get; set; }
        public bool Altura { get; set; }
        public int CodigoFormato { get; set; }
        public string Condicao { get; set; }
        public string Conservante { get; set; }
        public bool Contrato { get; set; }
        public bool Curva { get; set; }
        public bool Glicemia { get; set; }
        public bool Grafico { get; set; }
        public string Grupo { get; set; }
        public bool Hematocrito { get; set; }
        public bool Imagem { get; set; }
        public bool LinfocitosAbsoluto { get; set; }
        public bool MaterialDiversos { get; set; }
        public bool Peso { get; set; }
        public bool PesoAmostra { get; set; }
        public string Regiao { get; set; }
        public bool TempoAmostra { get; set; }
        public bool TempoDiurese { get; set; }
        public bool VolumeDiurese { get; set; }

        public ExameDeParaMap()
        {
        }
    }

}