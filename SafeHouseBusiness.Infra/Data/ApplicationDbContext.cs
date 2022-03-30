using Microsoft.EntityFrameworkCore;
using SafeHouseBusiness.Domain.Entidades;
using SafeHouseBusiness.Infra.Data.Mapping;

namespace SafeHouseBusiness.Infra.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<LocalConsulta> LocalConsulta { get; set; }
        public DbSet<Documento> Documento { get; set; }
        public DbSet<Endereco> Endereco { get; set; }
        public DbSet<Reuniao> Reuniao { get; set; }
        public DbSet<Usuario> Usuario { get; set; }
        

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> dbContext) : base(dbContext) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UsuarioMapping());
            modelBuilder.ApplyConfiguration(new DocumentoMapping());
            modelBuilder.ApplyConfiguration(new EnderecoMapping());
            modelBuilder.ApplyConfiguration(new ReuniaoMapping());
            modelBuilder.ApplyConfiguration(new LocalConsultaMapping());

            base.OnModelCreating(modelBuilder);
        }
    }
}