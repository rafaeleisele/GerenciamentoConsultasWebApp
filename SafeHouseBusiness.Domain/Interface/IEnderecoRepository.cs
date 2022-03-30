using SafeHouseBusiness.Core;
using SafeHouseBusiness.Domain.Entidades;

namespace SafeHouseBusiness.Domain.Interface
{
    public interface IEnderecoRepository : IRepository<Endereco>
    {
        IEnumerable<Endereco> BuscarEnderecosPorFiltro();
    }
}
