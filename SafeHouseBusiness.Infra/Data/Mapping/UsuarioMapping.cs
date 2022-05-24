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
            builder.Property(x => x.Id).HasColumnName("id").ValueGeneratedOnAdd();
            builder.Property(x => x.IdContato).HasColumnName("id_contato");
            builder.Property(x => x.IdEndereco).HasColumnName("id_endereco");
            builder.Property(x => x.IdDadosLogin).HasColumnName("id_dados_login");
            builder.Property(x => x.DataCadastro).HasColumnName("data_cadastro");
            builder.Property(x => x.Guid).HasColumnName("guid");
            builder.Property(x => x.Nome).HasColumnName("nome");

            builder.HasMany(p => p.Documentos).WithOne(x => x.Usuario).HasForeignKey(fk => fk.IdUsuario);
            builder.HasOne(p => p.Endereco).WithOne(x => x.Usuario).HasForeignKey<Usuario>(fk => fk.IdEndereco);
            builder.HasOne(p => p.DadosLogin).WithOne(x => x.Usuario).HasForeignKey<Usuario>(fk => fk.IdDadosLogin);
            builder.HasOne(p => p.Contato).WithOne(x => x.Usuario).HasForeignKey<Usuario>(fk => fk.IdContato);
        }
    }
}