
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Symphony.Domain;
namespace Symphony.Data.Mappings
{
    public class StatusExameMapping : IEntityTypeConfiguration<StatusExameMap>
    {
        public void Configure(EntityTypeBuilder<StatusExameMap> builder)
        {
            builder.ToTable(@"StatusExame", @"core");
            builder.Property(x => x.Id).HasColumnName(@"Id").HasColumnType(@"smallint").IsRequired();
            builder.Property(x => x.ChaveStatus).HasColumnName(@"ChaveStatus").HasColumnType("@varchar(64)").HasMaxLength(64).IsRequired();
            builder.Property(x => x.DescricaoStatusExame).HasColumnName(@"DescricaoStatusExame").HasColumnType("@nvarchar(128)").HasMaxLength(128).IsRequired();
            builder.Property(x => x.BloqueioExame).HasColumnName(@"BloqueioExame").HasColumnType(@"bit").IsRequired();
            builder.Property(x => x.MotivoBloqueio).HasColumnName(@"MotivoBloqueio").HasColumnType("@nvarchar(128)").HasMaxLength(128);
            builder.HasKey(@"Id");
        }
    }
}