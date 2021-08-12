
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Symphony.Domain;
namespace Symphony.Data.Mappings
{
    public class DeParaMaterialMapping : IEntityTypeConfiguration<DeParaMaterialMap>
    {
        public void Configure(EntityTypeBuilder<DeParaMaterialMap> builder)
        {
            builder.ToTable(@"DeParaMaterial", @"recursos");
            builder.Property(x => x.Id).HasColumnName(@"Id").HasColumnType(@"int").IsRequired().ValueGeneratedOnAdd();
            builder.Property(x => x.DescMatLab).HasColumnName(@"DescMatLab").HasColumnType(@"nvarchar(128)").HasMaxLength(128).IsRequired();
            builder.Property(x => x.DescMatReal).HasColumnName(@"DescMatReal").HasColumnType(@"nvarchar(128)").HasMaxLength(128).IsRequired();
            builder.HasKey(@"Id");
        }
    }
}