using Microsoft.EntityFrameworkCore;
using SafeHouseBusiness.Domain.Entidades;
using System.Linq;

namespace SafeHouseBusiness.Infra.Data
{
    public static class QueryExtension
    {
        public static IQueryable<TEntidade> GetIncludes<TEntidade>(this IQueryable<TEntidade> query) where TEntidade : class
        {
            var type = typeof(TEntidade);

            foreach (var item in type.GetProperties())
            {
                if(item.PropertyType.Namespace != "System")
                {
                   query = query.Include(item.Name);
                }
            }

            return query;
        }
    }
}
