using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SafeHouseBusiness.Domain.Entidades;
using Microsoft.EntityFrameworkCore;

namespace SafeHouseBusiness.Infra.Data.Mapping 
{
    public class UsuarioLocalConsultaMapping : IEntityTypeConfiguration<UsuarioLocalConsulta>
    {
        public void Configure(EntityTypeBuilder<UsuarioLocalConsulta> builder)
        {
            builder.ToTable("usuarios_locais_consulta");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).HasColumnName("id").ValueGeneratedOnAdd();
            builder.Property(a => a.IdLocalConsulta).IsRequired().HasColumnName("id_local_consulta");
            builder.Property(a => a.IdUsuario).IsRequired().HasColumnName("id_usuario");
            builder.Property(x => x.DataCadastro).HasColumnName("data_cadastro");
            builder.Property(x => x.Guid).HasColumnName("guid");

            builder.HasOne(a => a.LocalConsulta).WithMany(a => a.UsuariosLocalConsulta).HasForeignKey(a => a.IdLocalConsulta);
            builder.HasOne(a => a.Usuario).WithMany(a => a.UsuariosLocalConsulta).HasForeignKey(a => a.IdUsuario);

        }
    }
}
