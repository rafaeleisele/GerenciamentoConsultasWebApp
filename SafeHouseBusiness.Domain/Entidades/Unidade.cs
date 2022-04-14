namespace SafeHouseBusiness.Domain.Entidades
{
    public class Unidade : Entity
    {
        public int UnidadeNumero { get; set; }
        public string UnidadeNome { get; set; }
        public LocalConsulta LocalConsulta { get; set; }
        public Usuario Usuario { get; set; }
        public double Aluguel { get; set; }
        public double Tamanho { get; set; }

        //Unidades, gostaria de entender melhor como funciona a função buscar por filtro nas interfaces
    }
}
