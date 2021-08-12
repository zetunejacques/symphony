using System.Linq;
using Symphony.Domain;

namespace Symphony.Data.Repositories
{
    public class ConfigRepository : Repository
    {
        public ConfigRepository(DataContext context) : base(context)
        {
        }
        public ConfigMap ObterPor(string chave)
        {
            return Contexto.Config.Where(x => x.Chave == chave).FirstOrDefault();
        }
    }
}