
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Symphony.Domain;
namespace Symphony.Data.Mappings
{
    public class MotivoSuspensaoMapping : IEntityTypeConfiguration<MotivoSuspensaoMap>
    {
        public void Configure(EntityTypeBuilder<MotivoSuspensaoMap> builder)
        {
            builder.ToTable(@"MotivoSuspensao", @"core");
            builder.Property(x => x.Id).HasColumnName(@"Id").HasColumnType(@"smallint").IsRequired();
            builder.Property(x => x.DescricaoMotivoSuspensao).HasColumnName(@"DescricaoMotivoSuspensao").HasColumnType("@nvarchar(64)").HasMaxLength(64).IsRequired();
            builder.HasKey(@"Id");
        }
    }
}