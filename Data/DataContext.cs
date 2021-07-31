using Microsoft.EntityFrameworkCore;
using Symphony.Models;

namespace Symphony.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options)
        : base(options)
        {

        }
        public DbSet<Lote> Lote { get; set; }
        public DbSet<LoteExame> LoteExame { get; set; }
        public DbSet<StatusExame> StatusExame { get; set; }
        public DbSet<StatusLote> StatusLote { get; set; }

    }
}