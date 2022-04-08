using SafeHouseBusiness.Domain.Entidades;

namespace SafehouseBusiness.Models
{
    public class EditarUsuarioModel
    {
        public string Nome { get; set; }
        public Endereco Endereco { get; set; }
        public Contato Contato { get; set; }

        public EditarUsuarioModel(Usuario usuario)
        {
            Nome = usuario.Nome;
            Endereco = usuario.Endereco;
            Contato = usuario.Contato;
        }
    }
}
