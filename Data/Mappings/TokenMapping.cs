using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Symphony.Domain;
namespace Symphony.Data.Mappings
{
    public class TokenMapping : IEntityTypeConfiguration<TokenMap>
    {
        public void Configure(EntityTypeBuilder<TokenMap> builder)
        {
            builder.ToTable(@"Token", @"core");
            builder.Property(x => x.Id).HasColumnName(@"Id").HasColumnType(@"smallint").IsRequired();
            builder.Property(x => x.ChaveToken).HasColumnName(@"ChaveToken").HasColumnType("@varchar(20)").HasMaxLength(20).IsRequired();
            builder.Property(x => x.DataExpiracao).HasColumnName(@"DataExpiracao").HasColumnType(@"smalldatetime").IsRequired();
            builder.Property(x => x.ValorToken).HasColumnName(@"ValorToken").HasColumnType(@"varchar(MAX)").IsRequired();
            builder.HasKey(@"Id");
        }
    }
}