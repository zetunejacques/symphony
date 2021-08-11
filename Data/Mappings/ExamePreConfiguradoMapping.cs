
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Symphony.Domain;
namespace Symphony.Data.Mappings
{
    public class ExamePreConfiguradoMapping : IEntityTypeConfiguration<ExamePreConfiguradoMap>
    {
        public void Configure(EntityTypeBuilder<ExamePreConfiguradoMap> builder)
        {
            builder.ToTable(@"Exame", @"core");
            builder.Property(x => x.Id).HasColumnName(@"Id").HasColumnType(@"int")
                .IsRequired().ValueGeneratedOnAdd();
            builder.Property(x => x.CodExmLab).HasColumnName("CodExmLab").HasColumnType(@"nvarchar(128)").HasMaxLength(128);
            builder.Property(x => x.CodMatLab).HasColumnName("CodMatLab").HasColumnType(@"nvarchar(128)").HasMaxLength(128);
            builder.Property(x => x.DescExmLab).HasColumnName("DescExmLab").HasColumnType(@"nvarchar(512)").HasMaxLength(512);
            builder.Property(x => x.DescMat).HasColumnName(@"DescMat").HasColumnType(@"nvarchar(128)").HasMaxLength(128).IsRequired();
            builder.Property(x => x.CodMat).HasColumnName(@"CodMat").HasColumnType(@"nvarchar(15)").HasMaxLength(15).IsRequired();
            builder.Property(x => x.CodExm).HasColumnName(@"CodExm").HasColumnType(@"nvarchar(15)").HasMaxLength(15).IsRequired();
            builder.Property(x => x.DescExm).HasColumnName(@"DescExm").HasColumnType(@"nvarchar(256)").HasMaxLength(256).IsRequired();
            builder.HasOne(x => x.Lote).WithMany(y => y.ExamesPreConfigurados).HasForeignKey(@"IdLote");
            builder.HasKey(@"Id");
        }
    }
}