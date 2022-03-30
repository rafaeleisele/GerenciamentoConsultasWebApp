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
            throw new NotImplementedException();
        }

        public bool Criar(TEntidade entity)
        {
            var retorno = Set.Add(entity);
            context.SaveChanges();

            return true;
        }

        public bool Deletar(TEntidade entity)
        {
            throw new NotImplementedException();
        }

        public TEntidade ObterPorGuid(Guid guid)
        {
            throw new NotImplementedException();
        }

        public TEntidade ObterPorId(int id)
        {
            TEntidade entidade  = Set.Find(id);
            return entidade;
        }

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