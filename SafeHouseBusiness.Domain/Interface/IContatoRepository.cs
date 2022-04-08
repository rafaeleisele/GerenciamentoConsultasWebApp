using SafeHouseBusiness.Core;
using SafeHouseBusiness.Domain.Entidades;

namespace SafeHouseBusiness.Domain.Interface
{
    public interface IContatoRepository : IRepository<Contato>
    {
        IEnumerable<Contato> BuscarContatosPorFiltro();
    }
}
