using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Symphony.Domain;
namespace Symphony.Data.Mappings
{
    public class TermoAceiteMapping : IEntityTypeConfiguration<TermoAceiteMap>
    {
        public void Configure(EntityTypeBuilder<TermoAceiteMap> builder)
        {
            builder.ToTable(@"TermoAceite", @"core");
            builder.Property(x => x.Id).HasColumnName(@"Id").HasColumnType(@"smallint").IsRequired();
            builder.Property(x => x.Versao).HasColumnName(@"ChaveToken").HasColumnType("@varchar(10)").HasMaxLength(10).IsRequired();
            builder.Property(x => x.DataAtualizacao).HasColumnName(@"DataAtualizacao").HasColumnType(@"smalldatetime").IsRequired();
            builder.Property(x => x.TextoTermo).HasColumnName(@"TextoTermo").HasColumnType(@"varchar(MAX)").IsRequired();
            builder.HasKey(@"Id");
        }
    }
}