using SafeHouseBusiness.Domain.Entidades;

namespace SafehouseBusiness.Models
{
    public class EditarUsuarioModel
    {
        public Usuario Usuario { get; set; }
        public IList<UsuarioLocalConsulta> UsuarioLocaisConsulta { get; set; }

        public EditarUsuarioModel(IList<UsuarioLocalConsulta> usuariosLocalConsultas)
        {
            Usuario = usuariosLocalConsultas.FirstOrDefault().Usuario;
            UsuarioLocaisConsulta = usuariosLocalConsultas;
        }
    }
}
