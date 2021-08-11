
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Symphony.Domain;
namespace Symphony.Data.Mappings
{
    public class ExameDeParaMapping : IEntityTypeConfiguration<ExameDeParaMap>
    {
        public void Configure(EntityTypeBuilder<ExameDeParaMap> builder)
        {
            builder.ToTable(@"ExameDePara", @"core");
            builder.Property(x => x.Id).HasColumnName(@"Id").HasColumnType(@"int").IsRequired();
            builder.Property(x => x.DescMat).HasColumnName(@"DescMat").HasColumnType(@"nvarchar(128)").HasMaxLength(128).IsRequired();
            builder.Property(x => x.CodMat).HasColumnName(@"CodMat").HasColumnType(@"nvarchar(15)").HasMaxLength(15).IsRequired();
            builder.Property(x => x.CodExm).HasColumnName(@"CodExm").HasColumnType(@"nvarchar(15)").HasMaxLength(15).IsRequired();
            builder.Property(x => x.DescExm).HasColumnName(@"DescExm").HasColumnType(@"nvarchar(256)").HasMaxLength(256).IsRequired();
            builder.Property(x => x.Altura).HasColumnName(@"Altura").HasColumnType(@"bit").IsRequired();
            builder.Property(x => x.CodigoFormato).HasColumnName(@"CodigoFormato").HasColumnType(@"int").IsRequired();
            builder.Property(x => x.Condicao).HasColumnName(@"Condicao").HasColumnType(@"bit").IsRequired();
            builder.Property(x => x.Conservante).HasColumnName(@"Conservante").HasColumnType(@"nvarchar(64)").HasMaxLength(64).IsRequired();
            builder.Property(x => x.Contrato).HasColumnName(@"Contrato").HasColumnType(@"bit").IsRequired();
            builder.Property(x => x.Curva).HasColumnName(@"Curva").HasColumnType(@"bit").IsRequired();
            builder.Property(x => x.Glicemia).HasColumnName(@"Glicemia").HasColumnType(@"bit").IsRequired();
            builder.Property(x => x.Grafico).HasColumnName(@"Grafico").HasColumnType(@"bit").IsRequired();
            builder.Property(x => x.Grupo).HasColumnName(@"Grupo").HasColumnType(@"varchar(20)").HasMaxLength(20).IsRequired();
            builder.Property(x => x.Hematocrito).HasColumnName(@"Hematocrito").HasColumnType(@"bit").IsRequired();
            builder.Property(x => x.Imagem).HasColumnName(@"Imagem").HasColumnType(@"bit").IsRequired();
            builder.Property(x => x.LinfocitosAbsoluto).HasColumnName(@"LinfocitosAbsoluto").HasColumnType(@"bit").IsRequired();
            builder.Property(x => x.MaterialDiversos).HasColumnName(@"MaterialDiversos").HasColumnType(@"bit").IsRequired();
            builder.Property(x => x.Peso).HasColumnName(@"Peso").HasColumnType(@"bit").IsRequired();
            builder.Property(x => x.PesoAmostra).HasColumnName(@"PesoAmostra").HasColumnType(@"bit").IsRequired();
            builder.Property(x => x.Regiao).HasColumnName(@"Regiao").HasColumnType(@"varchar(32)").HasMaxLength(32).IsRequired();
            builder.Property(x => x.TempoAmostra).HasColumnName(@"TempoAmostra").HasColumnType(@"bit").IsRequired();
            builder.Property(x => x.TempoDiurese).HasColumnName(@"TempoDiurese").HasColumnType(@"bit").IsRequired();
            builder.Property(x => x.VolumeDiurese).HasColumnName(@"VolumeDiurese").HasColumnType(@"bit").IsRequired();
            builder.HasKey(@"Id");
        }
    }
}