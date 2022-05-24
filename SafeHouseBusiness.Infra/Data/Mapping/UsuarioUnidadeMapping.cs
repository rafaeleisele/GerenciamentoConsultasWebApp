using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SafeHouseBusiness.Domain.Entidades;

namespace SafeHouseBusiness.Infra.Data.Mapping
{
    public class UsuarioUnidadeMapping : IEntityTypeConfiguration<UsuarioUnidade>
    {
        public void Configure(EntityTypeBuilder<UsuarioUnidade> builder)
        {
            builder.ToTable("usuarios_unidades");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).HasColumnName("id").ValueGeneratedOnAdd();
            builder.Property(x => x.DataCadastro).HasColumnName("data_cadastro");
            builder.Property(x => x.Guid).HasColumnName("guid");
            builder.Property(a => a.IdUnidade).IsRequired().HasColumnName("id_unidade");
            builder.Property(a => a.IdUsuario).IsRequired().HasColumnName("id_usuario");

            builder.HasOne(a => a.Unidade).WithMany(a => a.UsuariosUnidades).HasForeignKey(a => a.IdUnidade);
            builder.HasOne(a => a.Usuario).WithMany(a => a.UsuariosUnidades).HasForeignKey(a => a.IdUsuario);

        }
    }
}