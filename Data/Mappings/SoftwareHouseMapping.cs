
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Symphony.Domain;
namespace Symphony.Data.Mappings
{
    public class SoftwareHouseMapping : IEntityTypeConfiguration<SoftwareHouseMap>
    {
        public void Configure(EntityTypeBuilder<SoftwareHouseMap> builder)
        {
            builder.ToTable(@"SoftwareHouse", @"core");
            builder.Property(x => x.Id).HasColumnName(@"Id").HasColumnType(@"smallint").IsRequired();
            builder.Property(x => x.NomeSoftwareHouse).HasColumnName(@"NomeSoftwareHouse").HasColumnType("@nvarchar(30)").HasMaxLength(30).IsRequired();
            builder.Property(x => x.RetornarApenasExamesContratados).HasColumnName(@"RetornarApenasExamesContratados").HasColumnType(@"bit").IsRequired();
            builder.Property(x => x.RetornarEmOrdemAlfabetica).HasColumnName(@"RetornarEmOrdemAlfabetica").HasColumnType(@"bit").IsRequired();
            builder.Property(x => x.Senha).HasColumnName(@"Senha").HasColumnType(@"varchar(20)").HasMaxLength(20).IsRequired();
            builder.HasKey(@"Id");
        }
    }
}