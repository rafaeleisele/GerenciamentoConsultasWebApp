using SafeHouseBusiness.Domain.Entidades;

namespace SafehouseBusiness.Models
{
    public class EditarUsuarioModel
    {
        public Usuario Usuario { get; set; }
        public IList<UsuarioLocalConsulta> UsuarioLocaisConsulta { get; set; }

    }
}
