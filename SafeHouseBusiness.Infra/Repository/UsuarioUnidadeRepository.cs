using Microsoft.EntityFrameworkCore;
using SafeHouseBusiness.Domain.Entidades;
using SafeHouseBusiness.Domain.Interface;
using SafeHouseBusiness.Infra.Data;

namespace SafeHouseBusiness.Infra.Repository
{
    public class UsuarioUnidadeRepository : Repository<UsuarioUnidade>, IUsuarioUnidadeRepository
    {
        public UsuarioUnidadeRepository(ApplicationDbContext context) : base(context) { }
    }
}