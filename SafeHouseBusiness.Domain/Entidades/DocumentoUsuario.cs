using SafeHouseBusiness.Domain.Enum;

namespace SafeHouseBusiness.Domain.Entidades
{
    public class DocumentoUsuario : Entity
    {
        public TipoDocumento TipoDocumento { get; set; }
        public string Identificacao { get; set; }

        public Usuario Usuario { get; set; }
        public int IdUsuario { get; set; }
    }
}
