using Microsoft.EntityFrameworkCore;
using SafeHouseBusiness.Domain.Entidades;
using SafeHouseBusiness.Infra.Data.Mapping;

namespace SafeHouseBusiness.Infra.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Contato> Contato { get; set; }
        public DbSet<DadosLogin> DadosLogin { get; set; }
        public DbSet<DocumentoLocalConsulta> DocumentoLocalConsulta { get; set; }
        public DbSet<DocumentoUsuario> DocumentoUsuario { get; set; }
        public DbSet<Endereco> Endereco { get; set; }
        public DbSet<LocalConsulta> LocalConsulta { get; set; }
        public DbSet<Reuniao> Reuniao { get; set; }
        public DbSet<Usuario> Usuario { get; set; }
        public DbSet<UsuarioLocalConsulta> UsuarioLocalConsulta { get; set; }
        public DbSet<UsuarioReuniao> UsuarioReuniao { get; set; }
        public DbSet<UsuarioUnidade> UsuarioUnidade { get; set; }
        public DbSet<Unidade> Unidade { get; set; }
        
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> dbContext) : base(dbContext) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ContatoMapping());
            modelBuilder.ApplyConfiguration(new DadosLoginMapping());
            modelBuilder.ApplyConfiguration(new DocumentoUsuarioMapping());
            modelBuilder.ApplyConfiguration(new DocumentoLocalConsultaMapping());
            modelBuilder.ApplyConfiguration(new EnderecoMapping());
            modelBuilder.ApplyConfiguration(new LocalConsultaMapping());
            modelBuilder.ApplyConfiguration(new ReuniaoMapping());
            modelBuilder.ApplyConfiguration(new UsuarioMapping());
            modelBuilder.ApplyConfiguration(new UsuarioLocalConsultaMapping());
            modelBuilder.ApplyConfiguration(new UnidadeMapping());
            modelBuilder.ApplyConfiguration(new UsuarioReuniaoMapping());
            modelBuilder.ApplyConfiguration(new UsuarioUnidadeMapping());

            base.OnModelCreating(modelBuilder);
        }
    }
}