namespace SafeHouseBusiness.Domain.Entidades
{
    public class DadosLogin : Entity
    {
        public String Senha { get; set; }
        public String UserName { get; set; }

        public virtual Usuario Usuario { get; set; }
    }
}
