
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Symphony.Domain;
namespace Symphony.Data.Mappings
{
    public class StatusLoteMapping : IEntityTypeConfiguration<StatusLoteMap>
    {
        public void Configure(EntityTypeBuilder<StatusLoteMap> builder)
        {
            builder.ToTable(@"StatusExame", @"core");
            builder.Property(x => x.Id).HasColumnName(@"Id").HasColumnType(@"smallint").IsRequired();
            builder.Property(x => x.ChaveStatus).HasColumnName(@"ChaveStatus").HasColumnType("@varchar(64)").HasMaxLength(64).IsRequired();
            builder.Property(x => x.DescricaoStatusLote).HasColumnName(@"DescricaoStatusLote").HasColumnType("@nvarchar(128)").HasMaxLength(128).IsRequired();
            builder.HasKey(@"Id");
        }
    }
}