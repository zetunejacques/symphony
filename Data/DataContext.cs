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
        public DbSet<Exame> Exame { get; set; }

    }
}