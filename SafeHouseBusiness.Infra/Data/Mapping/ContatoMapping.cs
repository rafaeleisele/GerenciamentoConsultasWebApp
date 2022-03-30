using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SafeHouseBusiness.Domain.Entidades;

namespace SafeHouseBusiness.Infra.Data.Mapping
{
    public class ContatoMapping : IEntityTypeConfiguration<Contato>
    {
        public void Configure(EntityTypeBuilder<Contato> builder)
        {
            builder.ToTable("Contatos");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).HasColumnName("id");
            builder.Property(x => x.Guid).HasColumnName("guid");
            builder.Property(x => x.Email).HasColumnName("nome");
            builder.Property(x => x.Telefone).HasColumnName("nome");

            builder.HasOne(p => p.Usuario).WithOne(p => p.Contato).HasForeignKey<Usuario>(p => p.IdContato);
        }
    }
}