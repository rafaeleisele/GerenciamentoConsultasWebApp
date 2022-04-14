using SafeHouseBusiness.Domain.Entidades;
using SafeHouseBusiness.Domain.Interface;
using SafeHouseBusiness.Infra.Data;

namespace SafeHouseBusiness.Infra.Repository
{
    public class UsuarioLocalConsultaRepository : Repository<UsuarioLocalConsulta>, IUsuarioLocalConsultaRepository
    {
        public UsuarioLocalConsultaRepository(ApplicationDbContext context) : base(context) { }
    }
}