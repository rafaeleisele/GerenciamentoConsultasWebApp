namespace SafeHouseBusiness.Domain.Entidades
{
    public class Usuario : Entity
    {

        public int IdContato { get; set; }
        public int IdEndereco { get; set; }
        public int IdDadosLogin { get; set; }
        public string Nome { get; set; }

        public virtual Endereco Endereco { get; set; }
        public virtual Contato Contato { get; set; }
        public virtual DadosLogin DadosLogin { get; set; }

        public virtual List<DocumentoUsuario> Documentos { get; set; }

        public virtual List<UsuarioUnidade> UsuariosUnidades { get; set; }
        public virtual List<UsuarioReuniao> UsuariosReunioes { get; set; }
        public virtual List<UsuarioReuniao> UsuariosReunioesConsultor { get; set; }
        public virtual List<UsuarioLocalConsulta> UsuariosLocalConsulta { get; set; }
    }
}
