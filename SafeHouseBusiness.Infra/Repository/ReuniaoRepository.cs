using SafeHouseBusiness.Domain.Entidades;
using SafeHouseBusiness.Domain.Interface;
using SafeHouseBusiness.Infra.Data;

namespace SafeHouseBusiness.Infra.Repository
{
    public class ReuniaoRepository : Repository<Reuniao>, IReuniaoRepository
    {
        public ReuniaoRepository(ApplicationDbContext context) : base(context) { }
    }
}
