namespace SafeHouseBusiness.Domain.Entidades
{
    public class Reuniao : Entity
    {
        public DateTime Horario { get; set; }
        public LocalConsulta LocalConsulta { get; set; }
        public Usuario Paciente { get; set; }
        public Usuario Consultor { get; set; }
    }
}
