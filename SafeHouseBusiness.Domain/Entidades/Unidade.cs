namespace SafeHouseBusiness.Domain.Entidades
{
    public class Unidade : Entity
    {
        public int Numero { get; set; }
        public int IdLocalConsulta { get; set; }
        public int IdUsuarioUnidade { get; set; }
        public decimal Aluguel { get; set; }
        public double Tamanho { get; set; }
        public string Nome { get; set; }

        public virtual Usuario Usuario { get; set; }
        public virtual LocalConsulta LocalConsulta { get; set; }
        public virtual List<UsuarioUnidade> UsuariosUnidades { get; set; }
        public virtual List<Reuniao> Reunioes { get; set; }
    }
}
