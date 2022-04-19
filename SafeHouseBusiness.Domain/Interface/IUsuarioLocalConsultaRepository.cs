using SafeHouseBusiness.Domain.Entidades;
using SafeHouseBusiness.Core;

namespace SafeHouseBusiness.Domain.Interface
{
    public interface IUsuarioLocalConsultaRepository : IRepository<UsuarioLocalConsulta>
    {
        IList<UsuarioLocalConsulta> BuscarUsuarioLocalConsulta(int idUsuario);
    }
}
