namespace SafeHouseBusiness.Domain.Entidades
{
    public class Usuario : Entity
    {
        public string Nome { get; set; }

        public Endereco Endereco { get; set; }
        public Contato Contato { get; set; }
        public DadosLogin DadosLogin { get; set; }
        public Documento Documento { get; set; }

        public List<UsuarioLocalConsulta> UsuariosLocalConsulta { get; set; }

    }
}
