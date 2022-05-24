using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SafeHouseBusiness.Domain.Entidades;
using Microsoft.EntityFrameworkCore;

namespace SafeHouseBusiness.Infra.Data.Mapping
{
    public class DocumentoLocalConsultaMapping : IEntityTypeConfiguration<DocumentoLocalConsulta>
    {
        public void Configure(EntityTypeBuilder<DocumentoLocalConsulta> builder)
        {
            builder.ToTable("documentos_local_consulta");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).HasColumnName("id").ValueGeneratedOnAdd();
            builder.Property(x => x.IdLocalConsulta).HasColumnName("id_local_consulta");
            builder.Property(x => x.DataCadastro).HasColumnName("data_cadastro");
            builder.Property(x => x.Guid).HasColumnName("guid");
            builder.Property(x => x.Identificacao).HasColumnName("identificacao");

            builder.HasOne(x => x.LocalConsulta).WithMany(s => s.Documentos).HasForeignKey(x => x.IdLocalConsulta);
        }
    }
}