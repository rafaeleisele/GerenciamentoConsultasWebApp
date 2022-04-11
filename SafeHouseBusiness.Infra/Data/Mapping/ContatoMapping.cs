using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SafeHouseBusiness.Domain.Entidades;

namespace SafeHouseBusiness.Infra.Data.Mapping
{
    public class ContatoMapping : IEntityTypeConfiguration<Contato>
    {
        public void Configure(EntityTypeBuilder<Contato> builder)
        {
            builder.ToTable("contatos");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).HasColumnName("id");
            builder.Property(x => x.IdUsuarioContato).HasColumnName("id_usuario");
            builder.Property(x => x.Guid).HasColumnName("guid");
            builder.Property(x => x.DataCadastro).HasColumnName("data_cadastro");
            builder.Property(x => x.Email).HasColumnName("email");
            builder.Property(x => x.Telefone).HasColumnName("telefone");

            builder.HasOne(x => x.Usuario).WithOne(s => s.Contato).HasForeignKey<Contato>(x => x.IdUsuarioContato);
        }
    }
}