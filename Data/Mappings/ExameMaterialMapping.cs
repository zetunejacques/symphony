
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Symphony.Domain;
namespace Symphony.Data.Mappings
{
    public class ExameMaterialMapping : IEntityTypeConfiguration<ExameMaterialMap>
    {
        public void Configure(EntityTypeBuilder<ExameMaterialMap> builder)
        {
            builder.ToTable(@"ExameMaterial", @"recursos");
            builder.Property(x => x.Id).HasColumnName(@"Id").HasColumnType(@"int").IsRequired().ValueGeneratedOnAdd();
            builder.Property(x => x.CodMat).HasColumnName(@"CodMat").HasColumnType(@"nvarchar(15)").HasMaxLength(15).IsRequired();
            builder.Property(x => x.CodExm).HasColumnName(@"CodExm").HasColumnType(@"nvarchar(15)").HasMaxLength(15).IsRequired();
            builder.Property(x => x.DescMatReal).HasColumnName(@"DescMatReal").HasColumnType(@"nvarchar(128)").HasMaxLength(128).IsRequired();
            builder.HasKey(@"Id");
        }
    }
}