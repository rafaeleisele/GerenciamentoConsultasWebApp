namespace SafeHouseBusiness.Domain.Entidades
{
    public class Reuniao : Entity
    {
        public DateTime Horario { get; set; }
        public LocalConsulta LocalConsulta { get; set; }
        public Unidade Unidade { get; set; }

        public int IdLocalConsulta { get; set; }
        public int IdUnidade { get; set; }

        public virtual UsuarioReuniao UsuariosReunioes { get; set; }
    }
}
