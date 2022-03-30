using SafeHouseBusiness.Domain.Enum;

namespace SafeHouseBusiness.Domain.Entidades
{
    public class Documento : Entity
    {
        public TipoDocumento TipoDocumento { get; set; }
        public string Identificacao { get; set; }

        public virtual Usuario Usuario { get; set; }
    }
}
