
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Symphony.Domain;
namespace Symphony.Data.Mappings
{
    public class ExameMapping : IEntityTypeConfiguration<ExameMap>
    {
        public void Configure(EntityTypeBuilder<ExameMap> builder)
        {
            builder.ToTable(@"Exame", @"core");
            builder.Property(x => x.Id).HasColumnName(@"Id").HasColumnType(@"int")
                .IsRequired().ValueGeneratedOnAdd();
            builder.Property(x => x.CodExmLab).HasColumnName("CodExmLab").HasColumnType(@"nvarchar(128)").HasMaxLength(128);
            builder.Property(x => x.CodMatLab).HasColumnName("CodMatLab").HasColumnType(@"nvarchar(128)").HasMaxLength(128);
            builder.Property(x => x.DescExmLab).HasColumnName("DescExmLab").HasColumnType(@"nvarchar(512)").HasMaxLength(512);
            builder.HasOne(x => x.StatusExame).WithMany(y => y.Exames).HasForeignKey(@"StatusExame");
            builder.HasOne(x => x.Lote).WithMany(y => y.Exames).HasForeignKey(@"IdLote");
            builder.HasKey(@"Id");
        }
    }
}