using SafeHouseBusiness.Domain.Entidades;
using SafeHouseBusiness.Domain.Interface;
using SafeHouseBusiness.Infra.Data;

namespace SafeHouseBusiness.Infra.Repository
{
    public class DocumentoRepository : Repository<DocumentoUsuario>, IDocumentoRepository
    {
        public DocumentoRepository(ApplicationDbContext context) : base(context) { }
    }
}
