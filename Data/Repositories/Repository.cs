using Symphony.Data;
namespace Symphony.Data.Repositories
{
    public class Repository
    {
        protected readonly DataContext Contexto;
        public Repository(DataContext context)
        {
            Contexto = context;
        }
    }
}