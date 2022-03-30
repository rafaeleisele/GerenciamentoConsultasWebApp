using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SafeHouseBusiness.Domain.Entidades;

namespace SafeHouseBusiness.Infra.Data.Mapping
{
    public class LocalConsultaMapping : IEntityTypeConfiguration<LocalConsulta>
    {
        public void Configure(EntityTypeBuilder<LocalConsulta> builder)
        {
            builder.ToTable("LocalConsulta");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).HasColumnName("id");
            builder.Property(x => x.Guid).HasColumnName("guid");
            builder.Property(x => x.TipoLocalConsulta).HasColumnName("tipo_local_consulta");
        }
    }
}