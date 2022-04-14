using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SafeHouseBusiness.Domain.Entidades;
using Microsoft.EntityFrameworkCore;

namespace SafeHouseBusiness.Infra.Data.Mapping
{
    public class ReuniaoMapping : IEntityTypeConfiguration<Reuniao>
    {
        public void Configure(EntityTypeBuilder<Reuniao> builder)
        {
            builder.ToTable("reunioes");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id);
            builder.Property(x => x.DataCadastro).HasColumnName("data_cadastro");
            builder.Property(x => x.Guid);
            builder.Property(x => x.Horario);

        }
    }
}
