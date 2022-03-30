using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SafeHouseBusiness.Domain.Entidades;

namespace SafeHouseBusiness.Infra.Data.Mapping
{
    public class DadosLoginMapping : IEntityTypeConfiguration<DadosLogin>
    {
        public void Configure(EntityTypeBuilder<DadosLogin> builder)
        {
            builder.ToTable("DadosLogin");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).HasColumnName("id");
            builder.Property(x => x.Guid).HasColumnName("guid");
            builder.Property(x => x.UserName).HasColumnName("login");
            builder.Property(x => x.Senha).HasColumnName("senha");
        }
    }
}