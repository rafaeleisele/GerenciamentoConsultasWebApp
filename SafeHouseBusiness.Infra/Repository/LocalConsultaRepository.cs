using SafeHouseBusiness.Domain.Entidades;
using SafeHouseBusiness.Domain.Interface;
using SafeHouseBusiness.Infra.Data;

namespace SafeHouseBusiness.Infra.Repository
{
    public class LocalConsultaRepository : Repository<LocalConsulta>, ILocalConsultaRepository
    {
        public LocalConsultaRepository(ApplicationDbContext context) : base(context) { }
    }
}