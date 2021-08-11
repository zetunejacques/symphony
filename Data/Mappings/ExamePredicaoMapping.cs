
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Symphony.Domain;
namespace Symphony.Data.Mappings
{
    public class ExamePredicaoMapping : IEntityTypeConfiguration<ExamePredicaoMap>
    {
        public void Configure(EntityTypeBuilder<ExamePredicaoMap> builder)
        {
            builder.ToTable(@"ExamePredicao", @"core");
            builder.Property(x => x.Id).HasColumnName(@"Id").HasColumnType(@"int").IsRequired();
            builder.Property(x => x.DescMat).HasColumnName(@"DescMat").HasColumnType(@"nvarchar(128)").HasMaxLength(128).IsRequired();
            builder.Property(x => x.CodMat).HasColumnName(@"CodMat").HasColumnType(@"nvarchar(15)").HasMaxLength(15).IsRequired();
            builder.Property(x => x.CodExm).HasColumnName(@"CodExm").HasColumnType(@"nvarchar(15)").HasMaxLength(15).IsRequired();
            builder.Property(x => x.DescExm).HasColumnName(@"DescExm").HasColumnType(@"nvarchar(256)").HasMaxLength(256).IsRequired();
            builder.Property(x => x.Confianca).HasColumnName(@"Confianca").HasColumnType(@"float").IsRequired();
            builder.HasKey(@"Id");
        }
    }
}