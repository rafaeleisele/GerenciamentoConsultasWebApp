namespace SafeHouseBusiness.Domain.Entidades
{
    public class Contato : Entity
    {
        public string Telefone { get; set; }
        public string Email { get; set; }

        public int IdUsuarioContato { get; set; }
        public Usuario Usuario { get; set; }
    }
}

