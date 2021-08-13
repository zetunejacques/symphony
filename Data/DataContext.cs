using Microsoft.EntityFrameworkCore;
using Symphony.Domain;

namespace Symphony.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options)
        : base(options)
        {
        }
        public DbSet<ConfigMap> Config { get; set; }
        public DbSet<ExameDeParaMap> ExameDePara { get; set; }
        public DbSet<ExameMap> Exame { get; set; }
        public DbSet<ExamePreConfiguradoMap> ExamePreConfigurado { get; set; }
        public DbSet<ExamePredicaoMap> ExamePredicao { get; set; }
        public DbSet<ExameSuspensoMap> ExameSuspenso { get; set; }
        public DbSet<LisMap> Lis { get; set; }
        public DbSet<LoteErroMap> LoteErro { get; set; }
        public DbSet<LoteMap> Lote { get; set; }
        public DbSet<MotivoSuspensaoMap> MotivoSuspensao { get; set; }
        public DbSet<SoftwareHouseMap> SoftwareHouse { get; set; }
        public DbSet<StatusExameMap> StatusExame { get; set; }
        public DbSet<StatusLoteMap> StatusLote { get; set; }
        public DbSet<TokenMap> Token { get; set; }
        public DbSet<DeParaMaterialMap> DeParaMaterial { get; set; }
        public DbSet<ExameMaterialMap> ExameMaterial { get; set; }
        public DbSet<ExameV2Map> ExameV2 { get; set; }
        public DbSet<ModeloXmlMap> ModeloXml { get; set; }
        public DbSet<TermoAceiteMap> TermoAceite { get; set; }
    }
}