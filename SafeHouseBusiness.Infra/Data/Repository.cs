using SafeHouseBusiness.Domain.Entidades;
using Microsoft.EntityFrameworkCore;
using SafeHouseBusiness.Core;
using System.Reflection;

namespace SafeHouseBusiness.Infra.Data
{
    public class Repository<TEntidade> : IRepository<TEntidade> where TEntidade : Entity
    {
        protected DbSet<TEntidade> Set { get; set; }
        protected ApplicationDbContext context { get; private set; }

        public Repository(ApplicationDbContext dbContext)
        {
            context = dbContext;
            Type tipo = typeof(TEntidade);
            MappingProperties(dbContext, tipo);
        }

        public bool Atualizar(TEntidade entity)
        {
            Set.Update(entity);
            context.SaveChanges();

            return true;
        }

        public TEntidade Criar(TEntidade entity)
        {
            var retorno = Set.Add(entity);
            context.SaveChanges();

            return retorno.Entity;
        }

        public bool Deletar(int id)
        {
            Set.Remove(ObterPorId(id));
            context.SaveChanges();

            return true;
        }

        public TEntidade ObterPorGuid(Guid guid) => Set.FirstOrDefault(p => p.Guid == guid);

        public TEntidade ObterPorId(int id) => Set.GetIncludes().FirstOrDefault(x => x.Id == id);

        private void Comparator(Object fromObjeto, PropertyInfo propertyInfo, Type toObjeto)
        {
            var toObjetoName = toObjeto.Name;
            var found = toObjetoName == propertyInfo.Name ? propertyInfo : null;

            if (found != null)
                Set = propertyInfo.GetValue(fromObjeto) as DbSet<TEntidade>;
        }

        private void MappingProperties(Object fromObjeto, Type toObjeto)
        {
            foreach (var properties in fromObjeto.GetType().GetProperties())
            {
                Comparator(fromObjeto, properties, toObjeto);
            }
        }
    }
}