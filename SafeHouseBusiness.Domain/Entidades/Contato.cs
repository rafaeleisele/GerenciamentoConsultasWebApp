namespace SafeHouseBusiness.Domain.Entidades
{
    public class Contato : Entity
    {
        public int Telefone { get; set; }
        public string Email { get; set; }

        public virtual Usuario Usuario { get; set; }
    }
}

