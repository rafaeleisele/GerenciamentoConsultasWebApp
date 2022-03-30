using SafeHouseBusiness.Domain.Entidades;
using SafeHouseBusiness.Domain.Interface;
using SafeHouseBusiness.Infra.Data;

namespace SafeHouseBusiness.Infra.Repository
{
    public class EnderecoRepository : Repository<Endereco>, IEnderecoRepository
    {
        public EnderecoRepository(ApplicationDbContext context) : base(context) { }

        public IEnumerable<Endereco> BuscarEnderecosPorFiltro()
        {
            return Set.OrderBy(p => p.Id).ToList();
        }
    }
}