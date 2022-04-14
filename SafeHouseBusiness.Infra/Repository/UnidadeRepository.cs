using SafeHouseBusiness.Domain.Entidades;
using SafeHouseBusiness.Domain.Interface;
using SafeHouseBusiness.Infra.Data;

namespace SafeHouseBusiness.Infra.Repository
{
    public class UnidadeRepository : Repository<Unidade>, IUnidadeRepository
    {
        public UnidadeRepository(ApplicationDbContext context) : base(context) { }

        public IEnumerable<Unidade> BuscarUnidadePorFiltro()
        {
            return Set.OrderBy(p => p.Id).ToList();
        }
    }
}