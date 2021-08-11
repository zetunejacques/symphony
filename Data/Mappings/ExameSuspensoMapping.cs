
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Symphony.Domain;
namespace Symphony.Data.Mappings
{
    public class ExameSuspensoMapping : IEntityTypeConfiguration<ExameSuspensoMap>
    {
        public void Configure(EntityTypeBuilder<ExameSuspensoMap> builder)
        {
            builder.ToTable(@"ExameSuspenso", @"core");
            builder.Property(x => x.Id).HasColumnName(@"Id").HasColumnType(@"int").IsRequired();
            builder.HasOne(x => x.MotivoSuspensao).WithMany(y => y.ExamesSuspensos).HasForeignKey(@"IdMotivoSuspensao");
            builder.Property(x => x.DetalhesMotivoSuspensao).HasColumnName(@"DetalhesMotivoSuspensao").HasColumnType(@"nvarchar(512)").HasMaxLength(512);
            builder.HasKey(@"Id");
        }
    }
}