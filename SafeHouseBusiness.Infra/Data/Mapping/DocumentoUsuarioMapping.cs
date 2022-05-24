using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SafeHouseBusiness.Domain.Entidades;

namespace SafeHouseBusiness.Infra.Data.Mapping
{
    public class DocumentoUsuarioMapping : IEntityTypeConfiguration<DocumentoUsuario>
    {
        public void Configure(EntityTypeBuilder<DocumentoUsuario> builder)
        {
            builder.ToTable("documentos_usuarios");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).HasColumnName("id").ValueGeneratedOnAdd();
            builder.Property(x => x.IdUsuario).HasColumnName("id_usuario");
            builder.Property(x => x.DataCadastro).HasColumnName("data_cadastro");
            builder.Property(x => x.Guid).HasColumnName("guid");
            builder.Property(x => x.Identificacao).HasColumnName("identificacao");

            builder.HasOne(x => x.Usuario).WithMany(s => s.Documentos).HasForeignKey(x => x.IdUsuario);
        }
    }
}