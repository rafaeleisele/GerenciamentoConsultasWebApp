using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SafeHouseBusiness.Domain.Entidades;

namespace SafeHouseBusiness.Infra.Data.Mapping
{
    public class UsuarioMapping : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.ToTable("Usuario");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).HasColumnName("id");
            builder.Property(x => x.Guid).HasColumnName("guid");
            builder.Property(x => x.Nome).HasColumnName("nome");
            builder.Property(x => x.IdDocumento).HasColumnName("id_documento");
            builder.Property(x => x.IdEndereco).HasColumnName("id_endereco");
            builder.Property(x => x.IdDadosLogin).HasColumnName("id_dadoslogin");
            builder.Property(x => x.IdContato).HasColumnName("id_contato");

            builder.HasOne(p => p.Documento).WithOne(p => p.Usuario).HasPrincipalKey<Documento>(p => p.Id);
            builder.HasOne(p => p.Endereco).WithOne(p => p.Usuario).HasPrincipalKey<Endereco>(p => p.Id);
            builder.HasOne(p => p.DadosLogin).WithOne(p => p.Usuario).HasPrincipalKey<DadosLogin>(p => p.Id);
            builder.HasOne(p => p.Contato).WithOne(p => p.Usuario).HasPrincipalKey<Contato>(p => p.Id);
        }
    }
}