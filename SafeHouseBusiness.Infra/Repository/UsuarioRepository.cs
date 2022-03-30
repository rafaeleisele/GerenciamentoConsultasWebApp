using SafeHouseBusiness.Domain.Entidades;
using SafeHouseBusiness.Domain.Interface;
using Microsoft.EntityFrameworkCore;
using SafeHouseBusiness.Infra.Data;

namespace SafeHouseBusiness.Infra.Repository
{
    public class UsuarioRepository : Repository<Usuario>, IUsuarioRepository
    {
        public UsuarioRepository(ApplicationDbContext context) : base(context) { }

        public IEnumerable<Usuario> BuscarUsuarioPorFiltro()
        {
            return Set.Include(p => p.Contato).Include(p => p.Endereco).OrderBy(p => p.Id).ToList();
        }
    }
}