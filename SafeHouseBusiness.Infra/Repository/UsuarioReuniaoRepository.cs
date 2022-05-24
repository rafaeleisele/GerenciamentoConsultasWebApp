using Microsoft.EntityFrameworkCore;
using SafeHouseBusiness.Domain.Entidades;
using SafeHouseBusiness.Domain.Interface;
using SafeHouseBusiness.Infra.Data;

namespace SafeHouseBusiness.Infra.Repository
{
    public class UsuarioReuniaoRepository : Repository<UsuarioReuniao>, IUsuarioReuniaoRepository
    {
        public UsuarioReuniaoRepository(ApplicationDbContext context) : base(context) { }
    }
}