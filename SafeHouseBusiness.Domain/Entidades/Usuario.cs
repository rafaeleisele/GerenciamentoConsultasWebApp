namespace SafeHouseBusiness.Domain.Entidades
{
    public class Usuario : Entity
    {
        public int IdDocumento { get; set; }
        public int IdEndereco { get; set; }
        public int IdDadosLogin { get; set; }
        public int IdContato { get; set; }
        public string Nome { get; set; }

        public virtual Endereco Endereco { get; set; }
        public virtual Contato Contato { get; set; }
        public virtual DadosLogin DadosLogin { get; set; }
        public virtual Documento Documento { get; set; }
    }
}
