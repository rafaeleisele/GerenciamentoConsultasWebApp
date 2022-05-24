using SafeHouseBusiness.Domain.Enum;
using System.ComponentModel.DataAnnotations.Schema;

namespace SafeHouseBusiness.Domain.Entidades
{
    public class LocalConsulta : Entity
    {
        public int IdContato { get; set; }
        public int IdDocumento { get; set; }
        public int IdEndereco { get; set; }
        public string Nome { get; set; }
        public TipoLocalConsulta TipoLocalConsulta { get; set; }
        
        public virtual Contato Contato { get; set; }
        public virtual Endereco Endereco { get; set; }
        public virtual List<Reuniao> Reunioes { get; set; }
        public virtual List<Unidade> Unidades { get; set; }
        public virtual List<DocumentoLocalConsulta> Documentos { get; set; }
        public virtual List<UsuarioLocalConsulta> UsuariosLocalConsulta { get; set; }
    }
}
