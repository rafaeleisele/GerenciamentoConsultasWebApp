using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SafeHouseBusiness.Domain.Entidades;

namespace SafeHouseBusiness.Infra.Data.Mapping
{
    public class UsuarioReuniaoMapping : IEntityTypeConfiguration<UsuarioReuniao>
    {
        public void Configure(EntityTypeBuilder<UsuarioReuniao> builder)
        {
            builder.ToTable("usuarios_reunioes");
            builder.HasKey(t => t.Id);
            builder.Property(t => t.Id).HasColumnName("id").ValueGeneratedOnAdd();
            builder.Property(x => x.Guid).HasColumnName("guid");
            builder.Property(x => x.IdUsuarioPaciente).HasColumnName("id_usuario");
            builder.Property(x => x.IdUsuarioConsultor).HasColumnName("id_usuario");
            builder.Property(x => x.IdReuniao).HasColumnName("id_reuniao");

            builder.HasOne(t => t.UsuarioPaciente).WithMany(t=> t.UsuariosReunioes).HasForeignKey(t=>t.IdUsuarioPaciente);
            builder.HasOne(t => t.UsuarioConsultor).WithMany(t=> t.UsuariosReunioesConsultor).HasForeignKey(t=>t.IdUsuarioConsultor);
            builder.HasOne(t => t.Reuniao).WithOne(t=> t.UsuariosReunioes).HasForeignKey<UsuarioReuniao>(t=>t.IdReuniao);

        }
    }
}
