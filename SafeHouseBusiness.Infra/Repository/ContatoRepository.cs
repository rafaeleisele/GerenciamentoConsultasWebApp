using SafeHouseBusiness.Domain.Entidades;
using SafeHouseBusiness.Domain.Interface;
using SafeHouseBusiness.Infra.Data;


namespace SafeHouseBusiness.Infra.Repository
{
    public class ContatoRepository : Repository<Contato>, IContatoRepository
    {
        public ContatoRepository(ApplicationDbContext context) : base(context) { }

        public IEnumerable<Contato> BuscarContatosPorFiltro()
        {
            return Set.OrderBy(p => p.Id).ToList();
        }
    }
}
