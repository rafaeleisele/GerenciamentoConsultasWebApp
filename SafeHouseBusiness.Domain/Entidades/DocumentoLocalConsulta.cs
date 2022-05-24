using SafeHouseBusiness.Domain.Enum;

namespace SafeHouseBusiness.Domain.Entidades
{
    public class DocumentoLocalConsulta : Entity
    {
        public int IdLocalConsulta { get; set; }
        public string Identificacao { get; set; }
        public TipoDocumento TipoDocumento { get; set; }

        public LocalConsulta LocalConsulta { get; set; }
    }
}
