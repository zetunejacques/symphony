
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Symphony.Domain;
namespace Symphony.Data.Mappings
{
    public class ModeloXmlMapping : IEntityTypeConfiguration<ModeloXmlMap>
    {
        public void Configure(EntityTypeBuilder<ModeloXmlMap> builder)
        {
            builder.ToTable(@"ModeloXml", @"recursos");
            builder.Property(x => x.Id).HasColumnName(@"Id").HasColumnType(@"int").IsRequired().ValueGeneratedOnAdd();
            builder.Property(x => x.CodMat).HasColumnName(@"CodMat").HasColumnType(@"nvarchar(15)").HasMaxLength(15).IsRequired();
            builder.Property(x => x.CodExm).HasColumnName(@"CodExm").HasColumnType(@"nvarchar(15)").HasMaxLength(15).IsRequired();
            builder.Property(x => x.CodigoFormato).HasColumnName(@"CodigoFormato").HasColumnType(@"int").IsRequired();
            builder.Property(x => x.UltimaLiberacao).HasColumnName(@"UltimaLiberacao").HasColumnType(@"smalldatetime").IsRequired();
            builder.Property(x => x.UnidadeProdutiva).HasColumnName(@"UnidadeProdutiva").HasColumnType(@"varchar(10)").HasMaxLength(10).IsRequired();
            builder.Property(x => x.ExameNome).HasColumnName(@"ExameNome").HasColumnType(@"nvarchar(128)").HasMaxLength(128).IsRequired();
            builder.Property(x => x.MaterialNome).HasColumnName(@"MaterialNome").HasColumnType(@"nvarchar(64)").HasMaxLength(64).IsRequired();
            builder.Property(x => x.SuperExame).HasColumnName(@"SuperExame").HasColumnType(@"nvarchar(MAX)");
            builder.Property(x => x.SuperExameVRBT).HasColumnName(@"SuperExameVRBT").HasColumnType(@"nvarchar(MAX)");
            builder.Property(x => x.SuperExameVRBTIndividualizado).HasColumnName(@"SuperExameVRBTIndividualizado").HasColumnType(@"nvarchar(MAX)");
            builder.Property(x => x.DataAtualizacao).HasColumnName(@"DataAtualizacao").HasColumnType(@"smalldatetime").IsRequired();
            builder.HasKey(@"Id");
        }
    }
}