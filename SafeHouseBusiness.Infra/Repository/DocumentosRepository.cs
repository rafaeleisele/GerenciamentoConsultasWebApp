using SafeHouseBusiness.Domain.Entidades;
using SafeHouseBusiness.Domain.Interface;
using SafeHouseBusiness.Infra.Data;

namespace SafeHouseBusiness.Infra.Repository
{
    public class DocumentosRepository : Repository<Documento>, IDocumentoRepository
    {
        public DocumentosRepository(ApplicationDbContext context) : base(context) { }
    }
}
