namespace SafeHouseBusiness.Domain.Entidades
{
    public class Usuario : Entity
    {
        public int IdDocumento { get; set; }
        public int IdEndereco { get; set; }
        public int IdDadosLogin { get; set; }
        public int IdContato { get; set; }
        public string Nome { get; set; }

        public Endereco Endereco { get; set; }
        public Contato Contato { get; set; }
        public DadosLogin DadosLogin { get; set; }
        public Documento Documento { get; set; }

        public List<UsuarioLocalConsulta> UsuariosLocalConsulta { get; set; }

    }
}
