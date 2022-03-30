using SafeHouseBusiness.Domain.Enum;
using System.ComponentModel.DataAnnotations.Schema;

namespace SafeHouseBusiness.Domain.Entidades
{
    public class LocalConsulta : Entity
    {
        public string Nome { get; set; }
        public Endereco Endereco { get; set; }
        public TipoLocalConsulta TipoLocalConsulta { get; set; }
        public Documento Documento { get; set; }

        [NotMapped]
        public virtual IList<Usuario> Usuarios { get; set;}
    }
}
