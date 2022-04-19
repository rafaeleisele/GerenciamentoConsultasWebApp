using Microsoft.EntityFrameworkCore;
using SafeHouseBusiness.Domain.Entidades;
using SafeHouseBusiness.Domain.Interface;
using SafeHouseBusiness.Infra.Data;

namespace SafeHouseBusiness.Infra.Repository
{
    public class UsuarioLocalConsultaRepository : Repository<UsuarioLocalConsulta>, IUsuarioLocalConsultaRepository
    {
        public UsuarioLocalConsultaRepository(ApplicationDbContext context) : base(context) { }

        public IList<UsuarioLocalConsulta> BuscarUsuarioLocalConsulta(int idUsuario)
        {
            return Set.Where(u => u.IdUsuario == idUsuario)
                .Include(u => u.Usuario)
                .ThenInclude(usuario => usuario.Contato)
                .Include(u => u.LocalConsulta)
                .ToList();
        }
    }
}