
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Symphony.Domain;
namespace Symphony.Data.Mappings
{
    public class LoteErroMapping : IEntityTypeConfiguration<LoteErroMap>
    {
        public void Configure(EntityTypeBuilder<LoteErroMap> builder)
        {
            builder.ToTable(@"LoteErro", @"core");
            builder.Property(x => x.Id).HasColumnName(@"Id").HasColumnType(@"int").IsRequired().ValueGeneratedOnAdd();
            builder.HasOne(x => x.Lote).WithMany(y => y.Erros).HasForeignKey(@"IdLote");
            builder.Property(x => x.TextoErro).HasColumnName(@"TextoErro").HasColumnType(@"nvarchar(MAX)").IsRequired();
            builder.HasKey(@"Id");
        }
    }
}