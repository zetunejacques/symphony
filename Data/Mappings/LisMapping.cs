
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Symphony.Domain;
namespace Symphony.Data.Mappings
{
    public class LisMapping : IEntityTypeConfiguration<LisMap>
    {
        public void Configure(EntityTypeBuilder<LisMap> builder)
        {
            builder.ToTable(@"Lis", @"core");
            builder.Property(x => x.Id).HasColumnName(@"Id").HasColumnType(@"smallint").IsRequired();
            builder.HasOne(x => x.SoftwareHouse).WithMany(y => y.Lises).HasForeignKey(@"IdSoftwareHouse");
            builder.HasKey(@"Id");
        }
    }
}