using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SafeHouseBusiness.Domain.Entidades;
using Microsoft.EntityFrameworkCore;

namespace SafeHouseBusiness.Infra.Data.Mapping
{
    public class ReuniaoMapping : IEntityTypeConfiguration<Reuniao>
    {
        public void Configure(EntityTypeBuilder<Reuniao> builder)
        {
            builder.ToTable("Reuniao");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id);
            builder.Property(x => x.Guid);
            builder.Property(x => x.Horario);
        }
    }
}
