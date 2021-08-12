
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Symphony.Domain;
namespace Symphony.Data.Mappings
{
    public class ExameV2Mapping : IEntityTypeConfiguration<ExameV2Map>
    {
        public void Configure(EntityTypeBuilder<ExameV2Map> builder)
        {
            builder.ToTable(@"ExameV2", @"recursos");
            builder.Property(x => x.Id).HasColumnName(@"Id").HasColumnType(@"int").IsRequired().ValueGeneratedOnAdd();
            builder.Property(x => x.CodMat).HasColumnName(@"CodMat").HasColumnType(@"nvarchar(15)").HasMaxLength(15).IsRequired();
            builder.Property(x => x.CodExm).HasColumnName(@"CodExm").HasColumnType(@"nvarchar(15)").HasMaxLength(15).IsRequired();
            builder.Property(x => x.Exame).HasColumnName(@"Exame").HasColumnType(@"nvarchar(MAX)").IsRequired();
            builder.Property(x => x.DataAtualizacao).HasColumnName(@"DataAtualizacao").HasColumnType(@"smalldatetime").IsRequired();
            builder.HasKey(@"Id");
        }
    }
}