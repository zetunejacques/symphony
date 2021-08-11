
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Symphony.Domain;
namespace Symphony.Data.Mappings
{
    public class LoteMapping : IEntityTypeConfiguration<LoteMap>
    {
        public void Configure(EntityTypeBuilder<LoteMap> builder)
        {
            builder.ToTable(@"Lote", @"core");
            builder.Property(x => x.Id).HasColumnName(@"Id").HasColumnType(@"int").IsRequired().ValueGeneratedOnAdd();
            builder.Property(x => x.NumeroLote).HasColumnName(@"NumeroLote").HasColumnType("@char(14)").HasMaxLength(14).IsRequired();
            builder.HasOne(x => x.StatusLote).WithMany(y => y.Lotes).HasForeignKey(@"StatusLote");
            builder.Property(x => x.CodigoLC).HasColumnName(@"CodigoLC").HasColumnType(@"int").IsRequired();
            builder.Property(x => x.LaboratorioConveniado).HasColumnName(@"LaboratorioConveniado").HasColumnType(@"nvarchar(256)").HasMaxLength(256).IsRequired();
            builder.Property(x => x.CNPJ).HasColumnName(@"CNPJ").HasColumnType(@"varchar(18)").HasMaxLength(18).IsRequired();
            builder.Property(x => x.NomeUsuario).HasColumnName(@"NomeUsuario").HasColumnType(@"nvarchar(100)").HasMaxLength(100).IsRequired();
            builder.Property(x => x.CargoUsuario).HasColumnName(@"CargoUsuario").HasColumnType(@"nvarchar(100)").HasMaxLength(100).IsRequired();
            builder.HasOne(x => x.Lis).WithMany(y => y.Lotes).HasForeignKey(@"IdLis");
            builder.Property(x => x.Email).HasColumnName(@"Email").HasColumnType(@"varchar(200)").HasMaxLength(200).IsRequired();
            builder.Property(x => x.TipoEnvio).HasColumnName(@"TipoEnvio").HasColumnType(@"char(3)").HasMaxLength(3).IsRequired();
            builder.Property(x => x.DataInsercao).HasColumnName(@"DataInsercao").HasColumnType(@"smalldatetime").IsRequired();
            builder.Property(x => x.PrevisaoRetorno).HasColumnName(@"PrevisaoRetorno").HasColumnType(@"smalldatetime").IsRequired();
            builder.Property(x => x.DataConclusao).HasColumnName(@"DataConclusao").HasColumnType(@"smalldatetime");
            builder.Property(x => x.DataResgate).HasColumnName(@"DataResgate").HasColumnType(@"smalldatetime");
            builder.Property(x => x.TermoAceite).HasColumnName(@"TermoDeAceite").HasColumnType(@"varchar(MAX)").IsRequired();
            builder.HasKey(@"Id");
        }
    }
}