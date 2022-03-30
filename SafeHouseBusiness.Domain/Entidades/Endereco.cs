namespace SafeHouseBusiness.Domain.Entidades
{
    public class Endereco : Entity
    {
        public string Cidade { get; set; }
        public int Cep { get; set; }
        public string Logradouro { get; set; } 
        public int Numero { get; set; }
        public string Complemento { get; set; }
        public virtual Usuario Usuario { get; set; }
    }
}
