using System.ComponentModel.DataAnnotations.Schema;

namespace SafeHouseBusiness.Domain.Entidades
{
    public class Contato : Entity
    {
        public string Telefone { get; set; }
        public string Email { get; set; }

        [NotMapped]
        public virtual Usuario Usuario { get; set; }
        [NotMapped]
        public virtual LocalConsulta LocalConsulta { get; set; }
    }
}

