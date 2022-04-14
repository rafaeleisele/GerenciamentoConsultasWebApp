using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SafeHouseBusiness.Domain.Entidades;
using Microsoft.EntityFrameworkCore;

namespace SafeHouseBusiness.Infra.Data.Mapping
{
    public class UsuarioMapping : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.ToTable("usuarios");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).HasColumnName("id");
            builder.Property(x => x.DataCadastro).HasColumnName("data_cadastro");
            builder.Property(x => x.Guid).HasColumnName("guid");
            builder.Property(x => x.Nome).HasColumnName("nome");

            builder.HasOne(p => p.Documento).WithOne(x => x.Usuario).HasForeignKey<Documento>(fk => fk.IdUsuarioDocumento);
            builder.HasOne(p => p.Endereco).WithOne(x => x.Usuario).HasForeignKey<Endereco>(fk => fk.IdUsuarioEndereco);
            builder.HasOne(p => p.DadosLogin).WithOne(x => x.Usuario).HasForeignKey<DadosLogin>(fk => fk.IdUsuarioDadosLogin);
            builder.HasOne(p => p.Contato).WithOne(x => x.Usuario).HasForeignKey<Contato>(fk => fk.IdUsuarioContato);

        }
    }
}