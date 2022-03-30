namespace SafeHouseBusiness.Domain.Entidades
{
    public class Endereco : Entity
    {
        public string Cidade { get; set; }
        public string Cep { get; set; }
        public string Logradouro { get; set; } 
        public string Numero { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public virtual Usuario Usuario { get; set; }
    }
}
