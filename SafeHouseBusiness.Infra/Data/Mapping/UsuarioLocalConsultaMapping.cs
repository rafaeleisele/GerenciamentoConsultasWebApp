using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SafeHouseBusiness.Domain.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafeHouseBusiness.Infra.Data.Mapping 
{
    public class UsuarioLocalConsultaMapping : IEntityTypeConfiguration<UsuarioLocalConsulta>
    {
        public void Configure(EntityTypeBuilder<UsuarioLocalConsulta> builder)
        {
            builder.ToTable("usuarioLocalConsulta");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).HasColumnName("id");
            builder.Property(x => x.Guid).HasColumnName("guid");
            builder.Property(a => a.IdLocalConsulta).IsRequired().HasColumnName("id_consulta");
            builder.Property(a => a.IdUsuario).IsRequired().HasColumnName("id_usuario");
            builder.HasOne(a => a.Usuario).WithMany(a => a.UsuariosLocalConsulta).HasForeignKey(a => a.IdUsuario);
            builder.HasOne(a => a.LocalConsulta).WithMany(a => a.UsuariosLocalConsulta).HasForeignKey(a => a.IdLocalConsulta);

        }
    }
}
