using SafeHouseBusiness.Domain.Entidades;
using SafeHouseBusiness.Core;

namespace SafeHouseBusiness.Domain.Interface
{
    public interface IUnidadeRepository : IRepository<Unidade>
    {
        IEnumerable<Unidade> BuscarUnidadePorFiltro();
    }
}

