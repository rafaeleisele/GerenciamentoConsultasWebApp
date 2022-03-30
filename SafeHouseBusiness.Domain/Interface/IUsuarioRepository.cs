using SafeHouseBusiness.Domain.Entidades;
using SafeHouseBusiness.Core;

namespace SafeHouseBusiness.Domain.Interface
{
    public interface IUsuarioRepository : IRepository<Usuario>
    {
        IEnumerable<Usuario> BuscarUsuarioPorFiltro();
    }
}
